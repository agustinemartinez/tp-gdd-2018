using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel {
    public class Factura {

        string tipo;
        string nro;
        DateTime fecha;
        string reservaNro;
        string formaDePago;
        long hotelCodigo;
        string hotelNombre;
        string regimen;
        string nombreCliente;
        List<Item> items;
        decimal total;

        public string getTipo() { return this.tipo; }
        public string getNro() { return this.nro; }
        public DateTime getFecha() { return this.fecha; }
        public string getReservaNro() { return this.reservaNro; }
        public string getFormaDePago() { return this.formaDePago; }
        public string getHotelNombre() { return this.hotelNombre; }
        public string getRegimen() { return this.regimen; }
        public long getHotelCodigo() { return this.hotelCodigo; }
        public string getNombreCliente() { return this.nombreCliente; }
        public decimal getTotalEstadia() { return this.total - this.calcularTotalConsumibles(); }
        public decimal getTotal() { return this.total; }
        public List<Item> getItems() { return this.items; }

        public void agregarItem(Item i) {
            if (this.regimen.Equals("All inclusive"))
                i.setPrecioUnitario(0);
            items.Add(i); 
        }

        public Factura(string reservaNro, string formaDePago) {
            this.reservaNro = reservaNro;
            this.formaDePago = formaDePago;
            this.items = new List<Item>() { };
        }

        public bool reservaCanceladaOFacturada() {
            string query = "SELECT 1 FROM FAAE.Reserva WHERE rese_codigo = " + this.reservaNro;
            query += " AND rese_estado NOT LIKE '%cancelada%' AND rese_codigo NOT IN (SELECT fact_rese_codigo FROM FAAE.Factura)";
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);
            bool cancelada = dataReader.Read();
            dataReader.Close();
            return cancelada;
        }

        // Tendria que ir en Reserva
        public bool reservaExists() {
            string query = "SELECT 1 FROM FAAE.Reserva WHERE rese_codigo = " + this.reservaNro;
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);
            bool exists = dataReader.Read();
            dataReader.Close();
            return exists;
        }

        public bool estadiaFinalizada() {
            string query = "SELECT 1 FROM FAAE.Estadia WHERE esta_rese_codigo = " + this.reservaNro + " AND esta_fecha_salida IS NOT NULL";
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);
            bool finalizada = dataReader.Read();
            dataReader.Close();
            return finalizada;
        }

        public int cantidadNochesReservadas() {
            int cantNoches;
            string query = "SELECT DATEDIFF(DAY, rese_fecha_desde, rese_fecha_hasta)-1 cantNoches FROM FAAE.Reserva WHERE rese_codigo = " + this.reservaNro;
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);
            dataReader.Read();
            cantNoches = Convert.ToInt32(dataReader["cantNoches"]);
            dataReader.Close();
            return cantNoches;
        }

        public void generar() {
            string query = "SELECT fact_tipo, fact_nro, hote_codigo, hote_nombre, regi_codigo, nombreApellido";
            query += " FROM FAAE.NuevaFactura(" + this.reservaNro + ")";
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);

            if (dataReader.Read()) {
                this.tipo = dataReader["fact_tipo"].ToString();
                this.nro = dataReader["fact_nro"].ToString();
                this.hotelCodigo = Convert.ToInt64(dataReader["hote_codigo"]);
                this.hotelNombre = dataReader["hote_nombre"].ToString();
                this.regimen = dataReader["regi_codigo"].ToString();
                this.nombreCliente = dataReader["nombreApellido"].ToString();
            }
            dataReader.Close();

            this.fecha = DateTime.Now;
            this.total = this.calcularTotalEstadia() + this.calcularTotalConsumibles();
            this.agregarItem(new Item("0000", "Estadia " + this.cantidadNochesReservadas() + " noches " + this.regimen, 1, this.getTotalEstadia()));
        }

        public decimal calcularTotalEstadia() {
            decimal totalEstadia;
            string query = "SELECT FAAE.calcularTotalEstadia(" + this.reservaNro + ") " + "totalEstadia";
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);
            dataReader.Read();
            totalEstadia = Convert.ToDecimal(dataReader["totalEstadia"]);
            dataReader.Close();
            return totalEstadia;
        }

        public decimal calcularTotalConsumibles() {
            return this.items.Sum(item => item.total());
        }

        public void guardar() {
            string[] param1 = { "@fact_tipo", "@fact_nro", "@fact_fecha", "@fact_total", "@fact_rese_codigo" };
            object[] args1 = { this.tipo, this.nro, this.fecha, this.total, this.reservaNro };
            DBConnection.Instance.executeProcedure("FAAE.guardar_factura", param1, args1);
            
            List<Item> consumibles = this.items;
            consumibles.RemoveAt(0);  // El primer item siempre es la estadia, y se saltea
            string[] param2 = { "@fact_tipo", "@fact_nro", "@item_cons_codigo", "@cantidad", "@precio" };
            consumibles.ForEach(item => {
                object[] args2 = { this.tipo, this.nro, item.getCodigo(), item.getCantidad(), item.getPrecioUnitario() };
                DBConnection.Instance.executeProcedure("FAAE.guardar_items_factura", param2, args2);
            });
        }

    }
}
