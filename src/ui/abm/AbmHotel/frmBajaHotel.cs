using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class frmBajaHotel : Form
    {
        private int codigoHotel;

        public frmBajaHotel()
        {
            InitializeComponent();
        }

        public frmBajaHotel(int codigoHotel)
        {
            this.codigoHotel = codigoHotel;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (datosCompletados())
            {
                try
                {
                    new Hotel(codigoHotel).inhabilitarHotel(tbMotivo.Text.ToString(), Convert.ToDateTime(dpFechaInicio.Text.ToString()), Convert.ToDateTime(dpFechaFin.Text.ToString()));//Convert.ToDateTime(tbFechaInicio.Text), Convert.ToDateTime(tbFechaFin.Text));
                    MessageBox.Show("Hotel inhabilitado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al inhabilitar hotel: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Falta completar algun campo.");
            }

        }

        private bool datosCompletados()
        {
            return tbMotivo.Text.Length != 0 && dpFechaFin.Text.ToString().Length != 0 && dpFechaInicio.Text.ToString().Length != 0;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
