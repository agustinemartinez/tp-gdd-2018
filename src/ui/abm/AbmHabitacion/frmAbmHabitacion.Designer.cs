namespace FrbaHotel.AbmHabitacion
{
    partial class frmAbmHabitacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumeroHabitacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvHabitaciones = new System.Windows.Forms.ListView();
            this.btModificacion = new System.Windows.Forms.Button();
            this.frmBaja = new System.Windows.Forms.Button();
            this.frmAlta = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodigoHotel = new System.Windows.Forms.TextBox();
            this.tbPiso = new System.Windows.Forms.TextBox();
            this.tbVistaExterior = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Numero:";
            // 
            // tbNumeroHabitacion
            // 
            this.tbNumeroHabitacion.Location = new System.Drawing.Point(109, 278);
            this.tbNumeroHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.tbNumeroHabitacion.Name = "tbNumeroHabitacion";
            this.tbNumeroHabitacion.Size = new System.Drawing.Size(103, 20);
            this.tbNumeroHabitacion.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "ABM Habitación";
            // 
            // lvHabitaciones
            // 
            this.lvHabitaciones.FullRowSelect = true;
            this.lvHabitaciones.GridLines = true;
            this.lvHabitaciones.Location = new System.Drawing.Point(20, 50);
            this.lvHabitaciones.Margin = new System.Windows.Forms.Padding(2);
            this.lvHabitaciones.MultiSelect = false;
            this.lvHabitaciones.Name = "lvHabitaciones";
            this.lvHabitaciones.Size = new System.Drawing.Size(464, 209);
            this.lvHabitaciones.TabIndex = 38;
            this.lvHabitaciones.UseCompatibleStateImageBehavior = false;
            this.lvHabitaciones.View = System.Windows.Forms.View.Details;
            // 
            // btModificacion
            // 
            this.btModificacion.Location = new System.Drawing.Point(494, 172);
            this.btModificacion.Name = "btModificacion";
            this.btModificacion.Size = new System.Drawing.Size(94, 23);
            this.btModificacion.TabIndex = 37;
            this.btModificacion.Text = "Modificacion";
            this.btModificacion.UseVisualStyleBackColor = true;
            this.btModificacion.Click += new System.EventHandler(this.btModificacion_Click);
            // 
            // frmBaja
            // 
            this.frmBaja.Location = new System.Drawing.Point(494, 135);
            this.frmBaja.Name = "frmBaja";
            this.frmBaja.Size = new System.Drawing.Size(94, 23);
            this.frmBaja.TabIndex = 36;
            this.frmBaja.Text = "Baja";
            this.frmBaja.UseVisualStyleBackColor = true;
            this.frmBaja.Click += new System.EventHandler(this.frmBaja_Click);
            // 
            // frmAlta
            // 
            this.frmAlta.Location = new System.Drawing.Point(494, 98);
            this.frmAlta.Name = "frmAlta";
            this.frmAlta.Size = new System.Drawing.Size(94, 23);
            this.frmAlta.TabIndex = 35;
            this.frmAlta.Text = "Alta";
            this.frmAlta.UseVisualStyleBackColor = true;
            this.frmAlta.Click += new System.EventHandler(this.frmAlta_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(494, 276);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 53);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 319);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Codigo del hotel:";
            // 
            // tbCodigoHotel
            // 
            this.tbCodigoHotel.Location = new System.Drawing.Point(109, 312);
            this.tbCodigoHotel.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoHotel.Name = "tbCodigoHotel";
            this.tbCodigoHotel.Size = new System.Drawing.Size(103, 20);
            this.tbCodigoHotel.TabIndex = 44;
            // 
            // tbPiso
            // 
            this.tbPiso.Location = new System.Drawing.Point(303, 276);
            this.tbPiso.Margin = new System.Windows.Forms.Padding(2);
            this.tbPiso.Name = "tbPiso";
            this.tbPiso.Size = new System.Drawing.Size(103, 20);
            this.tbPiso.TabIndex = 45;
            // 
            // tbVistaExterior
            // 
            this.tbVistaExterior.Location = new System.Drawing.Point(303, 312);
            this.tbVistaExterior.Margin = new System.Windows.Forms.Padding(2);
            this.tbVistaExterior.Name = "tbVistaExterior";
            this.tbVistaExterior.Size = new System.Drawing.Size(103, 20);
            this.tbVistaExterior.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Piso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 319);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Vista Exterior:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Habilitada";
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(109, 350);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(34, 17);
            this.rbSi.TabIndex = 50;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(150, 350);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 51;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(494, 335);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(94, 30);
            this.btLimpiar.TabIndex = 52;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // frmAbmHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 377);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbSi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVistaExterior);
            this.Controls.Add(this.tbPiso);
            this.Controls.Add(this.tbCodigoHotel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNumeroHabitacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvHabitaciones);
            this.Controls.Add(this.btModificacion);
            this.Controls.Add(this.frmBaja);
            this.Controls.Add(this.frmAlta);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmAbmHabitacion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumeroHabitacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvHabitaciones;
        private System.Windows.Forms.Button btModificacion;
        private System.Windows.Forms.Button frmBaja;
        private System.Windows.Forms.Button frmAlta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodigoHotel;
        private System.Windows.Forms.TextBox tbPiso;
        private System.Windows.Forms.TextBox tbVistaExterior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Button btLimpiar;

    }
}