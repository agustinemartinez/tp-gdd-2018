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

namespace FrbaHotel.FacturarEstadia {
    public partial class frmFacturarEstadia : Form {

        public frmFacturarEstadia() { 
            InitializeComponent();
            this.cargarConsumibles();
        }

        private void btnFacturarEstadia_Click(object sender, EventArgs e) {
            if (this.camposObligatoriosCompletos()) {
                string nroReserva = tbNroReserva.Text.ToString();
                Factura factura = new Factura(nroReserva, cbFormaDePago.SelectedItem.ToString());
                if (factura.reservaExists()) {
                    if (factura.reservaCanceladaOFacturada()) {
                        factura.generar();
                        if (factura.getHotelCodigo() == DBConnection.Instance.Usuario.HotelUltimoLogin) {
                            if (factura.estadiaFinalizada()) {
                            List<Item> items = new List<Item>();
                            for (int i = 0; i < lvConsumibles.Items.Count; i++)
                                factura.agregarItem(this.getItem(i));
                            frmConfirmarFactura frmA = new frmConfirmarFactura();
                            frmA.setFactura(factura);
                            frmA.Show();
                            } else this.msgEstadiaNoFinalizada();
                        } else this.msgReservaDeOtroHotel();
                    } else this.msgReservaCanceladaOFacturada();
                } else this.msgCodigoReservaIncorrecto();
            }
        }

        private void btnRegistrarConsumible_Click(object sender, EventArgs e) {
            if (!datosIncorrectos()) {
                string descripcion = cbConsumible.SelectedItem.ToString();
                string cantidad = tbCantidad.Text.ToString();
                string query = "SELECT cons_codigo, cons_precio FROM FAAE.Consumible";
                query += " WHERE cons_descipcion = '" + descripcion + "'";

                SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);
                dataReader.Read();
                ListViewItem listItem = new ListViewItem(dataReader["cons_codigo"].ToString());
                listItem.SubItems.Add(descripcion);
                listItem.SubItems.Add(cantidad);
                listItem.SubItems.Add(dataReader["cons_precio"].ToString());
                this.lvConsumibles.Items.Add(listItem);
                dataReader.Close();
            }
            else
                this.msgDatosIncorrectos();
        }

        private void btnRemoverConsumible_Click(object sender, EventArgs e) {
            foreach (ListViewItem lista in lvConsumibles.SelectedItems)
                lista.Remove();
        }

        private Item getItem(int index) {
            string cod = lvConsumibles.Items[index].Text.ToString();
            string desc = lvConsumibles.Items[index].SubItems[1].Text.ToString();
            int cant = Convert.ToInt32(lvConsumibles.Items[index].SubItems[2].Text);
            decimal prec = Convert.ToDecimal(lvConsumibles.Items[index].SubItems[3].Text);
            return new Item(cod, desc, cant, prec);
        }

        private void cargarConsumibles() {
            string query = "SELECT cons_descipcion FROM FAAE.Consumible";
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);
            while (dataReader.Read())
                cbConsumible.Items.Add(dataReader["cons_descipcion"]);
            dataReader.Close();
        }

        private void tbNroReserva_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbNroTarjeta_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFormaDePago_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbFormaDePago.SelectedItem.ToString().ToLower().Equals("efectivo"))
                tbNroTarjeta.ReadOnly = true;
            else
                tbNroTarjeta.ReadOnly = false;
        }

        private bool datosIncorrectos() {
            return this.cbConsumible.Text.Length == 0 || Convert.ToInt32(tbCantidad.Text) < 1;
        }

        private bool camposObligatoriosCompletos() {
            return new List<Control> { tbNroReserva, cbFormaDePago }.All(form => form.Text.Length != 0);
        }

        private void msgDatosIncorrectos() {
            MessageBox.Show("Los datos ingresados no son correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void msgCodigoReservaIncorrecto() {
            MessageBox.Show("No se encontro una reserva con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void msgReservaCanceladaOFacturada() {
            MessageBox.Show("La reserva con ese código fue cancelada o ya fue facturada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void msgReservaDeOtroHotel() {
            MessageBox.Show("La reserva se realizo en otro hotel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void msgEstadiaNoFinalizada() {
            MessageBox.Show("Se debe registrar la estadia como finalizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
