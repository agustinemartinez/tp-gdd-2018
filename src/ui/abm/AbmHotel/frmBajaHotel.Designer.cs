namespace FrbaHotel.AbmHotel
{
    partial class frmBajaHotel
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.dpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(296, 213);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingresar datos de baja de hotel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Motivo: ";
            // 
            // tbMotivo
            // 
            this.tbMotivo.Location = new System.Drawing.Point(201, 96);
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.Size = new System.Drawing.Size(100, 20);
            this.tbMotivo.TabIndex = 11;
            // 
            // dpFechaInicio
            // 
            this.dpFechaInicio.Location = new System.Drawing.Point(201, 129);
            this.dpFechaInicio.Name = "dpFechaInicio";
            this.dpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dpFechaInicio.TabIndex = 12;
            // 
            // dpFechaFin
            // 
            this.dpFechaFin.Location = new System.Drawing.Point(201, 167);
            this.dpFechaFin.Name = "dpFechaFin";
            this.dpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dpFechaFin.TabIndex = 13;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(59, 213);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 14;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmBajaHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 260);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dpFechaFin);
            this.Controls.Add(this.dpFechaInicio);
            this.Controls.Add(this.tbMotivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmBajaHotel";
            this.Text = "frmBajaHotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.DateTimePicker dpFechaInicio;
        private System.Windows.Forms.DateTimePicker dpFechaFin;
        private System.Windows.Forms.Button btnAtras;
    }
}