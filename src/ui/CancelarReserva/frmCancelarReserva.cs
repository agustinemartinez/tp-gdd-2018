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

namespace FrbaHotel.CancelarReserva {
    public partial class frmCancelarReserva : Form {

        public frmCancelarReserva() { InitializeComponent(); }

       string rolUsuario;

       public void canceladaPor(string rol) { rolUsuario = rol; }

        private void btnCancelarReserva_Click(object sender, EventArgs e) {
            if (DBConnection.Instance.conexionCorrecta()) {
                if (this.enFecha() && !this.reservaUtilizada() && this.datosBienIngresados()) {
                    DBConnection.Instance.executeQuery("UPDATE FAAE.Reserva set rese_estado = '" + rolUsuario + "' WHERE rese_codigo ="+ Convert.ToInt32(tbNroReserva.Text));
                    MessageBox.Show("Reserva cancelada correctamente");                        
                }
                else
                    MessageBox.Show("Error al cancelar la reserva","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                resetearTextboxs();
            }
        }

        private void resetearTextboxs() {
            tbMotivo.Clear(); tbNroReserva.Clear(); tbUsuarioCancelador.Clear();
        }

        private bool reservaUtilizada() {
            int reservaUtilizada = 0;
            SqlDataReader dataReader = DBConnection.Instance.executeQuery("SELECT COUNT(*) cant FROM FAAE.Estadia WHERE esta_rese_codigo = " + tbNroReserva.Text.ToString());
            dataReader.Read();
            reservaUtilizada = Convert.ToInt16(dataReader["cant"]);
            dataReader.Close();
            return reservaUtilizada != 0;
        }

        private bool datosBienIngresados() {
            return tbNroReserva.Text.ToString().Length > 0 && tbMotivo.Text.ToString().Length > 0 && tbUsuarioCancelador.Text.ToString().Length > 0;
        }

        private bool enFecha() {
            try {
                SqlDataReader dataReader = DBConnection.Instance.executeQuery("SELECT rese_fecha_desde FROM FAAE.Reserva WHERE rese_codigo = " + tbNroReserva.Text.ToString());
                dataReader.Read();
                DateTime fecha = Convert.ToDateTime(dataReader["rese_fecha_desde"].ToString());
                dataReader.Close();
                return Convert.ToDateTime(dtpFechaCancelacion.Text) < fecha;
            }
            catch (Exception) {
                MessageBox.Show("No existe esa reserva");
                return false;
            }
        }

    }
}
