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

namespace FrbaHotel.AbmCliente {
    public partial class frmABMCliente : Form {

        public frmABMCliente() { InitializeComponent(); }
        
        //DBConnection cn = new DBConnection();

        private void btnAtras_Click(object sender, EventArgs e) { Close(); }
        
        private void frmAlta_Click_1(object sender, EventArgs e) {
            frmAltaCliente i = new frmAltaCliente();
            i.Show();
            this.Close();
        }

        private void frmABMCliente_Load(object sender, EventArgs e) {
            string query = this.generarQuery();
            SqlConnection c = DBConnection.Instance.Connection;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FAAE.Cliente", c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvClientes.DataSource = dt;
        }

        private void frmBaja_Click(object sender, EventArgs e) {
            if (DBConnection.Instance.conexionCorrecta()) {
                try {
                    string eliminar = "UPDATE FAAE.Cliente SET clie_habilitado = 0 WHERE clie_mail like '" + this.obtenerMail() + "'";
                    SqlDataReader dataReader =  DBConnection.Instance.executeQuery(eliminar);
                    MessageBox.Show("Deshabilitado correctamente");
                    dataReader.Close();
                    this.Close();
                    frmABMCliente i = new frmABMCliente();
                    i.Show();
                }
                catch (Exception ex) { MessageBox.Show("ERROR: "+ex.ToString()); }
            }
        }
    

        private string generarQuery() {
            string query = "SELECT * FROM FAAE.Cliente WHERE clie_nombre like '%%' ";

            if (tbNombreCliente.Text.Length != 0)
                query += "and clie_nombre like '%" + tbNombreCliente.Text.ToString() + "%'";

            if (tbApellidoCliente.Text.Length != 0)
                query += "and clie_apellido like '%" + tbApellidoCliente.Text.ToString() + "%'";

            if (tbNroDocCliente.Text.Length != 0)
                query += "and clie_doc_nro like '%" + tbNroDocCliente.Text.ToString() + "%'";

            if (tbMailCliente.Text.Length != 0)
                query += "and clie_mail like '%" + tbMailCliente.Text.ToString() + "%'";

            if (cbTipoIdentificacion.Text.Length != 0)
                query += "and clie_doc_tipo like '%" + cbTipoIdentificacion.SelectedItem.ToString() + "%'";

            return query;
        }

        private string obtenerMail() {
            DataGridViewRow filaSeleccionada = dgvClientes.CurrentRow;
            return filaSeleccionada.Cells[4].Value.ToString();
        }

        private void frmModificarCliente_Click(object sender, EventArgs e) {
                Cliente clienteModificar = new Cliente();
                clienteModificar.setMail(this.obtenerMail());
                clienteModificar.buscar();
                frmModificarCliente i = new frmModificarCliente(clienteModificar);
                i.Show();
                this.Close();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e) {
            string query = this.generarQuery();
            SqlConnection c = DBConnection.Instance.Connection;
            SqlDataAdapter da = new SqlDataAdapter(query, c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvClientes.DataSource = dt;
        }

    }
}
