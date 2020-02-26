namespace FrbaHotel.GenerarOModificarReserva
{
    partial class frmInformarCostoDeLaReserva
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
            this.tbCostoHabitacion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "El costo total de la reserva es:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbCostoHabitacion
            // 
            this.tbCostoHabitacion.Location = new System.Drawing.Point(106, 68);
            this.tbCostoHabitacion.Name = "tbCostoHabitacion";
            this.tbCostoHabitacion.Size = new System.Drawing.Size(100, 20);
            this.tbCostoHabitacion.TabIndex = 59;
            this.tbCostoHabitacion.TextChanged += new System.EventHandler(this.tbEleccion_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(35, 109);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 60;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.Location = new System.Drawing.Point(189, 109);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(75, 23);
            this.btnRechazar.TabIndex = 61;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = true;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Hay disponibilidad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmInformarCostoDeLaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 148);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbCostoHabitacion);
            this.Controls.Add(this.label2);
            this.Name = "frmInformarCostoDeLaReserva";
            this.Text = "frmInformarCostoDeLaHabitacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCostoHabitacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Label label1;
    }
}