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
    public partial class frmSeleccionarReserva : Form
    {
        SqlDataReader dataReader;
        DateTime fechaDeHoy = DateTime.Now;
        DateTime fechaInicioReserva;
        public frmSeleccionarReserva()
        {
            InitializeComponent();
        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
            this.existeReservaYNoQuiereModificarUndiaAntes();
        }

        private void existeReservaYNoQuiereModificarUndiaAntes()
        {
            string query = "SELECT rese_codigo, rese_fecha_desde FROM FAAE.Reserva WHERE rese_codigo = " + tbNumReserva.Text.ToString();
            dataReader = DBConnection.Instance.executeQuery(query);
            if (dataReader.Read())
            {
                fechaInicioReserva = Convert.ToDateTime(dataReader["rese_fecha_desde"]);
                if (this.quiereModificarUnDiaAntes())
                {
                    MessageBox.Show("No se puede modificar la reserva un dia antes que comience", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    dataReader.Close();
                    frmModificarReserva ventanaModificar = new frmModificarReserva(tbNumReserva.Text.ToString());
                    ventanaModificar.Show();
                }
            }
            else
            {
                dataReader.Close();
                MessageBox.Show("No existe esa reserva", "Error codigo reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool quiereModificarUnDiaAntes()
        {
            TimeSpan diferencia = fechaDeHoy - fechaInicioReserva;
            TimeSpan baseInterval = new TimeSpan(24, 0, 0);
            return baseInterval > diferencia;
        }


    }
}
