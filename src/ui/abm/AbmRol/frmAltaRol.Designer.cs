namespace FrbaHotel.AbmRol {
    partial class frmAltaRol {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombreRol = new System.Windows.Forms.TextBox();
            this.cbFuncionalidades = new System.Windows.Forms.ComboBox();
            this.btnAgregarFuncionalidad = new System.Windows.Forms.Button();
            this.lvFuncionalidades = new System.Windows.Forms.ListView();
            this.btnQuitarFuncionalidad = new System.Windows.Forms.Button();
            this.cbHabilitado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Rol";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(370, 320);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 40);
            this.btnAceptar.TabIndex = 38;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Funcionalidades:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nombre:";
            // 
            // tbNombreRol
            // 
            this.tbNombreRol.Location = new System.Drawing.Point(94, 73);
            this.tbNombreRol.Name = "tbNombreRol";
            this.tbNombreRol.Size = new System.Drawing.Size(117, 22);
            this.tbNombreRol.TabIndex = 35;
            // 
            // cbFuncionalidades
            // 
            this.cbFuncionalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionalidades.FormattingEnabled = true;
            this.cbFuncionalidades.Location = new System.Drawing.Point(29, 146);
            this.cbFuncionalidades.Name = "cbFuncionalidades";
            this.cbFuncionalidades.Size = new System.Drawing.Size(317, 24);
            this.cbFuncionalidades.TabIndex = 34;
            // 
            // btnAgregarFuncionalidad
            // 
            this.btnAgregarFuncionalidad.Location = new System.Drawing.Point(370, 142);
            this.btnAgregarFuncionalidad.Name = "btnAgregarFuncionalidad";
            this.btnAgregarFuncionalidad.Size = new System.Drawing.Size(84, 30);
            this.btnAgregarFuncionalidad.TabIndex = 33;
            this.btnAgregarFuncionalidad.Text = "Agregar";
            this.btnAgregarFuncionalidad.UseVisualStyleBackColor = true;
            this.btnAgregarFuncionalidad.Click += new System.EventHandler(this.btnAgregarFuncionalidad_Click);
            // 
            // lvFuncionalidades
            // 
            this.lvFuncionalidades.FullRowSelect = true;
            this.lvFuncionalidades.GridLines = true;
            this.lvFuncionalidades.Location = new System.Drawing.Point(29, 192);
            this.lvFuncionalidades.MultiSelect = false;
            this.lvFuncionalidades.Name = "lvFuncionalidades";
            this.lvFuncionalidades.Size = new System.Drawing.Size(317, 149);
            this.lvFuncionalidades.TabIndex = 32;
            this.lvFuncionalidades.UseCompatibleStateImageBehavior = false;
            this.lvFuncionalidades.View = System.Windows.Forms.View.Details;
            // 
            // btnQuitarFuncionalidad
            // 
            this.btnQuitarFuncionalidad.Location = new System.Drawing.Point(370, 192);
            this.btnQuitarFuncionalidad.Name = "btnQuitarFuncionalidad";
            this.btnQuitarFuncionalidad.Size = new System.Drawing.Size(84, 30);
            this.btnQuitarFuncionalidad.TabIndex = 39;
            this.btnQuitarFuncionalidad.Text = "Quitar";
            this.btnQuitarFuncionalidad.UseVisualStyleBackColor = true;
            this.btnQuitarFuncionalidad.Click += new System.EventHandler(this.btnQuitarFuncionalidad_Click);
            // 
            // cbHabilitado
            // 
            this.cbHabilitado.AutoSize = true;
            this.cbHabilitado.Location = new System.Drawing.Point(253, 74);
            this.cbHabilitado.Name = "cbHabilitado";
            this.cbHabilitado.Size = new System.Drawing.Size(93, 21);
            this.cbHabilitado.TabIndex = 41;
            this.cbHabilitado.Text = "Habilitado";
            this.cbHabilitado.UseVisualStyleBackColor = true;
            // 
            // frmAltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 379);
            this.Controls.Add(this.cbHabilitado);
            this.Controls.Add(this.btnQuitarFuncionalidad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombreRol);
            this.Controls.Add(this.cbFuncionalidades);
            this.Controls.Add(this.btnAgregarFuncionalidad);
            this.Controls.Add(this.lvFuncionalidades);
            this.Controls.Add(this.label1);
            this.Name = "frmAltaRol";
            this.Text = "frmModificacionRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombreRol;
        private System.Windows.Forms.ComboBox cbFuncionalidades;
        private System.Windows.Forms.Button btnAgregarFuncionalidad;
        private System.Windows.Forms.ListView lvFuncionalidades;
        private System.Windows.Forms.Button btnQuitarFuncionalidad;
        private System.Windows.Forms.CheckBox cbHabilitado;
    }
}