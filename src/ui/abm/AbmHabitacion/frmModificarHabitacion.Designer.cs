namespace FrbaHotel.AbmHabitacion
{
    partial class frmModificarHabitacion
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
            this.tbcodHotel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPiso = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoHab = new System.Windows.Forms.ComboBox();
            this.cbUbicacion = new System.Windows.Forms.ComboBox();
            this.tbNumHab = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbcodHotel
            // 
            this.tbcodHotel.Location = new System.Drawing.Point(208, 57);
            this.tbcodHotel.Name = "tbcodHotel";
            this.tbcodHotel.Size = new System.Drawing.Size(100, 20);
            this.tbcodHotel.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 101;
            this.label5.Text = "Pertenece al hotel:";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(267, 201);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 92;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(208, 201);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(34, 17);
            this.rbSi.TabIndex = 91;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 100;
            this.label6.Text = "Esta habilitada?";
            // 
            // tbPiso
            // 
            this.tbPiso.Location = new System.Drawing.Point(208, 87);
            this.tbPiso.Name = "tbPiso";
            this.tbPiso.Size = new System.Drawing.Size(100, 20);
            this.tbPiso.TabIndex = 87;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(208, 175);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tbDescripcion.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "Descripción/Comodidades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Tipo de Habitación";
            // 
            // cbTipoHab
            // 
            this.cbTipoHab.FormattingEnabled = true;
            this.cbTipoHab.Items.AddRange(new object[] {
            "Base Simple",
            "Base Doble",
            "King",
            "Base Triple",
            "Base Cuádruple"});
            this.cbTipoHab.Location = new System.Drawing.Point(187, 146);
            this.cbTipoHab.Name = "cbTipoHab";
            this.cbTipoHab.Size = new System.Drawing.Size(121, 21);
            this.cbTipoHab.TabIndex = 89;
            // 
            // cbUbicacion
            // 
            this.cbUbicacion.FormattingEnabled = true;
            this.cbUbicacion.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbUbicacion.Location = new System.Drawing.Point(187, 119);
            this.cbUbicacion.Name = "cbUbicacion";
            this.cbUbicacion.Size = new System.Drawing.Size(121, 21);
            this.cbUbicacion.TabIndex = 88;
            // 
            // tbNumHab
            // 
            this.tbNumHab.Location = new System.Drawing.Point(208, 28);
            this.tbNumHab.Name = "tbNumHab";
            this.tbNumHab.Size = new System.Drawing.Size(100, 20);
            this.tbNumHab.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 97;
            this.label11.Text = "Piso dentro del Hotel:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 96;
            this.label10.Text = "Vista al exterior:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Número de Habitación:";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(19, 235);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 94;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(267, 235);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 93;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmModificarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 266);
            this.Controls.Add(this.tbcodHotel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbSi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPiso);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoHab);
            this.Controls.Add(this.cbUbicacion);
            this.Controls.Add(this.tbNumHab);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmModificarHabitacion";
            this.Text = "frmModificarHabitacion";
            this.Load += new System.EventHandler(this.frmModificarHabitacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbcodHotel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPiso;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoHab;
        private System.Windows.Forms.ComboBox cbUbicacion;
        private System.Windows.Forms.TextBox tbNumHab;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnGuardar;

    }
}