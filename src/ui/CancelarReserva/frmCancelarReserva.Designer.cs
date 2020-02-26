namespace FrbaHotel.CancelarReserva
{
    partial class frmCancelarReserva
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
            this.btnCncelarReserva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNroReserva = new System.Windows.Forms.TextBox();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.tbUsuarioCancelador = new System.Windows.Forms.TextBox();
            this.dtpFechaCancelacion = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCncelarReserva
            // 
            this.btnCncelarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCncelarReserva.Location = new System.Drawing.Point(288, 307);
            this.btnCncelarReserva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCncelarReserva.Name = "btnCncelarReserva";
            this.btnCncelarReserva.Size = new System.Drawing.Size(143, 37);
            this.btnCncelarReserva.TabIndex = 0;
            this.btnCncelarReserva.Text = "Cancelar reserva";
            this.btnCncelarReserva.UseVisualStyleBackColor = true;
            this.btnCncelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de reserva: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Motivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de cancelacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Usuario que cancela:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingrese datos de reserva a cancelar";
            // 
            // tbNroReserva
            // 
            this.tbNroReserva.Location = new System.Drawing.Point(238, 109);
            this.tbNroReserva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNroReserva.Name = "tbNroReserva";
            this.tbNroReserva.Size = new System.Drawing.Size(76, 20);
            this.tbNroReserva.TabIndex = 6;
            // 
            // tbMotivo
            // 
            this.tbMotivo.Location = new System.Drawing.Point(238, 141);
            this.tbMotivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.Size = new System.Drawing.Size(76, 20);
            this.tbMotivo.TabIndex = 7;
            // 
            // tbUsuarioCancelador
            // 
            this.tbUsuarioCancelador.Location = new System.Drawing.Point(238, 206);
            this.tbUsuarioCancelador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUsuarioCancelador.Name = "tbUsuarioCancelador";
            this.tbUsuarioCancelador.Size = new System.Drawing.Size(76, 20);
            this.tbUsuarioCancelador.TabIndex = 9;
            // 
            // dtpFechaCancelacion
            // 
            this.dtpFechaCancelacion.Location = new System.Drawing.Point(238, 176);
            this.dtpFechaCancelacion.Name = "dtpFechaCancelacion";
            this.dtpFechaCancelacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCancelacion.TabIndex = 10;
            // 
            // frmCancelarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 416);
            this.Controls.Add(this.dtpFechaCancelacion);
            this.Controls.Add(this.tbUsuarioCancelador);
            this.Controls.Add(this.tbMotivo);
            this.Controls.Add(this.tbNroReserva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCncelarReserva);
            this.Name = "frmCancelarReserva";
            this.Text = "Cancelar reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCncelarReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNroReserva;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.TextBox tbUsuarioCancelador;
        private System.Windows.Forms.DateTimePicker dtpFechaCancelacion;
    }
}