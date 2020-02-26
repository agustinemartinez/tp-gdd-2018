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
    public partial class frmRegistrarCliente : Form
    {
        public frmRegistrarCliente()
        {
            InitializeComponent();
            this.setDocTipoOptions();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.guardarCliente();
            this.Close();
        }

        public void guardarCliente()
        {
            Cliente unCliente = new Cliente(cbDocTipo.Text.ToString(), Convert.ToInt32(tbDocNro.Text), tbMail.Text.ToString()); //Cliente para la reserva
            DBConnection.Instance.Cliente = unCliente; //Cliente para la reserva
            string[] param = { "@clie_nombre", "@clie_apellido", "@clie_doc_tipo", 
                                 "@clie_doc_nro", "@clie_mail", "@clie_telefono", 
                                 "@clie_dire_calle",  "@clie_dire_nro", "@clie_dire_localidad"
                                 ,"@clie_dire_pais", "@clie_nacionalidad",  "@clie_fecha_nacimiento"};
            object[] args = { tbNombre.Text.ToString(), tbApellido.Text.ToString(), cbDocTipo.Text.ToString(),
                                Convert.ToInt32(tbDocNro.Text), tbMail.Text.ToString(), tbTelefono.Text.ToString(), 
                                tbDireCalle.Text.ToString(), Convert.ToInt32(tbDireNro.Text), tbCiudad.Text.ToString(), 
                                tbPais.Text.ToString(), tbNacionalidad.Text.ToString(), dtFechaNacimiento.Value};
            DBConnection.Instance.executeProcedure("FAAE.guardar_cliente", param, args);
        }

        private void setDocTipoOptions()
        {
            new List<string>() { "Pasaporte", "DNI", "LE" }.ForEach(docTipo => cbDocTipo.Items.Add(docTipo));
            cbDocTipo.SelectedItem = "Pasaporte";
        }
    }
}
