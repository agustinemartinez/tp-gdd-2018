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
    public partial class frmConfirmarFactura : Form {

        Factura factura;

        public frmConfirmarFactura() { 
            InitializeComponent();
            this.setLvProperties();
        }

        public void setFactura(Factura factura) {
            this.factura = factura;
            this.cargarFactura();
        }

        private void btnConfirmar_Click(object sender, EventArgs e) {
            factura.guardar();
            //estadia.registrarFechaSalida() esta_fecha_salida = getDate()
            this.Close();
        }

        private void cargarFactura() {
            lbFactNro.Text     = factura.getTipo() + " - " + factura.getNro();
            lbFecha.Text       = factura.getFecha().ToShortDateString();
            lbNombreHotel.Text = factura.getHotelNombre();
            lbCliente.Text     = factura.getNombreCliente();
            lbTotal.Text       = "U$ " + factura.getTotal().ToString();
            //lvItems.Items.Add(this.nuevoItemFactura( new Item("0000", "Estadia " + factura.cantidadNochesReservadas() + " noches", 1, factura.getTotalEstadia()) ));
            factura.getItems().ForEach(item => lvItems.Items.Add(this.nuevoItemFactura(item)));
        }

        public ListViewItem nuevoItemFactura(Item item) {
            ListViewItem listItems = new ListViewItem(item.getDescripcion());
            listItems.SubItems.Add(item.getCantidad().ToString());
            listItems.SubItems.Add(item.getPrecioUnitario().ToString());
            return listItems;
        }

        public void setLvProperties() {
            new List<string>() { "Concepto", "Cantidad", "Precio unitario" }
                .ForEach(columna => this.lvItems.Columns.Add(columna));
            this.lvItems.View = View.Details;
            this.lvItems.MultiSelect = false;
        }

    }
}
