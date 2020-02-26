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

namespace FrbaHotel.AbmUsuario {
    public partial class frmAltaUsuario : Form {

        private Usuario usuario;
        List<string> codigosHoteles;

        public frmAltaUsuario() {  
            InitializeComponent();
            this.setDocTipoOptions();
            this.setLvProperties();
            this.cargarRolesDisponibles();
            this.cargarHotelesDisponibles();
        }

        public void setUsuario(Usuario usuario) {
            this.usuario = usuario;
            this.cargarUsuarioActual();
        }

        private void btnAgregarRol_Click(object sender, EventArgs e) {
            string rolAgregar = cbRoles.SelectedItem.ToString();
            if (rolAgregar.Length != 0)
                lvRoles.Items.Add(rolAgregar);
        }

        private void btnQuitar_Click(object sender, EventArgs e) {
            if (lvRoles.SelectedItems.Count == 1)
                lvRoles.SelectedItems[0].Remove();
        }

        private void btnAgregarHotel_Click(object sender, EventArgs e) {
            string hotelcodigo = codigosHoteles[cbHoteles.SelectedIndex];
            string hotelNombre = cbHoteles.SelectedItem.ToString();
            if (hotelNombre.Length != 0) {
                ListViewItem item = new ListViewItem(hotelcodigo);
                item.SubItems.Add(hotelNombre);
                lvHoteles.Items.Add(item);            
            }
        }

        private void btnQuitarHotel_Click(object sender, EventArgs e) {
            if (lvHoteles.SelectedItems.Count == 1)
                lvHoteles.SelectedItems[0].Remove();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (this.camposObligatoriosCompletos()) {
                Usuario usuario = this.getUsuario();
                if (!usuario.Exists && !usuario.tieneUsernameUnico())
                    this.msgUsernameRepetido();
                else {
                    usuario.DocTipo         = cbDocTipo.SelectedItem.ToString();
                    usuario.DocNro          = Convert.ToInt64(tbDocNro.Text);
                    usuario.Username        = tbUsername.Text;
                    if (tbPassword.Text.Length > 0)
                        usuario.Password    = tbPassword.Text;
                    usuario.Nombre          = tbNombre.Text;
                    usuario.Apellido        = tbApellido.Text;
                    usuario.Mail            = tbMail.Text;
                    usuario.Telefono        = tbTelefono.Text;
                    usuario.DireCalle       = tbDireCalle.Text;
                    usuario.DireNro         = Convert.ToInt64(tbDireNro.Text);
                    usuario.FechaNacimiento = dtpFechaNacimiento.Value;
                    usuario.Habilitado      = cbHabilitado.Checked;
                    usuario.limpiarRoles();
                    for (int i = 0; i < lvRoles.Items.Count; i++)
                        usuario.agregarRol(lvRoles.Items[i].Text.ToString());
                    usuario.limpiarHoteles();
                    for (int i = 0; i < lvHoteles.Items.Count; i++)
                        usuario.agregarHotel( new Hotel(Convert.ToInt32(lvHoteles.Items[i].Text), lvHoteles.Items[i].SubItems[0].Text) );
                    usuario.guardar();
                    this.Close();
                }
            }
            else
                this.msgCamposIncompletos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            new List<TextBox>() { tbNombre, tbApellido, tbDocNro, tbMail, tbTelefono, tbDireCalle, tbDireNro, tbUsername, tbPassword }.ForEach(control => control.Clear());
            lvRoles.Items.Clear();
            lvHoteles.Items.Clear();
        }

