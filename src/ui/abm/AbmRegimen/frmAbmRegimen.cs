﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRegimen
{
    public partial class frmAbmRegimen : Form
    {
        public frmAbmRegimen()
        {
            InitializeComponent();
        }

        private void frmAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaRegimen ventanaAlta = new AltaRegimen();
            ventanaAlta.Show();
        }
    }
}