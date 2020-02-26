using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmCliente
{
    public partial class frmModificarCliente : Form
    {
        Cliente cliente;
        public frmModificarCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;

        }
        int habilitado;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string tipoDoc = tbTipoDoc.Text.ToString();
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

            Cliente cliente = new Cliente(tipoDoc, nroDoc, nombre, apellido, mail, telefono, calle, numero, localidad, pais, nacionalidad, habilitado, fechaNac, piso, depto);
            cliente.modificar(this);
        }

        private void frmModificarCliente_Load(object sender, EventArgs e)
        {
            tbTipoDoc.Text = cliente.getTipoDoc();
            tbNroDoc.Text = cliente.getNroDoc().ToString();
            tbNombre.Text = cliente.getNombre();
            tbApellido.Text = cliente.getApellido();
            tbMail.Text = cliente.getMail();
            tbCalle.Text = cliente.getCalle();
            tbNumero.Text = cliente.getNumero().ToString();
            tbLocalidad.Text = cliente.getLocalidad();
            tbPais.Text = cliente.getPais();
            tbNacionalidad.Text = cliente.getNacionalidad();
            cbHabilitado.Checked = Convert.ToBoolean(cliente.getHabilitado());
            tbPiso.Text = cliente.getPiso().ToString();
            tbDepto.Text = cliente.getDepto().ToString();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            frmABMCliente abmCliente = new frmABMCliente();
            abmCliente.Show();
        }
    }
}
