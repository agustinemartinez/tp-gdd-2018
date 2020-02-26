namespace FrbaHotel.AbmUsuario
{
    partial class frmABMUsuario
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
            this.frmInhabilitar = new System.Windows.Forms.Button();
            this.frmModificacion = new System.Windows.Forms.Button();
            this.frmAlta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvUsuarios = new System.Windows.Forms.ListView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frmInhabilitar
            // 
            this.frmInhabilitar.Location = new System.Drawing.Point(658, 159);
            this.frmInhabilitar.Margin = new System.Windows.Forms.Padding(4);
            this.frmInhabilitar.Name = "frmInhabilitar";
            this.frmInhabilitar.Size = new System.Drawing.Size(100, 28);
            this.frmInhabilitar.TabIndex = 6;
            this.frmInhabilitar.Text = "Inhabilitar";
            this.frmInhabilitar.UseVisualStyleBackColor = true;
            this.frmInhabilitar.Click += new System.EventHandler(this.frmInhabilitar_Click);
            // 
            // frmModificacion
            // 
            this.frmModificacion.Location = new System.Drawing.Point(658, 195);
            this.frmModificacion.Margin = new System.Windows.Forms.Padding(4);
            this.frmModificacion.Name = "frmModificacion";
            this.frmModificacion.Size = new System.Drawing.Size(100, 28);
            this.frmModificacion.TabIndex = 7;
            this.frmModificacion.Text = "Modificacion";
            this.frmModificacion.UseVisualStyleBackColor = true;
            this.frmModificacion.Click += new System.EventHandler(this.frmModificacion_Click);
            // 
            // frmAlta
            // 
            this.frmAlta.Location = new System.Drawing.Point(658, 123);
            this.frmAlta.Margin = new System.Windows.Forms.Padding(4);
            this.frmAlta.Name = "frmAlta";
            this.frmAlta.Size = new System.Drawing.Size(100, 28);
            this.frmAlta.TabIndex = 5;
            this.frmAlta.Text = "Alta";
            this.frmAlta.UseVisualStyleBackColor = true;
            this.frmAlta.Click += new System.EventHandler(this.frmAlta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(112, 345);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(136, 22);
            this.tbUsername.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "ABM Usuario";
            // 
            // lvUsuarios
            // 
            this.lvUsuarios.FullRowSelect = true;
            this.lvUsuarios.GridLines = true;
            this.lvUsuarios.Location = new System.Drawing.Point(22, 63);
            this.lvUsuarios.MultiSelect = false;
            this.lvUsuarios.Name = "lvUsuarios";
            this.lvUsuarios.Size = new System.Drawing.Size(617, 256);
            this.lvUsuarios.TabIndex = 15;
            this.lvUsuarios.UseCompatibleStateImageBehavior = false;
            this.lvUsuarios.View = System.Windows.Forms.View.Details;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(539, 340);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 32);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmABMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 390);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvUsuarios);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.frmModificacion);
            this.Controls.Add(this.frmInhabilitar);
            this.Controls.Add(this.frmAlta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmABMUsuario";
            this.Text = "ABM Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frmInhabilitar;
        private System.Windows.Forms.Button frmModificacion;
        private System.Windows.Forms.Button frmAlta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvUsuarios;
        private System.Windows.Forms.Button btnBuscar;
    }
}