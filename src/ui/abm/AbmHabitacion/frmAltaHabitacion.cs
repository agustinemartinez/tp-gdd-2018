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
//using System.Data.SqlClient;

namespace FrbaHotel.AbmHabitacion {
    public partial class frmAltaHabitacion : Form {

        long nroHotel = DBConnection.Instance.Usuario.HotelUltimoLogin;

        public frmAltaHabitacion() {
            InitializeComponent();
            tbcodHotel.Text = nroHotel.ToString();
            tbcodHotel.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e) {
           if (this.camposObligatoriosCompletos()) {
               if (this.habitacionNoExiste()) {
                   int tipo = this.determinarTipo(cbTipoHab.Text.ToString());
                   Habitacion habitacion = new Habitacion(Convert.ToInt32(tbNumHab.Text), Convert.ToInt32(tbcodHotel.Text), Convert.ToInt32(tbPiso.Text), Convert.ToChar(cbUbicacion.Text), tipo, tbDescripcion.Text.ToString(), rbSi.Checked);
                   habitacion.guardar();
                   this.Close();
               }
               else
                    MessageBox.Show("Hay 2 habitaciones con el mismo numero en el mismo hotel", "Habitacion error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           else
               MessageBox.Show("Campos obligatorios incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool camposObligatoriosCompletos() {
            return new List<Control> { tbNumHab, tbcodHotel, tbPiso, cbUbicacion, tbDescripcion }.All(form => form.Text.Length != 0) && (rbSi.Checked || rbNo.Checked);
        }

        private bool habitacionNoExiste() {
            bool habitacionUnica;
            SqlDataReader dataReader = DBConnection.Instance.executeQuery("SELECT COUNT(*) existencias FROM FAAE.Habitacion WHERE habi_nro = " + this.tbNumHab.Text + " AND habi_hote_codigo = " + this.tbcodHotel.Text);
            dataReader.Read();
            habitacionUnica = (int)dataReader["existencias"] == 0;
            dataReader.Close();
            return habitacionUnica;
        }

        private int determinarTipo(string tipo) {
            int nroTipo;
            SqlDataReader dataReader = DBConnection.Instance.executeQuery("SELECT tipo_codigo FROM FAAE.Tipo WHERE tipo_descripcion LIKE '" + tipo + "'");
            dataReader.Read();
            nroTipo = Convert.ToInt32(dataReader["tipo_codigo"]);
            dataReader.Close();
            return nroTipo;
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            tbNumHab.Text = "";
            tbcodHotel.Text = "";
            tbPiso.Text = "";
            cbUbicacion.Text = "";
            cbTipoHab.Text = "";
            tbDescripcion.Text = "";
            rbNo.Checked = false;
            rbSi.Checked = false;
        }

    }
}
