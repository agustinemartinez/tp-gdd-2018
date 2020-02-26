namespace FrbaHotel.GenerarOModificarReserva
{
    partial class frmEleccionDeRegimen
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
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.lvRegimenes = new System.Windows.Forms.ListView();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Location = new System.Drawing.Point(163, 58);
            this.btnAgregarRol.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(83, 24);
            this.btnAgregarRol.TabIndex = 33;
            this.btnAgregarRol.Text = "Seleccionar";
            this.btnAgregarRol.UseVisualStyleBackColor = true;
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // lvRegimenes
            // 
            this.lvRegimenes.FullRowSelect = true;
            this.lvRegimenes.GridLines = true;
            this.lvRegimenes.Location = new System.Drawing.Point(51, 58);
            this.lvRegimenes.Margin = new System.Windows.Forms.Padding(2);
            this.lvRegimenes.MultiSelect = false;
            this.lvRegimenes.Name = "lvRegimenes";
            this.lvRegimenes.Size = new System.Drawing.Size(84, 122);
            this.lvRegimenes.TabIndex = 32;
            this.lvRegimenes.UseCompatibleStateImageBehavior = false;
            this.lvRegimenes.View = System.Windows.Forms.View.Details;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(48, 28);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 18);
            this.label14.TabIndex = 31;
            this.label14.Text = "Regimenes Disponibles:";
            // 
            // frmEleccionDeRegimen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.btnAgregarRol);
            this.Controls.Add(this.lvRegimenes);
            this.Controls.Add(this.label14);
            this.Name = "frmEleccionDeRegimen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarRol;
        private System.Windows.Forms.ListView lvRegimenes;
        private System.Windows.Forms.Label label14;

    }
}