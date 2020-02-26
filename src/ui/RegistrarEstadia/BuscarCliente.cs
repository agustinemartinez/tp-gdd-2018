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
    public partial class Form1 : Form
    {
        SqlDataReader dataReader;
        string codigoReserva;
        public Form1(string codigoReserva2)
        {
            InitializeComponent();
            this.setDocTipoOptions();
            codigoReserva = codigoReserva2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.camposIncompletos())
            {
                MessageBox.Show("Complete alguna de las 2 opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.camposCompletos())
            {
                MessageBox.Show("Complete solo UNA de las 2 opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox2.Text.Length != 0)
                {
                    this.Close();
                    CheckInRestantes ventanaCliente = new CheckInRestantes(textBox2.Text.ToString(), codigoReserva);
                    ventanaCliente.ShowDialog();
                }
                else
                {
                    this.Close();
                    CheckInRestantes ventanaCliente = new CheckInRestantes(this.buscarPorDocumento(), codigoReserva);
                    ventanaCliente.ShowDialog();
                }
            }

        }

        private string buscarPorDocumento()
        {
            string query = "SELECT clie_mail FROM FAAE.Cliente WHERE clie_doc_tipo LIKE '" + comboBox1.Text.ToString() + "' AND clie_doc_nro = " + textBox1.Text.ToString();
            dataReader = DBConnection.Instance.executeQuery(query);
            dataReader.Read();
            string mail = dataReader["clie_mail"].ToString();
            dataReader.Close();
            return mail;
        }

        private string buscarPorMail()
        {
            string query = "SELECT clie_nombre, clie_apellido FROM FAAE.Cliente WHERE clie_mail LIKE '" + textBox2.Text.ToString() + "'";
            dataReader = DBConnection.Instance.executeQuery(query);
            dataReader.Read();
            string nombre = dataReader["clie_nombre"].ToString();
            string apellido = dataReader["clie_apellido"].ToString();
            dataReader.Close();
            return nombre + " " + apellido;
        }

        private void setDocTipoOptions()
        {
            new List<string>() { "Pasaporte", "DNI", "LE" }.ForEach(docTipo => comboBox1.Items.Add(docTipo));
            comboBox1.SelectedItem = "Pasaporte";
        }

        public bool camposIncompletos()
        {
            return new List<Control> { textBox1, textBox2 }.All(form => form.Text.Length == 0);
        }
        public bool camposCompletos()
        {
            return new List<Control> { textBox1, textBox2 }.All(form => form.Text.Length != 0);
        }
    }
}
