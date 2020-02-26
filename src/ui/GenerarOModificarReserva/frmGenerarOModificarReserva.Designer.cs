namespace FrbaHotel.GenerarOModificarReserva
{
    partial class frmGenerarOModificarReserva
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
            this.btnGenerarReserva = new System.Windows.Forms.Button();
            this.btnModificarReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarReserva
            // 
            this.btnGenerarReserva.Location = new System.Drawing.Point(28, 34);
            this.btnGenerarReserva.Name = "btnGenerarReserva";
            this.btnGenerarReserva.Size = new System.Drawing.Size(84, 52);
            this.btnGenerarReserva.TabIndex = 0;
            this.btnGenerarReserva.Text = "Generar";
            this.btnGenerarReserva.UseVisualStyleBackColor = true;
            this.btnGenerarReserva.Click += new System.EventHandler(this.btnGenerarReserva_Click);
            // 
            // btnModificarReserva
            // 
            this.btnModificarReserva.Location = new System.Drawing.Point(148, 34);
            this.btnModificarReserva.Name = "btnModificarReserva";
            this.btnModificarReserva.Size = new System.Drawing.Size(89, 52);
            this.btnModificarReserva.TabIndex = 1;
            this.btnModificarReserva.Text = "Modificar";
            this.btnModificarReserva.UseVisualStyleBackColor = true;
            this.btnModificarReserva.Click += new System.EventHandler(this.btnModificarReserva_Click);
            // 
            // frmGenerarOModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 133);
            this.Controls.Add(this.btnModificarReserva);
            this.Controls.Add(this.btnGenerarReserva);
            this.Name = "frmGenerarOModificarReserva";
            this.Text = "Generar modificacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarReserva;
        private System.Windows.Forms.Button btnModificarReserva;
    }
}