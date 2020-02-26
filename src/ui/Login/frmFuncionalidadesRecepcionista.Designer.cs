namespace FrbaHotel.Login
{
    partial class frmFuncionalidadesRecepcionista
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
            this.btnGenerarModificacionReserva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnABMCliente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistroEstadia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFacturarEstadia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarModificacionReserva
            // 
            this.btnGenerarModificacionReserva.Location = new System.Drawing.Point(63, 244);
            this.btnGenerarModificacionReserva.Name = "btnGenerarModificacionReserva";
            this.btnGenerarModificacionReserva.Size = new System.Drawing.Size(133, 49);
            this.btnGenerarModificacionReserva.TabIndex = 18;
            this.btnGenerarModificacionReserva.Text = "Generar o modificar reserva";
            this.btnGenerarModificacionReserva.UseVisualStyleBackColor = true;
            this.btnGenerarModificacionReserva.Click += new System.EventHandler(this.btnGenerarModificacionReserva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Reservas:";
            // 
            // btnABMCliente
            // 
            this.btnABMCliente.Location = new System.Drawing.Point(142, 123);
            this.btnABMCliente.Name = "btnABMCliente";
            this.btnABMCliente.Size = new System.Drawing.Size(133, 48);
            this.btnABMCliente.TabIndex = 19;
            this.btnABMCliente.Text = "ABM Cliente";
            this.btnABMCliente.UseVisualStyleBackColor = true;
            this.btnABMCliente.Click += new System.EventHandler(this.btnABMCliente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(234, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 49);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar Reserva";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistroEstadia
            // 
            this.btnRegistroEstadia.Location = new System.Drawing.Point(61, 69);
            this.btnRegistroEstadia.Name = "btnRegistroEstadia";
            this.btnRegistroEstadia.Size = new System.Drawing.Size(133, 48);
            this.btnRegistroEstadia.TabIndex = 22;
            this.btnRegistroEstadia.Text = "Registrar estadia";
            this.btnRegistroEstadia.UseVisualStyleBackColor = true;
            this.btnRegistroEstadia.Click += new System.EventHandler(this.btnRegistroEstadia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Recepcionista";
            // 
            // btnFacturarEstadia
            // 
            this.btnFacturarEstadia.Location = new System.Drawing.Point(220, 69);
            this.btnFacturarEstadia.Name = "btnFacturarEstadia";
            this.btnFacturarEstadia.Size = new System.Drawing.Size(133, 48);
            this.btnFacturarEstadia.TabIndex = 24;
            this.btnFacturarEstadia.Text = "Facturar estadia";
            this.btnFacturarEstadia.UseVisualStyleBackColor = true;
            this.btnFacturarEstadia.Click += new System.EventHandler(this.btnFacturarEstadia_Click);
            // 
            // frmFuncionalidadesRecepcionista
            // 
            this.ClientSize = new System.Drawing.Size(412, 340);
            this.Controls.Add(this.btnFacturarEstadia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegistroEstadia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnABMCliente);
            this.Controls.Add(this.btnGenerarModificacionReserva);
            this.Controls.Add(this.label1);
            this.Name = "frmFuncionalidadesRecepcionista";
            this.Text = "frmFuncionalidadesRecepcionista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarModificacionReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnABMCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistroEstadia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFacturarEstadia;
    }
}