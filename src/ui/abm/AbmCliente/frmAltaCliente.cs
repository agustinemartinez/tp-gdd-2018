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


namespace FrbaHotel.AbmCliente
{
    public partial class frmAltaCliente : Form
    {
        public frmAltaCliente()
        {
            InitializeComponent();
            this.setDocTipoOptions();
        }

        private int habilitado;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string tipoDoc = cbTipoDoc.Text.ToString();
            int nroDoc = Convert.ToInt32(tbNroDoc.Text);
            string nombre = tbNombre.Text.ToString();
            string apellido = tbApellido.Text.ToString();
            string mail = tbMail.Text.ToString();
            string telefono = tbTelefono.Text.ToString();
            string calle = tbCalle.Text.ToString();
            int numero = Convert.ToInt32(tbNumero.Text);
            string localidad = tbLocalidad.Text.ToString();
            string pais = tbPais.Text.ToString();
            string nacionalidad = tbNacionalidad.Text.ToString();
            if (cbHabilitado.Checked) { habilitado = 1; } else { habilitado = 0; }
            DateTime fechaNac = Convert.ToDateTime(dtFechaNac.Text.ToString());
            int piso = Convert.ToInt32(tbPiso.Text);
            string depto = tbDepto.Text.ToString();

            Cliente cliente = new Cliente(tipoDoc, nroDoc, nombre, apellido, mail, telefono, calle, numero, localidad, pais, nacionalidad,habilitado, fechaNac, piso, depto);
            cliente.registrar(this);
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            frmABMCliente abmCliente = new frmABMCliente();
            abmCliente.Show();
        }

        private void setDocTipoOptions()
        {
            new List<string>() { "Pasaporte", "DNI", "LE" }.ForEach(docTipo => cbTipoDoc.Items.Add(docTipo));
            cbTipoDoc.SelectedItem = "Pasaporte";
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tbNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tbPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
      
    }
}
