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

namespace FrbaHotel.AbmHabitacion {
    public partial class frmInhabilitarHabitacion : Form {

        public frmInhabilitarHabitacion() { InitializeComponent(); }

        private void btSeleccionar_Click(object sender, EventArgs e) {

            string query = "SELECT habi_nro, habi_hote_codigo FROM FAAE.Habitacion WHERE habi_nro = " + tbNumHab.Text.ToString() + "AND habi_hote_codigo = " + tbcodHotel.Text.ToString();
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);

            if (dataReader.Read()) {
                string[] param = { "@habi_nro", "@habi_hote_codigo"};
                object[] args = {tbNumHab.Text.ToString(), tbcodHotel.Text.ToString()};
                DBConnection.Instance.executeProcedure("FAAE.inhabilitar_habitacion", param, args);
                MessageBox.Show("Se Inhabilito satisfactoriamente");
                this.Close();
            }
            else
                MessageBox.Show("Error: No existe esa habitacion");
 
            dataReader.Close();
        }

    }
}
