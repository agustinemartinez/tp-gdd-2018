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

namespace FrbaHotel.GenerarOModificarReserva
{
    public partial class frmEleccionDeRegimen : Form
    {
        long nroHotel = DBConnection.Instance.Usuario.HotelUltimoLogin;
        string regimenQueEligio;
        public frmEleccionDeRegimen()
        {
            InitializeComponent();
            this.setLvProperties();
        }

        public ListViewItem nuevoItem(SqlDataReader dataReader)
        {
            ListViewItem listItems = new ListViewItem(dataReader["reho_regi_codigo"].ToString());
            return listItems;
        }

        public string regimenElegido()
        {
           return regimenQueEligio;
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            if (this.lvRegimenes.SelectedItems.Count == 1)
            {
                this.regimenQueEligio = this.lvRegimenes.SelectedItems[0].Text.ToString();
            }
            this.Close();
        }

        public void setLvProperties() 
        {
            new List<string>() { "Regimenes" }.ForEach(columna => this.lvRegimenes.Columns.Add(columna));
            this.lvRegimenes.View = View.Details;
            this.lvRegimenes.MultiSelect = false;

            this.lvRegimenes.Items.Clear();
            string query = "SELECT reho_regi_codigo FROM FAAE.Regimen_Hotel WHERE reho_hote_codigo = " + nroHotel.ToString();
            SqlDataReader dataReader = DBConnection.Instance.executeQuery(query);

            while (dataReader.Read())
            {
                ListViewItem listItem = this.nuevoItem(dataReader, new List<string>() { "reho_regi_codigo"});
                this.lvRegimenes.Items.Add(listItem);
            }
            dataReader.Close();
        }

        public ListViewItem nuevoItem(SqlDataReader dataReader, List<string> campos)
        {
            ListViewItem listItems = new ListViewItem(dataReader[campos[0]].ToString());
            campos.Skip(1).ToList().ForEach(subitem => listItems.SubItems.Add(dataReader[subitem].ToString()));
            return listItems;
        }
    }
}
