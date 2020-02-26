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

namespace FrbaHotel.AbmRol {
    public partial class frmABMRol : Form {
        
        public frmABMRol() {
            InitializeComponent();
            this.setLvProperties();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            this.lvRol.Items.Clear();
            string query = this.generateQuery();
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);

            while (dataReader.Read()) {
                ListViewItem listItem = this.nuevoItem(dataReader, new List<string>() { "rol_nombre", "rol_habilitado" });
                this.lvRol.Items.Add(listItem);
            }
            dataReader.Close();
        }

        private void frmInhabilitar_Click(object sender, EventArgs e) {
            if (this.lvRol.SelectedItems.Count == 1) {
                string nombreRol = this.lvRol.SelectedItems[0].Text.ToString();
                new Rol(nombreRol).inhabilitar();
            }
        }

        private void frmModificacion_Click(object sender, EventArgs e) {
            if (this.lvRol.SelectedItems.Count == 1) {
                string nombreRol = this.lvRol.SelectedItems[0].Text.ToString();
                Rol rolModificar = new Rol(nombreRol);
                rolModificar.buscar();
                frmAltaRol frmM = new frmAltaRol();
                frmM.setRol(rolModificar);
                frmM.setTitle("Modificar Rol");
                frmM.Show();
            }
        }

        private void frmAlta_Click(object sender, EventArgs e) {
            frmAltaRol frmA = new frmAltaRol();
            frmA.setTitle("Nuevo Rol");
            frmA.Show();
        }

        private string generateQuery() {

            string query = "SELECT rol_nombre, rol_habilitado FROM FAAE.Rol";
            string nombreRol = tbNombreRol.Text.ToString();

            if (this.seIngresaronDatos()) {
                List<string> conditions = new List<string>();

                if (nombreRol.Length != 0)
                    conditions.Add("rol_nombre LIKE '%" + nombreRol + "%'");

                query += " WHERE ";
                foreach (var condition in conditions)
                    query += condition + " AND ";
                query = query.Substring(0, query.Length - " AND ".Length);
            }
            return query;
        }

        private bool seIngresaronDatos() {
            return tbNombreRol.Text.ToString().Length != 0;
        }

        public void setLvProperties() {
            new List<string>() { "Nombre", "Habilitado" }
                .ForEach(columna => this.lvRol.Columns.Add(columna));
            this.lvRol.View = View.Details;
            this.lvRol.MultiSelect = false;
        }

        public ListViewItem nuevoItem(SqlDataReader dataReader, List<string> campos) {
            ListViewItem listItems = new ListViewItem(dataReader[campos[0]].ToString());
            campos.Skip(1).ToList().ForEach(subitem => listItems.SubItems.Add(dataReader[subitem].ToString()));
            return listItems;
        }

    }
}
