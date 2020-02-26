namespace FrbaHotel.AbmCliente
{
    partial class frmAltaCliente
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
            this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.tbNacionalidad = new System.Windows.Forms.TextBox();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.NuevoHotel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.cbHabilitado = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNroDoc = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPiso = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDepto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.Location = new System.Drawing.Point(391, 109);
            this.dtFechaNac.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(192, 20);
            this.dtFechaNac.TabIndex = 42;
            // 
            // tbNacionalidad
            // 
            this.tbNacionalidad.Location = new System.Drawing.Point(392, 85);
            this.tbNacionalidad.Margin = new System.Windows.Forms.Padding(2);
            this.tbNacionalidad.Name = "tbNacionalidad";
            this.tbNacionalidad.Size = new System.Drawing.Size(91, 20);
            this.tbNacionalidad.TabIndex = 40;
            // 
            // tbCalle
            // 
            this.tbCalle.Location = new System.Drawing.Point(166, 174);
            this.tbCalle.Margin = new System.Windows.Forms.Padding(2);
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(92, 20);
            this.tbCalle.TabIndex = 38;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(166, 150);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(92, 20);
            this.tbTelefono.TabIndex = 37;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroDoc_KeyPress);
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(166, 129);
            this.tbMail.Margin = new System.Windows.Forms.Padding(2);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(92, 20);
            this.tbMail.TabIndex = 35;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(166, 84);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(92, 20);
            this.tbNombre.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 198);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Habilitado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Nacionalidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Localidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Calle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(511, 224);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(62, 26);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // NuevoHotel
            // 
            this.NuevoHotel.AutoSize = true;
            this.NuevoHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoHotel.Location = new System.Drawing.Point(21, 9);
            this.NuevoHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NuevoHotel.Name = "NuevoHotel";
            this.NuevoHotel.Size = new System.Drawing.Size(107, 20);
            this.NuevoHotel.TabIndex = 22;
            this.NuevoHotel.Text = "Nuevo Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Apellido:";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(166, 106);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(92, 20);
            this.tbApellido.TabIndex = 45;
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(393, 39);
            this.tbLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(92, 20);
            this.tbLocalidad.TabIndex = 46;
            // 
            // cbHabilitado
            // 
            this.cbHabilitado.AutoSize = true;
            this.cbHabilitado.Location = new System.Drawing.Point(356, 197);
            this.cbHabilitado.Name = "cbHabilitado";
            this.cbHabilitado.Size = new System.Drawing.Size(15, 14);
            this.cbHabilitado.TabIndex = 47;
            this.cbHabilitado.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Tipo documento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Numero documento:";
            // 
            // tbNroDoc
            // 
            this.tbNroDoc.Location = new System.Drawing.Point(166, 62);
            this.tbNroDoc.Margin = new System.Windows.Forms.Padding(2);
            this.tbNroDoc.Name = "tbNroDoc";
            this.tbNroDoc.Size = new System.Drawing.Size(92, 20);
            this.tbNroDoc.TabIndex = 52;
            this.tbNroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroDoc_KeyPress);
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(166, 198);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(2);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(92, 20);
            this.tbNumero.TabIndex = 54;

            this.tbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroDoc_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 200);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Numero:";
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(392, 63);
            this.tbPais.Margin = new System.Windows.Forms.Padding(2);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(92, 20);
            this.tbPais.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(282, 66);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "Pais";
            // 
            // tbPiso
            // 
            this.tbPiso.Location = new System.Drawing.Point(392, 133);
            this.tbPiso.Margin = new System.Windows.Forms.Padding(2);
            this.tbPiso.Name = "tbPiso";
            this.tbPiso.Size = new System.Drawing.Size(92, 20);
            this.tbPiso.TabIndex = 58;
            this.tbPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroDoc_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(282, 136);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "Piso";
            // 
            // tbDepto
            // 
            this.tbDepto.Location = new System.Drawing.Point(392, 157);
            this.tbDepto.Margin = new System.Windows.Forms.Padding(2);
            this.tbDepto.Name = "tbDepto";
            this.tbDepto.Size = new System.Drawing.Size(92, 20);
            this.tbDepto.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(282, 160);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 59;
            this.label15.Text = "Depto";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(393, 226);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 61;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Location = new System.Drawing.Point(166, 36);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(92, 21);
            this.cbTipoDoc.TabIndex = 62;
            // 
            // frmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 272);
            this.Controls.Add(this.cbTipoDoc);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.tbDepto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbPiso);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbNroDoc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbHabilitado);
            this.Controls.Add(this.tbLocalidad);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtFechaNac);
            this.Controls.Add(this.tbNacionalidad);
            this.Controls.Add(this.tbCalle);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.NuevoHotel);
            this.Name = "frmAltaCliente";
            this.Text = "frmAltaCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private System.Windows.Forms.TextBox tbNacionalidad;
        private System.Windows.Forms.TextBox tbCalle;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label NuevoHotel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.CheckBox cbHabilitado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNroDoc;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbPiso;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbDepto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ComboBox cbTipoDoc;

    }
}