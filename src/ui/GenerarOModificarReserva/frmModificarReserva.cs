using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarOModificarReserva
{
    public partial class frmModificarReserva : Form
    {
        string numeroReserva;
        SqlDataReader dataReader;
        int nroHotel;
        string nombreHotel;
        int cantHab;

        public frmModificarReserva(string numeroReserva)
        {
            InitializeComponent();
            this.numeroReserva = numeroReserva;
            this.mostrarReserva();
            tbNombreHotel.Enabled = false;
            tbNumeroDeReserva.Enabled = false;
            this.cambiarNumeroHotelPorNombreHotel();
        }

        private void mostrarReserva()
        {
            tbNumeroDeReserva.Text = numeroReserva;
            string query = "SELECT * FROM FAAE.Reserva WHERE rese_codigo = " + this.numeroReserva;
            dataReader = DBConnection.Instance.executeQuery(query);
            dataReader.Read();//no es necesario controlar, lo hace la anterior ventana

                nroHotel = Convert.ToInt32(dataReader["rese_hote_codigo"].ToString());
                dtFechaInicioReserva.Value = Convert.ToDateTime(dataReader["rese_fecha_desde"]);
                dtFechaFinalReserva.Value = Convert.ToDateTime(dataReader["rese_fecha_hasta"]);
                cbTipoRegimen.Text = dataReader["rese_regi_codigo"].ToString();
                dataReader.Close();//no es necesario controlar
                //JOIN para saber de que tipo es la reserva 
                query = "SELECT DISTINCT tipo_descripcion FROM FAAE.Reserva_Habitacion JOIN FAAE.Habitacion ON (reha_habi_nro = habi_nro AND reha_hote_codigo = habi_hote_codigo)  JOIN FAAE.Tipo ON (tipo_codigo = habi_tipo_codigo) WHERE reha_rese_codigo = " + this.numeroReserva;
                dataReader = DBConnection.Instance.executeQuery(query);
                dataReader.Read();
                cbTipoHab.Text = dataReader["tipo_descripcion"].ToString();
                dataReader.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string[] param = { "@rese_codigo", "@rese_fecha_desde", "@rese_fecha_hasta", "@rese_regi_codigo" };
            object[] args = { this.numeroReserva, dtFechaInicioReserva.Value, dtFechaFinalReserva.Value, cbTipoRegimen.Text.ToString()};
            DBConnection.Instance.executeProcedure("FAAE.modificar_reserva", param, args);
            
            this.generarNuevasReservas();

            
            this.Close();
        }

        private void generarNuevasReservas()
        {
            if (this.determinarDisponibilidadDelPedido())
            {
                MessageBox.Show("Hay disponibilidad para realizar modificacion");
                this.borrarHabitacionesDeAnteriorReserva();

                for (int i = 0; i < cantHab; i++) //genera las reservasPorHabitacion
                {
                    this.guardarReservaPorHabitacion();
                }
                MessageBox.Show("Se modifico satisfactoriamente");
            }
            else
            {
                this.Close();
                MessageBox.Show("No hay disponibilidad de habitaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);             
            }
        }

        private bool determinarDisponibilidadDelPedido()
        {
            this.calcularCantidadHabitaciones();
            string query = "SELECT COUNT(habi_nro) AS cantDisponibles FROM FAAE.Habitacion JOIN FAAE.Hotel ON (habi_hote_codigo = hote_codigo) JOIN FAAE.Regimen_Hotel ON (hote_codigo = reho_hote_codigo) WHERE habi_tipo_codigo = (SELECT tipo_codigo FROM FAAE.Tipo WHERE tipo_descripcion LIKE '" + cbTipoHab.Text.ToString() + "') AND habi_habilitada = 1 AND reho_regi_codigo LIKE '" + cbTipoRegimen.Text.ToString() + "' AND hote_codigo = " + nroHotel.ToString() + " AND NOT exists (SELECT NULL FROM FAAE.Reserva_Habitacion WHERE reha_hote_codigo = hote_codigo  AND habi_nro = reha_habi_nro)";
            dataReader = DBConnection.Instance.executeQuery(query);
            if (dataReader.Read())
            {
                bool hayDisponibilidad = Convert.ToInt32(dataReader["cantDisponibles"].ToString()) >= Convert.ToInt32(this.cantHab);
                dataReader.Close();
                return hayDisponibilidad;
            }
            else
                dataReader.Close();
            return false;
        }

        private void calcularCantidadHabitaciones()
        {
            string query = "SELECT COUNT(reha_habi_nro) cantDeHabitaciones FROM FAAE.Reserva_Habitacion WHERE reha_rese_codigo = " + numeroReserva;
            dataReader = DBConnection.Instance.executeQuery(query);
            dataReader.Read();
            cantHab = Convert.ToInt32(dataReader["cantDeHabitaciones"]);
            dataReader.Close();
            
        }

        private void cambiarNumeroHotelPorNombreHotel() //cuando se hardcodee el numero de hotel en donde esta el recepcionista que genera la reserva
        {
            string query = "SELECT hote_nombre FROM FAAE.Hotel WHERE hote_codigo  = " + nroHotel.ToString() ;
            dataReader = DBConnection.Instance.executeQuery(query);
            dataReader.Read();
            tbNombreHotel.Text = dataReader["hote_nombre"].ToString();
            nombreHotel = tbNombreHotel.Text.ToString();
            dataReader.Close();
        }

        public void guardarReservaPorHabitacion()
        {
            string[] param = { "@reha_rese_codigo", "@rese_hote_codigo", "@reha_precio", "@habi_tipo_codigo" };
            object[] args = { Convert.ToInt32(numeroReserva), this.nroHotel, this.calcularCostoDeHabitacion(), this.determinarTipo(cbTipoHab.Text.ToString() ) };
            DBConnection.Instance.executeProcedure("FAAE.guardar_reservaPorHabitacion", param, args);
        }

        private int calcularCostoDeHabitacion()
        {
            dataReader.Close();
            string query = "SELECT regi_precio_base FROM FAAE.Regimen WHERE regi_nombre LIKE '" + cbTipoRegimen.Text.ToString() + "'";
            dataReader = DBConnection.Instance.executeQuery(query);
            dataReader.Read();
            int precioRegimen = (int)Convert.ToDecimal(dataReader["regi_precio_base"].ToString());
            dataReader.Close();

            query = "SELECT tipo_cant_personas FROM FAAE.Tipo WHERE tipo_descripcion LIKE '" + cbTipoHab.Text.ToString() + "'";
            dataReader = DBConnection.Instance.executeQuery(query);
            dataReader.Read();
            int precioTipo = Convert.ToInt32(dataReader["tipo_cant_personas"].ToString());
            dataReader.Close();

            query = "SELECT hote_recarga_estrellas FROM FAAE.Hotel WHERE hote_nombre LIKE '" + tbNombreHotel.Text.ToString() + "'";
            dataReader = DBConnection.Instance.executeQuery(query);
            dataReader.Read();
            int precioHotel = (int)(Convert.ToDecimal(dataReader["hote_recarga_estrellas"].ToString()));
            dataReader.Close();
            int precioPorHabitacion = precioRegimen * precioTipo * precioHotel;
            return precioPorHabitacion;
        }

        private int determinarTipo(string tipo)
        {
            int nroTipo;
            SqlDataReader dataReader = DBConnection.Instance.executeQuery("SELECT tipo_codigo FROM FAAE.Tipo WHERE tipo_descripcion LIKE '" + tipo + "'");
            dataReader.Read();
            nroTipo = Convert.ToInt32(dataReader["tipo_codigo"]);
            dataReader.Close();
            return nroTipo;
        }

        private void borrarHabitacionesDeAnteriorReserva()
        {
            string[] param2 = { "@rese_codigo" };
            object[] args2 = { this.numeroReserva };
            DBConnection.Instance.executeProcedure("FAAE.borrar_habitacionesDeReservaAntigua", param2, args2);
        }
    }
}
