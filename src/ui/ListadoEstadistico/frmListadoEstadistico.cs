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

namespace FrbaHotel.ListadoEstadistico {
    public partial class frmListadoEstadistico : Form {

        public frmListadoEstadistico() {
            InitializeComponent();
            this.setCbProperties();
        }

        private void btnListar_Click(object sender, EventArgs e) {
            if (this.camposObligatoriosCompletos()) {
                string consulta = cbConsulta.Text.ToString();
                string anio = cbAnio.Text.ToString();
                string trimestre = this.obtenerTrimestre();
                this.listarSegun(consulta, anio, trimestre);
            }
        }

        private void listarSegun(string consulta, string anio, string trimestre) {

            List<string> columnasTabla;
            this.lvListadoEstadistico.Clear();

            switch (consulta) {

                case "Hoteles con mayor cantidad de reservas canceladas":
                    this.setLvPropertiesHotelReservasCanceladas();
                    columnasTabla = new List<string> { "hote_nombre", "hote_cant_estrellas", "hote_dire_calle", "hote_dire_nro", "hote_ciudad", "hote_pais", "reservasCanceladas" };
                    this.cargarListadoTop5("FAAE.HotelesConMasReservasCanceladas", columnasTabla, anio, trimestre);
                    break;

                case "Hoteles con mayor cantidad de consumibles facturados":
                    this.setLvPropertiesHotelConsumiblesFacturados();
                    columnasTabla = new List<string> { "hote_nombre", "hote_cant_estrellas", "hote_dire_calle", "hote_dire_nro", "hote_ciudad", "hote_pais", "cons_descipcion", "cantConsumiblesFacturados" };
                    this.cargarListadoTop5("FAAE.HotelesConMasConsumiblesFacturados", columnasTabla, anio, trimestre);
                    break;

                case "Hoteles con mayor cantidad de días fuera de servicio":
                    this.setLvPropertiesHotelDiasFueraDeServicio();
                    columnasTabla = new List<string> { "hote_nombre", "hote_cant_estrellas", "hote_dire_calle", "hote_dire_nro", "hote_ciudad", "hote_pais", "diasFueraDeServicio" };
                    this.cargarListadoTop5("FAAE.HotelesConMasDiasFueraDeServicio", columnasTabla, anio, trimestre);
                    break;

                case "Habitaciones con mayor cantidad de días y veces que fueron ocupadas":
                    this.setLvPropertiesHabitacion();
                    columnasTabla = new List<string> { "hote_nombre", "habi_nro", "tipo_descripcion", "vecesOcupada", "cantDiasOcupada" };
                    this.cargarListadoTop5("FAAE.HabitacionesConMasDiasYVecesOcupada", columnasTabla, anio, trimestre);
                    break;

                case "Clientes con mayor cantidad de puntos":
                    this.setLvPropertiesCliente();
                    columnasTabla = new List<string> { "clie_nombre", "clie_apellido", "clie_puntos" };
                    this.cargarListadoTop5("FAAE.ClientesConMasPuntos", columnasTabla, anio, trimestre);
                    break;
            }
        }

        // Todas las vistas/tablas/funciones deben tener un campo criterioOrdenar
        private void cargarListadoTop5(string nombreTabla, List<string> columnas, string anio, string trimestre) {
            this.lvListadoEstadistico.Items.Clear();
            string tabla = nombreTabla + "(" + this.fechasEntreTrimestre(anio, trimestre) + ")";
            string query = "SELECT TOP 5 " + string.Join(", ", columnas) + " FROM " + tabla  + " ORDER BY criterioOrdenar DESC";
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);

            while (dataReader.Read()) {
                ListViewItem listItem = this.nuevoItem(dataReader, columnas);
                this.lvListadoEstadistico.Items.Add(listItem);
            }
            dataReader.Close();
        }

        private void setLvPropertiesHotelReservasCanceladas() {
            new List<string>() { "Hotel", "Estrellas", "Direccion_Calle", "Direccion_Nro", "Ciudad", "Pais", "Reservas canceladas" }
                .ForEach(columna => this.lvListadoEstadistico.Columns.Add(columna));
            this.lvListadoEstadistico.View = View.Details;
            this.lvListadoEstadistico.MultiSelect = false;
        }

