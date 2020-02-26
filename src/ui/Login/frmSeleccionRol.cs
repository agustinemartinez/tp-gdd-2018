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
    public partial class frmSeleccionRol : Form {

        List<long> codigosHotelesDisponibles;

        public frmSeleccionRol() { 
            InitializeComponent();
            this.agregarRolesDisponibles();
            this.agregarHotelesDisponibles();
        }

        private void agregarRolesDisponibles() {
            SqlDataReader dataReader = DBConnection.Instance
                                                   .executeQuery("SELECT rol_nombre FROM FAAE.RolXUsuario WHERE username ='" + DBConnection.Instance.Usuario.Username + "'");
            while( dataReader.Read() ) 
                this.cbListaRoles.Items.Add( dataReader["rol_nombre"].ToString() );
            dataReader.Close();
            if (cbListaRoles.Items.Count > 0)
                cbListaRoles.SelectedItem = cbListaRoles.Items[0];
        }

        private void agregarHotelesDisponibles() {
            SqlDataReader dataReader = DBConnection.Instance
                                                   .executeQuery("SELECT hote_codigo, hote_nombre FROM FAAE.Codigo_Hoteles_Usuario('" + DBConnection.Instance.Usuario.Username + "')");
            this.codigosHotelesDisponibles = new List<long>();
            while (dataReader.Read()) {
                this.codigosHotelesDisponibles.Add(Convert.ToInt64(dataReader["hote_codigo"]));
                this.cbHotelesDisponibles.Items.Add(dataReader["hote_nombre"].ToString());
            }
            dataReader.Close();
            if (cbHotelesDisponibles.Items.Count > 0)
                cbHotelesDisponibles.SelectedItem = cbHotelesDisponibles.Items[0];
        }

        private void continuar_Click(object sender, EventArgs e) {
            long codigoHotelSeleccionado = this.codigosHotelesDisponibles[this.cbHotelesDisponibles.SelectedIndex];
            String rol = this.cbListaRoles.Text.ToString();
            switch (rol) {
                case "admin":
                    DBConnection.Instance.Usuario.HotelUltimoLogin = codigoHotelSeleccionado;
                    new Login.frmFuncionalidadesAdministrador().Show();
                    Close();
                    break;
                case "recepcion":
                    DBConnection.Instance.Usuario.HotelUltimoLogin = codigoHotelSeleccionado;
                    new Login.frmFuncionalidadesRecepcionista().Show();
                    Close();
                    break;
                case "cliente":
                    new Login.frmFuncionalidadesCliente().Show();
                    Close();
                    break;
            }
        }

    }
}
