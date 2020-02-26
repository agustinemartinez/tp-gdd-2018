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

namespace FrbaHotel.AbmHotel {
    public partial class frmAltaHotel : Form {

        private Hotel hotel;

        public frmAltaHotel() { 
            InitializeComponent();
            this.setLvProperties();
            this.cargarRegimenesDisponibles();
        }

        public void setHotel(Hotel hotel) {
            this.hotel = hotel;
            this.cargarHotelActual();        
        }

        private void cargarHotelActual() {
            tbNombreHotel.Text            = hotel.getNombre();
            tbMailHotel.Text              = hotel.getMail();
            tbTelefonoHotel.Text          = hotel.getTelefono();
            tbCalleHotel.Text             = hotel.getDire_calle();
            tbNroCalleHotel.Text          = hotel.getDire_nro();
            cbCantidadEstrellasHotel.Text = hotel.getEstrellas().ToString();
            tbCiudadHotel.Text            = hotel.getCiudad();
            tbPaisHotel.Text              = hotel.getPais();
            dtFechaCreacionHotel.Text     = hotel.getFechaCreacion().ToShortDateString();
            nudRecargaEstrellasHotel.Text = hotel.getRecargaEstrellas().ToString();
            hotel.getRegimenes().ForEach(regimen => lvRegimen.Items.Add(new ListViewItem(regimen)));
            btnLimpiar.Enabled = false;
        }

        private void btnAgregarRegimen_Click(object sender, EventArgs e) {
            string regimenAgregar = cbRegimen.SelectedItem.ToString();
            if (regimenAgregar.Length != 0)
                lvRegimen.Items.Add(regimenAgregar);
        }

        private void btnQuitarRegimen_Click(object sender, EventArgs e) {
            if (lvRegimen.SelectedItems.Count == 1) {
                if (!hotel.tieneReservasConRegimen(lvRegimen.SelectedItems[0].Text))
                    lvRegimen.SelectedItems[0].Remove();
                else
                    msgExistenReservasConRegimen();            
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (this.camposObligatoriosCompletos()) {
                Hotel hotel = this.getHotel();
                hotel.setNombre(tbNombreHotel.Text);
                hotel.setMail(tbMailHotel.Text);
                hotel.setTelefono(tbTelefonoHotel.Text);
                hotel.setDire_calle(tbCalleHotel.Text);
                hotel.setDire_nro(tbNroCalleHotel.Text);
                hotel.setEstrellas(Convert.ToInt16(cbCantidadEstrellasHotel.Text));
                hotel.setCiudad(tbCiudadHotel.Text);
                hotel.setPais(tbPaisHotel.Text);
                if (dtFechaCreacionHotel.Value != null) 
                    hotel.setFechaCreacion(dtFechaCreacionHotel.Value);
                hotel.setRecargaEstrellas(Convert.ToDecimal(nudRecargaEstrellasHotel.Value));
                hotel.limpiarRegimenes();
                for (int i = 0; i < lvRegimen.Items.Count; i++)
                    hotel.agregarRegimen(lvRegimen.Items[i].Text);
                hotel.guardar();
                Close();
            }
            else 
                this.msgCamposIncompletos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            new List<TextBox>() { tbNombreHotel, tbMailHotel, tbTelefonoHotel, tbCalleHotel, tbNroCalleHotel, tbCiudadHotel, tbPaisHotel }.ForEach(control => control.Clear());
            lvRegimen.Items.Clear();
        }

        private bool camposObligatoriosCompletos() {
            return new List<Control> { tbNombreHotel, tbCalleHotel, tbNroCalleHotel, cbCantidadEstrellasHotel }.All(form => form.Text.Length != 0) && lvRegimen.Items.Count > 0;
        }

        public void cargarRegimenesDisponibles() {
            this.lvRegimen.Items.Clear();
            string query = "SELECT regi_nombre FROM FAAE.Regimen WHERE regi_activo = 1";
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);
            while (dataReader.Read())
                this.cbRegimen.Items.Add(dataReader["regi_nombre"].ToString());
            dataReader.Close();
        }

        public void setTitle(string title) { this.ModificarHotel.Text = title; }

        private Hotel getHotel() {
            if (hotel == null)
                return new Hotel();
            return this.hotel;
        }

        private void tbTelefonoHotel_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbNroCalleHotel_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void setLvProperties() {
            this.lvRegimen.Columns.Add("Regimen");
            this.lvRegimen.View = View.Details;
            this.lvRegimen.MultiSelect = false;
        }

        private void msgCamposIncompletos() {
            MessageBox.Show("Campos obligatorios incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void msgExistenReservasConRegimen() {
            MessageBox.Show("Hay reservas hechas bajo ese regimen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
