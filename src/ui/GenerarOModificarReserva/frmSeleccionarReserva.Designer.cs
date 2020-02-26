namespace FrbaHotel.GenerarOModificarReserva
{
    partial class frmSeleccionarReserva
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
            this.btSeleccionar = new System.Windows.Forms.Button();
            this.tbNumReserva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSeleccionar
            // 
            this.btSeleccionar.Location = new System.Drawing.Point(154, 60);
            this.btSeleccionar.Name = "btSeleccionar";
            this.btSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btSeleccionar.TabIndex = 82;
            this.btSeleccionar.Text = "Seleccionar";
            this.btSeleccionar.UseVisualStyleBackColor = true;
            this.btSeleccionar.Click += new System.EventHandler(this.btSeleccionar_Click);
            // 
            // tbNumReserva
            // 
            this.tbNumReserva.Location = new System.Drawing.Point(217, 34);
            this.tbNumReserva.Name = "tbNumReserva";
            this.tbNumReserva.Size = new System.Drawing.Size(100, 20);
            this.tbNumReserva.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Número de reserva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Seleccionar reserva a modificar";
            // 
            // frmSeleccionarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 95);
            this.Controls.Add(this.btSeleccionar);
            this.Controls.Add(this.tbNumReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "frmSeleccionarReserva";
            this.Text = "frmSeleccionarReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSeleccionar;
        private System.Windows.Forms.TextBox tbNumReserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}