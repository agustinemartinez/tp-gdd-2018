using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login {
    public partial class frmFuncionalidadesRecepcionista : Form {
        
        public frmFuncionalidadesRecepcionista() { InitializeComponent(); }

        private void btnGenerarModificacionReserva_Click(object sender, EventArgs e) {
            GenerarOModificarReserva.frmGenerarOModificarReserva ventanaGenerarOModificar = new GenerarOModificarReserva.frmGenerarOModificarReserva("recepcionista");
            ventanaGenerarOModificar.Show();
        }

        private void btnABMCliente_Click(object sender, EventArgs e) {
            new AbmCliente.frmABMCliente().Show();
        }

        private void btnRegistroConsumible_Click(object sender, EventArgs e) {
            new FacturarEstadia.frmFacturarEstadia().Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            CancelarReserva.frmCancelarReserva i = new CancelarReserva.frmCancelarReserva();
            i.canceladaPor("Cancelada por recepcionista");
            i.Show();     
        }

        private void btnFacturarEstadia_Click(object sender, EventArgs e) {
            new FacturarEstadia.frmFacturarEstadia().Show();
        }

        private void btnRegistroEstadia_Click(object sender, EventArgs e) {
            DBConnection.Instance.Usuario.buscar();
            new RegistrarEstadia.frmRegistrarEstadia().Show();
        }

     
    }
}
