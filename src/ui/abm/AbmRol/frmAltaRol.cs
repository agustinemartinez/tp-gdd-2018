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
    public partial class frmAltaRol : Form {

        private Rol rol;

        public frmAltaRol() {
            InitializeComponent();
            this.setLvProperties();
            this.cargarFuncionalidadesDisponibles();
        }

        public void setRol(Rol rol) {
            this.rol = rol;
            this.cargarRolActual();
        }

        public void cargarRolActual() { 
            tbNombreRol.Text = rol.getNombre();
            rol.getFuncionalidades().ForEach(funcionalidad => lvFuncionalidades.Items.Add(new ListViewItem(funcionalidad)));
            cbHabilitado.Checked = rol.getHabilitado();
            tbNombreRol.ReadOnly = true;
        }

        private void btnAgregarFuncionalidad_Click(object sender, EventArgs e) {
            string funcionalidadAgregar = cbFuncionalidades.SelectedItem.ToString();
            if (funcionalidadAgregar.Length != 0)
                lvFuncionalidades.Items.Add(funcionalidadAgregar);
        }

        private void btnQuitarFuncionalidad_Click(object sender, EventArgs e) {
            if (lvFuncionalidades.SelectedItems.Count == 1)
                lvFuncionalidades.SelectedItems[0].Remove();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (this.camposObligatoriosCompletos()) {
                Rol rol = this.getRol();
                rol.setHabilitado( cbHabilitado.Checked );
                rol.limpiarFuncionalidades();
                for (int i = 0; i < lvFuncionalidades.Items.Count; i++)
                    rol.agregarFuncionalidad(lvFuncionalidades.Items[i].Text.ToString());
                rol.guardar();
            }
            Close();
        }

        private bool camposObligatoriosCompletos() {
            return tbNombreRol.Text.Length != 0 && lvFuncionalidades.Items.Count != 0;
        }

        public void cargarFuncionalidadesDisponibles() {
            this.lvFuncionalidades.Items.Clear();
            string query = "SELECT DISTINCT func_funcion FROM FAAE.Funcionalidad";
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);

            while (dataReader.Read()) {
                ListViewItem listItem = this.nuevoItem(dataReader, new List<string>() { "func_funcion" });
                this.cbFuncionalidades.Items.Add(listItem.Text.ToString());
            }
            dataReader.Close();
        }

        public void setLvProperties() {
            new List<string>() { "Funcionalidad" }
                .ForEach(columna => this.lvFuncionalidades.Columns.Add(columna));
            this.lvFuncionalidades.View = View.Details;
            this.lvFuncionalidades.MultiSelect = false;
        }

        public void setTitle(string title) {
            this.label1.Text = title;
        }

        private Rol getRol() {
            if (this.rol == null)
                return new Rol(tbNombreRol.Text.ToString());
            return this.rol;
        }

        public ListViewItem nuevoItem(SqlDataReader dataReader, List<string> campos) {
            ListViewItem listItems = new ListViewItem(dataReader[campos[0]].ToString());
            campos.Skip(1).ToList().ForEach(subitem => listItems.SubItems.Add(dataReader[subitem].ToString()));
            return listItems;
        }

    }
}
