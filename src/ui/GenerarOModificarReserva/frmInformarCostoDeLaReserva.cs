using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarOModificarReserva
{
    public partial class frmInformarCostoDeLaReserva : Form
    {
        bool acepto = false;
        public frmInformarCostoDeLaReserva(int costo)
        {
            InitializeComponent();
            tbCostoHabitacion.Text = costo.ToString() + "$";
            tbCostoHabitacion.Enabled = false;
        }

        private void tbEleccion_TextChanged(object sender, EventArgs e)
        {        }

        private void btnAceptar_Click(object sender, EventArgs e)
        { 
            acepto = true;
            this.Close();
        }

        public bool aceptoCosto()
        { return acepto; }

        private void label2_Click(object sender, EventArgs e)
        {        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {   this.Close();   }

        private void label1_Click(object sender, EventArgs e)
        {        }
    }
}
