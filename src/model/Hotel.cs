using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel {
    public class Hotel {

        private int codigo;
        private string nombre;
        private short estrellas;
        private string ciudad;
        private string pais;
        private string mail;
        private string telefono;
        private string dire_calle;
        private string dire_nro;
        private DateTime fechaCreacion;
        private decimal recargaEstrellas;
        List<string> regimenes;

        public Hotel() { 
            this.codigo = 0;
            this.regimenes = new List<string>();
        }

        public Hotel(int codigo) { 
            this.codigo = codigo;
            this.regimenes = new List<string>();
        }

        public Hotel(int codigo, string nombre) { 
            this.codigo = codigo; 
            this.nombre = nombre;
            this.regimenes = new List<string>();
        }

        public int getCodigo() { return this.codigo; }
        public string getNombre() { return this.nombre; }
        public short getEstrellas() { return this.estrellas; }
        public string getCiudad() { return this.ciudad; }
        public string getPais() { return this.pais; }
        public string getMail() { return this.mail; }
        public string getTelefono() { return this.telefono; }
        public string getDire_calle() { return this.dire_calle; }
        public string getDire_nro() { return this.dire_nro; }
        public DateTime getFechaCreacion() { return this.fechaCreacion; }
        public decimal getRecargaEstrellas() { return this.recargaEstrellas; }
        public List<string> getRegimenes() { return this.regimenes; }

        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setEstrellas(short estrellas) { this.estrellas = estrellas; }
        public void setCiudad(string ciudad) { this.ciudad = ciudad; }
        public void setPais(string pais) { this.pais = pais; }
        public void setMail(string mail) { this.mail = mail; }
        public void setTelefono(string telefono) { this.telefono = telefono; }
        public void setDire_calle(string dire_calle) { this.dire_calle = dire_calle; }
        public void setDire_nro(string dire_nro) { this.dire_nro = dire_nro; }
        public void setFechaCreacion(DateTime fechaCreacion) { this.fechaCreacion = fechaCreacion; }
        public void setRecargaEstrellas(decimal recargaEstrellas) { this.recargaEstrellas = recargaEstrellas; }

        public void agregarRegimen(string regimen) { this.regimenes.Add(regimen); }

        public void limpiarRegimenes() { this.regimenes = new List<string>(); }

        public bool tieneReservasConRegimen(string regimen) {
            bool tieneReservas = false;
            if (this.codigo != 0) {
                string query = "SELECT DISTINCT 1 tieneReservas FROM FAAE.Reserva WHERE rese_hote_codigo = " + this.codigo;
                query += " AND rese_regi_codigo = '" + regimen + "' AND (rese_fecha_desde > GETDATE() OR rese_fecha_hasta > GETDATE())";
                SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);
                tieneReservas = dataReader.Read();
                dataReader.Close();
            }
            return tieneReservas;
        }

        public void buscar() {
            string query;
            SqlDataReader dataReader;

            if (this.codigo == 0) {
                dataReader = DBConnection.Instance.executeQuery("SELECT MAX(hote_codigo)+1 hote_codigo FROM FAAE.Hotel");
                dataReader.Read();
                this.codigo = Convert.ToInt32(dataReader["hote_codigo"]);
                dataReader.Close();
            }

            query = "SELECT hote_codigo, hote_nombre, hote_mail, hote_telefono, hote_dire_calle, hote_dire_nro, hote_cant_estrellas, hote_ciudad, hote_pais, hote_fecha_creacion, hote_recarga_estrellas FROM FAAE.Hotel WHERE hote_codigo =" + this.codigo;
            dataReader = DBConnection.Instance.executeQuery(query);
            if (dataReader.Read()) {
                    this.nombre = dataReader["hote_nombre"].ToString();
                    this.estrellas = Convert.ToInt16(dataReader["hote_cant_estrellas"].ToString());
                    this.ciudad = dataReader["hote_ciudad"].ToString();
                    this.pais = dataReader["hote_pais"].ToString();
                    this.mail = dataReader["hote_mail"].ToString();
                    this.telefono = dataReader["hote_telefono"].ToString();
                    this.dire_calle = dataReader["hote_dire_calle"].ToString();
                    this.dire_nro = dataReader["hote_dire_nro"].ToString();
                    this.fechaCreacion = Convert.ToDateTime(dataReader["hote_fecha_creacion"].ToString());
                    this.recargaEstrellas = Convert.ToDecimal(dataReader["hote_recarga_estrellas"].ToString());                
            }
            dataReader.Close();

            query = "SELECT reho_regi_codigo regi_nombre FROM FAAE.Regimen_Hotel WHERE reho_hote_codigo = " + this.codigo;
            dataReader = DBConnection.Instance.executeQuery(query);
            while (dataReader.Read())
                this.regimenes.Add(dataReader["regi_nombre"].ToString());

            dataReader.Close();
        }

        public void inhabilitarHotel(string motivo,DateTime fechaIncio,DateTime fechaFin) {
            string[] param = { "@hote_codigo", "@moti_descripcion", "@hiin_fecha_inicio", "@hiin_fecha_fin" };
            object[] args = { this.codigo, motivo, fechaIncio, fechaFin };
            DBConnection.Instance.executeProcedure("FAAE.inhabilitar_hotel", param, args);
        }

        // Si no existe el hotel lo crea, si existe lo actualiza
        public void guardar() {
            string sqlDate = this.fechaCreacion.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string[] param1 = { "@hote_codigo", "@hote_nombre", "@hote_mail", "@hote_telefono", "@hote_dire_calle", "@hote_dire_nro", "@hote_cant_estrellas", "@hote_ciudad", "@hote_pais", "@hote_fecha_creacion", "@hote_recarga_estrellas" };
            object[] args1 = { this.codigo, this.nombre, this.mail, this.telefono, this.dire_calle, this.dire_nro, this.estrellas, this.ciudad, this.pais, sqlDate, this.recargaEstrellas };
            DBConnection.Instance.executeProcedure("FAAE.guardar_hotel", param1, args1);

            if (this.codigo == 0) {
                SqlDataReader dataReader = DBConnection.Instance.executeQuery("SELECT MAX(hote_codigo) hote_codigo FROM FAAE.Hotel");
                dataReader.Read();
                this.codigo = Convert.ToInt32(dataReader["hote_codigo"]);
                dataReader.Close();
            }

            string[] param2 = { "@hote_codigo" };
            object[] args2 = { this.codigo };
            DBConnection.Instance.executeProcedure("FAAE.eliminar_regimenes_hotel", param2, args2);

            string[] param3 = { "@hote_codigo", "@regi_nombre" };
            this.regimenes.ForEach(regimen => {
                object[] args3 = { this.codigo, regimen };
                DBConnection.Instance.executeProcedure("FAAE.asignar_regimen_hotel", param3, args3);
            });
        }

    }
}
