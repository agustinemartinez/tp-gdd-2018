namespace FrbaHotel.GenerarOModificarReserva
{
    partial class frmBuscarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDocNro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDocTipo = new System.Windows.Forms.ComboBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDocNro
            // 
            this.tbDocNro.Location = new System.Drawing.Point(133, 81);
            this.tbDocNro.Margin = new System.Windows.Forms.Padding(2);
            this.tbDocNro.Name = "tbDocNro";
            this.tbDocNro.Size = new System.Drawing.Size(113, 20);
            this.tbDocNro.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tipo de identificación:";
            // 
            // cbDocTipo
            // 
            this.cbDocTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocTipo.FormattingEnabled = true;
            this.cbDocTipo.Location = new System.Drawing.Point(133, 47);
            this.cbDocTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbDocTipo.Name = "cbDocTipo";
            this.cbDocTipo.Size = new System.Drawing.Size(78, 21);
            this.cbDocTipo.TabIndex = 14;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(133, 154);
            this.tbMail.Margin = new System.Windows.Forms.Padding(2);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(96, 20);
            this.tbMail.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 161);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nro. de identificación:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(266, 73);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 63);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "O buscar por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Buscar por:";
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 204);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbDocNro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbDocTipo);
            this.Name = "frmBuscarCliente";
            this.Text = "frmBuscarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDocNro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbDocTipo;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}