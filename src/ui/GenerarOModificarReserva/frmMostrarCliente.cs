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
    public partial class frmMostrarCliente : Form
    {
        public frmMostrarCliente(string hola)
        {
            InitializeComponent();
            tbCliente.Text = hola;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
