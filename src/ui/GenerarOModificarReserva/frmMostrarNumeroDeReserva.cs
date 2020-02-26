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
    public partial class frmMostrarNumeroDeReserva : Form
    {
        public frmMostrarNumeroDeReserva(string numReserva)
        {
            InitializeComponent();
            tbNumeroDeReserva.Text = numReserva;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
