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

namespace FrbaHotel.AbmHabitacion {
    public partial class frmBajaHabitacion : Form {

        long nroHotel = DBConnection.Instance.Usuario.HotelUltimoLogin;

        public frmBajaHabitacion() {
            InitializeComponent();
            tbcodHotel.Text = nroHotel.ToString();
            tbcodHotel.Enabled = false;
        }

        private void btSeleccionar_Click(object sender, EventArgs e) {
            string query = "SELECT * FROM FAAE.Habitacion WHERE habi_nro = " + tbNumHab.Text.ToString() + "AND habi_hote_codigo = " + tbcodHotel.Text.ToString();
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);

            if (dataReader.Read()) {
                frmAdvertenciaBaja ventanaBaja = new frmAdvertenciaBaja(tbNumHab.Text.ToString(), tbcodHotel.Text.ToString());
                ventanaBaja.Show();
                dataReader.Close();
            }
            else
                MessageBox.Show("No existe una habitacion con ese numero", "Habitacion error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            dataReader.Close();
        }

    }
}
