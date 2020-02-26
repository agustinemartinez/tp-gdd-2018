using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHabitacion {
    public partial class frmAdvertenciaBaja : Form {

        string numeroHabitacion;
        string codigoHotel;

        public frmAdvertenciaBaja(string numeroHabitacion, string codigoHotel) {
            InitializeComponent();
            this.numeroHabitacion = numeroHabitacion;
            this.codigoHotel = codigoHotel;
        }

        private void btnSi_Click(object sender, EventArgs e) {
            string[] param = { "@habi_nro", "@habi_hote_codigo"};
            object[] args = { this.numeroHabitacion, this.codigoHotel};
            DBConnection.Instance.executeProcedure("FAAE.inhabilitar_habitacion", param, args);
            MessageBox.Show("Se inhabilito satisfactoriamente");
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e) { this.Close(); }

    }
}
