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

namespace FrbaHotel.Login {
    public partial class frmLogin : Form  {

        public frmLogin() {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
       //     btnIngresar_Click.focus();
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            DBConnection.Instance.Connection.Close();
            Application.Exit(); 
        }

        private void btnIngresarHuesped_Click(object sender, EventArgs e) {
            DBConnection.Instance.conexionCorrecta();
            Login.frmFuncionalidadesCliente i = new Login.frmFuncionalidadesCliente();
            i.Show();
        }

        //Cuando el usuario tiene mas de un rol se abre un formulario para selccionar el rol
        private void btnIngresar_Click(object sender, EventArgs e) {
            if (!this.usuarioContrasenaVacios()) {

                if (DBConnection.Instance.conexionCorrecta()) {

                    Usuario usuarioActual = new Usuario(tbUsername.Text.ToString(), tbPassword.Text.ToString());
                    if ( this.verficarUsuario(usuarioActual) ) {

                        DBConnection.Instance.Usuario = usuarioActual;
                        Login.frmSeleccionRol sr = new frmSeleccionRol();
                        sr.Show();
                    }

                } else this.msgNoSePudoConectarConBD();

            } else this.msgUsuarioContrasenaIncorrectos();

        }

        private bool verficarUsuario(Usuario usuario) {

            usuario.ingresar();
            if(!usuario.Exists) {
                this.msgUsuarioContrasenaIncorrectos();
                return false;
            }
            else if (!usuario.Habilitado) {
                this.msgUsuarioInhabilitado();
                return false;
            }

            return true;
        }

        private bool usuarioContrasenaVacios() {
            return tbUsername.Text.ToString().Length == 0 || tbPassword.Text.ToString().Length == 0;
        }

        private void msgUsuarioContrasenaIncorrectos() {
            MessageBox.Show("Usuario o contraseña incorrectos", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
        }

        private void msgUsuarioInhabilitado() {
            MessageBox.Show("Usuario inhabilitado", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void msgNoSePudoConectarConBD() {
            MessageBox.Show("No se pudo conectar con la base de datos", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
