using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.AbmHotel {
    public partial class frmAbmHotel : Form {

        public frmAbmHotel() { 
            InitializeComponent();
            this.setLvProperties();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {

            this.lvHoteles.Items.Clear();
            string query = this.generateQuery();
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);

            while (dataReader.Read()) {
                ListViewItem listItem = this.nuevoItem(dataReader, new List<string>() { "hote_codigo", "hote_nombre", "hote_cant_estrellas", "hote_ciudad", "hote_pais" });
                this.lvHoteles.Items.Add(listItem);
            }
            dataReader.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            new List<TextBox>() { tbNombreHotel, tbCiudad, tbPais }.ForEach(tb => tb.Clear());
            cbCantidadEstrellas.Text = "";
        }


        private void frmAlta_Click(object sender, EventArgs e) {
            AbmHotel.frmAltaHotel frmA = new AbmHotel.frmAltaHotel();
            frmA.setTitle("Nuevo Hotel");
            frmA.Show();
        }

        private void frmBaja_Click(object sender, EventArgs e) {
            if (this.lvHoteles.SelectedItems.Count == 1) {
                int codigoHotel = Convert.ToInt32(this.lvHoteles.SelectedItems[0].Text.ToString());
                frmBajaHotel frmB = new frmBajaHotel(codigoHotel);
                frmB.Show();
                this.Close();
            }
        }

        private void frmModificacion_Click(object sender, EventArgs e) {
            if (this.lvHoteles.SelectedItems.Count == 1) {
                int codigoHotel = Convert.ToInt32(this.lvHoteles.SelectedItems[0].Text.ToString());
                Hotel hotelModificar = new Hotel(codigoHotel);
                hotelModificar.buscar();
                AbmHotel.frmAltaHotel frmM = new AbmHotel.frmAltaHotel();
                frmM.setHotel(hotelModificar);
                frmM.setTitle("Modificar Hotel");
                frmM.Show();
            }
        }

        private string generateQuery() {

            string query = "SELECT hote_codigo, hote_nombre, hote_cant_estrellas, hote_ciudad, hote_pais FROM FAAE.Hotel";
            string nombrehotel = tbNombreHotel.Text;
            string estrellas = cbCantidadEstrellas.Text;
            string ciudad = tbCiudad.Text;
            string pais = tbPais.Text;

            if (this.seIngresaronDatos()) {
                List<string> conditions = new List<string>();

                if (nombrehotel.Length != 0)
                    conditions.Add("hote_nombre LIKE '%" + nombrehotel + "%'");

                if (estrellas.Length != 0)
                    conditions.Add("hote_cant_estrellas = " + estrellas);

                if (ciudad.Length != 0)
                    conditions.Add("hote_ciudad LIKE '%" + ciudad + "%'");

                if (pais.Length != 0)
                    conditions.Add("hote_pais LIKE '%" + pais + "%'"); 

                query += " WHERE ";
                foreach (var condition in conditions)
                    query += condition + " AND ";
                query = query.Substring(0, query.Length - " AND ".Length); // Saca el ultimo AND
            }
            
            return query;
        }

        private bool seIngresaronDatos() {
            return new List<Control> { tbNombreHotel, cbCantidadEstrellas, tbCiudad, tbPais }.Any(form => form.Text.Length != 0);
        }

        public void setLvProperties() {
            new List<string>() { "Codigo", "Nombre", "Estrellas", "Ciudad", "Pais" }
                .ForEach(columna => this.lvHoteles.Columns.Add(columna));            
            this.lvHoteles.View = View.Details;
            this.lvHoteles.MultiSelect = false;
        }

        public ListViewItem nuevoItem(SqlDataReader dataReader, List<string> campos) {
            ListViewItem listItems = new ListViewItem(dataReader[campos[0]].ToString());
            campos.Skip(1).ToList().ForEach(subitem => listItems.SubItems.Add(dataReader[subitem].ToString()));
            return listItems;
        }

    }
}
