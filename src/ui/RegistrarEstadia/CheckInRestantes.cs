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

namespace FrbaHotel.RegistrarEstadia {
    public partial class CheckInRestantes : Form {

        SqlDataReader dataReader;
        string docTipo = DBConnection.Instance.Usuario.DocTipo.ToString();
        string docNro = DBConnection.Instance.Usuario.DocNro.ToString();
        string mail = DBConnection.Instance.Usuario.Mail.ToString();
        string codigoReserva;
        string codigoCliente;

        public CheckInRestantes(string codigoReserva2, string codigoCliente2) {
            InitializeComponent();
            codigoReserva = codigoReserva2;
            codigoCliente = codigoCliente2;
            textBox1.Text = buscarPorMail();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (DBConnection.Instance.conexionCorrecta()) {
                if (espaciosEnLaReserva(codigoReserva)) {
                    CheckIn checkIn = new CheckIn(codigoReserva, buscarClienteDocTipo(), Convert.ToInt32(buscarClienteDocNro()), codigoCliente, docTipo, Convert.ToInt32(docNro), mail);
                    checkIn.guardar();
                    MessageBox.Show("Check-in realizado correctamente");
                    this.Close();
                    if (espaciosEnLaReserva(codigoReserva)) {
                        Form1 CheckInRestantes = new Form1(codigoReserva);
                        CheckInRestantes.Show();
                    }
                }
                else
                    MessageBox.Show("Error al Realizar el Check-In", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool espaciosEnLaReserva(string reseCodigo) {
            try {
                Boolean quedanEspacios;
                SqlDataReader dataReader = DBConnection.Instance.executeQuery("select * from FAAE.Reserva_Habitacion join FAAE.Habitacion on habi_nro = reha_habi_nro and habi_hote_codigo = reha_hote_codigo join FAAE.Tipo on habi_tipo_codigo = tipo_codigo	where " + reseCodigo + " = reha_rese_codigo and tipo_cant_personas < (select count(*) from FAAE.Estadia where esta_habi_nro = reha_habi_nro and esta_hote_codigo = reha_hote_codigo and esta_rese_codigo = @reseCodigo)");
                quedanEspacios = dataReader.Read();
                dataReader.Close();
                return quedanEspacios;
            }
            catch (Exception) {
                MessageBox.Show("Reserva sin efecto, realizar una nueva reserva"); return false;
            }
        }

        private string buscarPorMail() {
            string query = "SELECT clie_nombre, clie_apellido FROM FAAE.Cliente WHERE clie_mail LIKE '" + codigoCliente + "'";
            dataReader = DBConnection.Instance.executeQuery(query);
            dataReader.Read();
            string nombre = dataReader["clie_nombre"].ToString();
            string apellido = dataReader["clie_apellido"].ToString();
            dataReader.Close();
            return nombre + " " + apellido;
        }

        private string buscarClienteDocTipo() {
            string query = "SELECT clie_doc_tipo FROM FAAE.Cliente WHERE clie_mail LIKE '" + codigoCliente + "'";
            dataReader = DBConnection.Instance.executeQuery(query);
            dataReader.Read();
            string docTipo = dataReader["clie_doc_tipo"].ToString();
            dataReader.Close();
            return docTipo;
        }

        private string buscarClienteDocNro() {
            string query = "SELECT clie_doc_nro FROM FAAE.Cliente WHERE clie_mail LIKE '" + codigoCliente + "'";
            dataReader = DBConnection.Instance.executeQuery(query);
            dataReader.Read();
            string docTipo = dataReader["clie_doc_tipo"].ToString();
            dataReader.Close();
            return docTipo;
        }

    }
}
