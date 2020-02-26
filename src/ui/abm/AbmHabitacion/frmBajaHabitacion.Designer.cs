namespace FrbaHotel.AbmHabitacion
{
    partial class frmBajaHabitacion
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
            this.tbcodHotel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNumHab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSeleccionar
            // 
            this.btSeleccionar.Location = new System.Drawing.Point(136, 115);
            this.btSeleccionar.Name = "btSeleccionar";
            this.btSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btSeleccionar.TabIndex = 76;
            this.btSeleccionar.Text = "Seleccionar";
            this.btSeleccionar.UseVisualStyleBackColor = true;
            this.btSeleccionar.Click += new System.EventHandler(this.btSeleccionar_Click);
            // 
            // tbcodHotel
            // 
            this.tbcodHotel.Location = new System.Drawing.Point(202, 77);
            this.tbcodHotel.Name = "tbcodHotel";
            this.tbcodHotel.Size = new System.Drawing.Size(100, 20);
            this.tbcodHotel.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Pertenece al hotel:";
            // 
            // tbNumHab
            // 
            this.tbNumHab.Location = new System.Drawing.Point(202, 48);
            this.tbNumHab.Name = "tbNumHab";
            this.tbNumHab.Size = new System.Drawing.Size(100, 20);
            this.tbNumHab.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Número de Habitación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Seleccionar habitacion a eliminar:";
            // 
            // frmBajaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 145);
            this.Controls.Add(this.btSeleccionar);
            this.Controls.Add(this.tbcodHotel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNumHab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "frmBajaHabitacion";
            this.Text = "frmBajaHabitacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSeleccionar;
        private System.Windows.Forms.TextBox tbcodHotel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNumHab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}