        private void cargarUsuarioActual() {
            cbDocTipo.Text          = usuario.DocTipo;
            tbDocNro.Text           = usuario.DocNro.ToString();
            tbUsername.Text         = usuario.Username;
            //tbPassword.Text         = usuario.getPassword();
            tbNombre.Text           = usuario.Nombre;
            tbApellido.Text         = usuario.Apellido;
            tbMail.Text             = usuario.Mail;
            tbTelefono.Text         = usuario.Telefono;
            tbDireCalle.Text        = usuario.DireCalle;
            tbDireNro.Text          = usuario.DireNro.ToString();
            dtpFechaNacimiento.Text = usuario.FechaNacimiento.ToShortDateString();
            cbHabilitado.Checked    = usuario.Habilitado;
            usuario.Roles.ForEach(rol => lvRoles.Items.Add(new ListViewItem(rol)));
            usuario.Hoteles.ForEach( hotel => {
                ListViewItem i = new ListViewItem(hotel.getCodigo().ToString());
                i.SubItems.Add(hotel.getNombre());
                lvHoteles.Items.Add(i);
            });
            cbDocTipo.Enabled = false;
            new List<TextBox> { tbDocNro, tbNombre, tbApellido, tbUsername, tbMail }.ForEach(form => form.ReadOnly = true);
            btnLimpiar.Enabled = false;
        }

        public void cargarRolesDisponibles() {
            this.lvRoles.Items.Clear();
            string query = "SELECT rol_nombre FROM FAAE.Rol WHERE rol_habilitado = 1";
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);

            while (dataReader.Read()) {
                ListViewItem listItem = this.nuevoItem(dataReader, new List<string>() { "rol_nombre" });
                this.cbRoles.Items.Add(listItem.Text.ToString());
            }
            dataReader.Close();
        }

        public void cargarHotelesDisponibles() {
            this.lvHoteles.Items.Clear();
            string query = "SELECT hote_codigo, hote_nombre FROM FAAE.Hotel";
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);
            codigosHoteles = new List<string>();
            
            while (dataReader.Read()) {
                codigosHoteles.Add(dataReader["hote_codigo"].ToString());
                ListViewItem listItem = this.nuevoItem(dataReader, new List<string>() { "hote_nombre" });
                this.cbHoteles.Items.Add(listItem.Text.ToString());
            }
            dataReader.Close();
        }

        public bool camposObligatoriosCompletos() {
            if (this.usuario == null) 
                // Si es un nuevo usuario pide password
                return new List<Control> { cbDocTipo, tbDocNro, tbNombre, tbApellido, tbUsername, tbPassword, tbDireCalle, tbDireNro }.All(form => form.Text.Length != 0);
            else
                return new List<Control> { cbDocTipo, tbDocNro, tbNombre, tbApellido, tbUsername, tbDireCalle, tbDireNro }.All(form => form.Text.Length != 0);
        }

        public void setLvProperties() {
            this.lvRoles.Columns.Add("Roles");
            this.lvRoles.View = View.Details;
            this.lvRoles.MultiSelect = false;

            this.lvHoteles.Columns.Add("Cod");
            this.lvHoteles.Columns.Add("Nombre");
            this.lvHoteles.View = View.Details;
            this.lvHoteles.MultiSelect = false;
        }

        public ListViewItem nuevoItem(SqlDataReader dataReader, List<string> campos) {
            ListViewItem listItems = new ListViewItem(dataReader[campos[0]].ToString());
            campos.Skip(1).ToList().ForEach(subitem => listItems.SubItems.Add(dataReader[subitem].ToString()));
            return listItems;
        }

        private void setDocTipoOptions() {
            new List<string>() { "Pasaporte", "DNI", "LE" }.ForEach(docTipo => cbDocTipo.Items.Add(docTipo));
            cbDocTipo.SelectedItem = "Pasaporte";
        }

        public void setTitle(string title) { this.label1.Text = title; }

        private Usuario getUsuario() {
            if (this.usuario == null)
                return new Usuario(tbUsername.Text.ToString());
            return this.usuario;
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbDireNro_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbDocNro_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void msgUsernameRepetido() {
            MessageBox.Show("Ya existe un usuario con el Username ingresado", "Username error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void msgCamposIncompletos() {
            MessageBox.Show("Campos obligatorios incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
