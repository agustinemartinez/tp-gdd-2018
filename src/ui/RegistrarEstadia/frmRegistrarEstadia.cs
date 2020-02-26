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

namespace FrbaHotel.RegistrarEstadia
{
    public partial class frmRegistrarEstadia : Form
    {
        string docTipo = DBConnection.Instance.Usuario.DocTipo.ToString();
        string docNro = DBConnection.Instance.Usuario.DocNro.ToString();
        string mail = DBConnection.Instance.Usuario.Mail.ToString();
        
        public frmRegistrarEstadia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DBConnection.Instance.conexionCorrecta())
            {
                if (textBox1.Text.ToString().Length > 0)
                {
                    DBConnection.Instance.executeQuery("UPDATE FAAE.Estadia set esta_fecha_salida = getdate(), esta_usuaOut_doc_tipo = '" + docTipo + "', esta_usuaOut_doc_nro = " + Convert.ToInt32(docNro) + ", esta_usuaOut_mail = '" + mail + "' WHERE esta_rese_codigo =" + Convert.ToInt32(textBox1.Text)).Close();
                    MessageBox.Show("Check-out realizado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al Realizar el Check-Out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DBConnection.Instance.conexionCorrecta())
            {
                if (textBox1.Text.ToString().Length > 0 && estadiaConEfecto())
                {
                    DBConnection.Instance.executeQuery(
                        "insert FAAE.Estadia(esta_clie_doc_tipo, esta_clie_doc_nro, esta_clie_mail, esta_habi_nro, esta_hote_codigo, esta_rese_codigo, esta_usuaIn_doc_tipo, esta_usuaIn_doc_nro, esta_usuaIn_mail) select top 1 rese_clie_doc_tipo, rese_clie_doc_nro, rese_clie_mail, reha_habi_nro, reha_hote_codigo, rese_codigo, '" + docTipo + "', " + Convert.ToInt32(docNro) + ", '" + mail + "' from FAAE.Reserva join FAAE.Reserva_Habitacion on reha_rese_codigo = rese_codigo where rese_codigo = " + textBox1.Text).Close();
                    MessageBox.Show("Check-in realizado correctamente");
                    if (espaciosEnLaReserva(textBox1.Text))
                    {
                        this.Close();
                        Form1 CheckInRestantes = new Form1(textBox1.Text);
                        CheckInRestantes.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Error al Realizar el Check-In", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool espaciosEnLaReserva(string reseCodigo)
        {
            try
            {
                Boolean quedanEspacios;
                SqlDataReader dataReader = DBConnection.Instance.executeQuery("select * from FAAE.Reserva_Habitacion join FAAE.Habitacion on habi_nro = reha_habi_nro and habi_hote_codigo = reha_hote_codigo join FAAE.Tipo on habi_tipo_codigo = tipo_codigo	where reha_rese_codigo = " + reseCodigo + " and tipo_cant_personas < (select count(*) from FAAE.Estadia where esta_habi_nro = reha_habi_nro and esta_hote_codigo = reha_hote_codigo and esta_rese_codigo =" + reseCodigo + ")");
                quedanEspacios = dataReader.Read();
                dataReader.Close();
                return quedanEspacios;
            }
            catch (Exception)
            {
                MessageBox.Show("Reserva sin efecto, realizar una nueva reserva"); return false;
            }
        }

        private bool estadiaConEfecto()
        {
            try
            {
                Boolean estadiaConEfecto;
                SqlDataReader dataReader = DBConnection.Instance.executeQuery("SELECT 1 FROM FAAE.Reserva WHERE getdate() >= rese_fecha_desde AND getdate() <= rese_fecha_hasta AND rese_codigo = " + textBox1.Text.ToString());
                estadiaConEfecto = dataReader.Read();
                dataReader.Close();
                return estadiaConEfecto;
            }
            catch (Exception) {
                MessageBox.Show("Reserva sin efecto, realizar una nueva"); return false;
            }
        }
    }
}
