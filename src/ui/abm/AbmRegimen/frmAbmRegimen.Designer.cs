namespace FrbaHotel.AbmRegimen
{
    partial class frmAbmRegimen
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
            this.frmModificacion = new System.Windows.Forms.Button();
            this.frmBaja = new System.Windows.Forms.Button();
            this.frmAlta = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frmModificacion
            // 
            this.frmModificacion.Location = new System.Drawing.Point(162, 138);
            this.frmModificacion.Name = "frmModificacion";
            this.frmModificacion.Size = new System.Drawing.Size(75, 23);
            this.frmModificacion.TabIndex = 7;
            this.frmModificacion.Text = "Modificacion";
            this.frmModificacion.UseVisualStyleBackColor = true;
            // 
            // frmBaja
            // 
            this.frmBaja.Location = new System.Drawing.Point(48, 138);
            this.frmBaja.Name = "frmBaja";
            this.frmBaja.Size = new System.Drawing.Size(75, 23);
            this.frmBaja.TabIndex = 6;
            this.frmBaja.Text = "Baja";
            this.frmBaja.UseVisualStyleBackColor = true;
            // 
            // frmAlta
            // 
            this.frmAlta.Location = new System.Drawing.Point(162, 99);
            this.frmAlta.Name = "frmAlta";
            this.frmAlta.Size = new System.Drawing.Size(75, 23);
            this.frmAlta.TabIndex = 5;
            this.frmAlta.Text = "Alta";
            this.frmAlta.UseVisualStyleBackColor = true;
            this.frmAlta.Click += new System.EventHandler(this.frmAlta_Click);
            // 
            // btnListado
            // 
            this.btnListado.Location = new System.Drawing.Point(48, 99);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(75, 23);
            this.btnListado.TabIndex = 4;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = true;
            // 
            // frmAbmRegimen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.frmModificacion);
            this.Controls.Add(this.frmBaja);
            this.Controls.Add(this.frmAlta);
            this.Controls.Add(this.btnListado);
            this.Name = "frmAbmRegimen";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button frmModificacion;
        private System.Windows.Forms.Button frmBaja;
        private System.Windows.Forms.Button frmAlta;
        private System.Windows.Forms.Button btnListado;
    }
}