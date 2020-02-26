namespace FrbaHotel.ListadoEstadistico
{
    partial class frmListadoEstadistico
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
            this.cbTrimestre = new System.Windows.Forms.ComboBox();
            this.cbConsulta = new System.Windows.Forms.ComboBox();
            this.cbAnio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvListadoEstadistico = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTrimestre
            // 
            this.cbTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrimestre.FormattingEnabled = true;
            this.cbTrimestre.Location = new System.Drawing.Point(565, 70);
            this.cbTrimestre.Name = "cbTrimestre";
            this.cbTrimestre.Size = new System.Drawing.Size(100, 24);
            this.cbTrimestre.TabIndex = 0;
            // 
            // cbConsulta
            // 
            this.cbConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsulta.FormattingEnabled = true;
            this.cbConsulta.Location = new System.Drawing.Point(28, 113);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(637, 24);
            this.cbConsulta.TabIndex = 1;
            // 
            // cbAnio
            // 
            this.cbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnio.FormattingEnabled = true;
            this.cbAnio.Location = new System.Drawing.Point(347, 70);
            this.cbAnio.Name = "cbAnio";
            this.cbAnio.Size = new System.Drawing.Size(100, 24);
            this.cbAnio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado Estadístico";
            // 
            // lvListadoEstadistico
            // 
            this.lvListadoEstadistico.FullRowSelect = true;
            this.lvListadoEstadistico.GridLines = true;
            this.lvListadoEstadistico.Location = new System.Drawing.Point(28, 200);
            this.lvListadoEstadistico.MultiSelect = false;
            this.lvListadoEstadistico.Name = "lvListadoEstadistico";
            this.lvListadoEstadistico.Size = new System.Drawing.Size(637, 187);
            this.lvListadoEstadistico.TabIndex = 25;
            this.lvListadoEstadistico.UseCompatibleStateImageBehavior = false;
            this.lvListadoEstadistico.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Año:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Trimestre:";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(315, 152);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 27);
            this.btnListar.TabIndex = 28;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 421);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvListadoEstadistico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAnio);
            this.Controls.Add(this.cbConsulta);
            this.Controls.Add(this.cbTrimestre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListadoEstadistico";
            this.Text = "Listado estadistico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTrimestre;
        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.ComboBox cbAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvListadoEstadistico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnListar;
    }
}