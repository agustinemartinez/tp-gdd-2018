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

namespace FrbaHotel.AbmHabitacion
{
    public partial class frmSeleccionarHabitacion : Form
    {
        long nroHotel = DBConnection.Instance.Usuario.HotelUltimoLogin;
        public frmSeleccionarHabitacion()
        {
            InitializeComponent();
            tbcodHotel.Text = nroHotel.ToString();
            tbcodHotel.Enabled = false;
        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM FAAE.Habitacion WHERE habi_nro = " + tbNumHab.Text.ToString() + "AND habi_hote_codigo = " + tbcodHotel.Text.ToString();
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);

            if (dataReader.Read())
            {
                frmModificarHabitacion ventanaModificar = new frmModificarHabitacion(tbNumHab.Text.ToString(), tbcodHotel.Text.ToString(), dataReader);
                ventanaModificar.Show();
                this.Close();
            }
            else
                MessageBox.Show("No existe una habitacion con ese numero", "Habitacion error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dataReader.Close();      
        }

        private void tbcodHotel_TextChanged(object sender, EventArgs e)
        {        }

        private void label5_Click(object sender, EventArgs e)
        {        }

        private void tbNumHab_TextChanged(object sender, EventArgs e)
        {        }

        private void label2_Click(object sender, EventArgs e)
        {        }

        private void frmModificarHabitacion_Load(object sender, EventArgs e)
        { }

        private void label3_Click(object sender, EventArgs e)
        { }
    }
}