        private void setLvPropertiesHotelConsumiblesFacturados() {
            new List<string>() { "Hotel", "Estrellas", "Direccion_Calle", "Direccion_Nro", "Ciudad", "Pais", "Consumible", "Cantidad" }
                .ForEach(columna => this.lvListadoEstadistico.Columns.Add(columna));
            this.lvListadoEstadistico.View = View.Details;
            this.lvListadoEstadistico.MultiSelect = false;
        }

        private void setLvPropertiesHotelDiasFueraDeServicio() {
            new List<string>() { "Hotel", "Estrellas", "Direccion_Calle", "Direccion_Nro", "Ciudad", "Pais", "Dias fuera de servicio" }
                .ForEach(columna => this.lvListadoEstadistico.Columns.Add(columna));
            this.lvListadoEstadistico.View = View.Details;
            this.lvListadoEstadistico.MultiSelect = false;
        }

        private void setLvPropertiesHabitacion() {
            new List<string>() { "Hotel", "Habitacion", "Tipo", "Veces Ocupada", "Dias Ocupada" }
                .ForEach(columna => this.lvListadoEstadistico.Columns.Add(columna));
            this.lvListadoEstadistico.View = View.Details;
            this.lvListadoEstadistico.MultiSelect = false;
        }

        private void setLvPropertiesCliente() {
            new List<string>() { "Nombre", "Apellido", "Puntos" }
                .ForEach(columna => this.lvListadoEstadistico.Columns.Add(columna));
            this.lvListadoEstadistico.View = View.Details;
            this.lvListadoEstadistico.MultiSelect = false;
        }

        public void setCbProperties() {
            this.cbConsulta.Items.Add("Hoteles con mayor cantidad de reservas canceladas");
            this.cbConsulta.Items.Add("Hoteles con mayor cantidad de consumibles facturados");
            this.cbConsulta.Items.Add("Hoteles con mayor cantidad de días fuera de servicio");
            this.cbConsulta.Items.Add("Habitaciones con mayor cantidad de días y veces que fueron ocupadas");
            this.cbConsulta.Items.Add("Clientes con mayor cantidad de puntos");
            this.cbTrimestre.Items.Add("ENE-MAR");
            this.cbTrimestre.Items.Add("ABR-JUN");
            this.cbTrimestre.Items.Add("JUL-SEP");
            this.cbTrimestre.Items.Add("OCT-DIC");
            Enumerable.Range(2000, DateTime.Now.Year - 1999).ToList().ForEach(anio => this.cbAnio.Items.Add(anio));
        }

        private bool camposObligatoriosCompletos() {
            return new List<Control> { cbAnio, cbConsulta, cbTrimestre }.All(form => form.Text.Length != 0);
        }

        private string obtenerTrimestre() {
            switch (cbTrimestre.Text.ToString()) {
                case "ENE-MAR":
                    return "0103";
                case "ABR-JUN":
                    return "0406";
                case "JUL-SEP":
                    return "0709";
                case "OCT-DIC":
                    return "1012";
                default:
                    return "0";
            }
        }

        private ListViewItem nuevoItem(SqlDataReader dataReader, List<string> campos) {
            ListViewItem listItems = new ListViewItem(dataReader[campos[0]].ToString());
            campos.Skip(1).ToList().ForEach(subitem => listItems.SubItems.Add(dataReader[subitem].ToString()));
            return listItems;
        }

        private string fechasEntreTrimestre(string anio, string trimestre) {
            string mesDesde = trimestre.Substring(0, 2);
            string mesHasta = trimestre.Substring(2, 2);
            return this.construirfechaSql("01", mesDesde, anio.ToString()) + ", " + this.construirfechaSql("01", mesHasta, anio.ToString());
        }

        private string construirfechaSql(string dia, string mes, string anio) {
            return "'" + anio + "-" + mes + "-" + dia + "'"; // Formato YYYY-MM-DD
        }

    }
}
