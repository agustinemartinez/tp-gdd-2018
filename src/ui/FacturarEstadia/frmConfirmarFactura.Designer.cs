namespace FrbaHotel.FacturarEstadia {
    partial class frmConfirmarFactura {
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
            this.lbFrbaHotel = new System.Windows.Forms.Label();
            this.lbFactNro = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lbFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.lvItems = new System.Windows.Forms.ListView();
            this.lbNombreHotel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFrbaHotel
            // 
            this.lbFrbaHotel.AutoSize = true;
            this.lbFrbaHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrbaHotel.Location = new System.Drawing.Point(363, 68);
            this.lbFrbaHotel.Name = "lbFrbaHotel";
            this.lbFrbaHotel.Size = new System.Drawing.Size(100, 20);
            this.lbFrbaHotel.TabIndex = 0;
            this.lbFrbaHotel.Text = "FRBA-Hotel";
            // 
            // lbFactNro
            // 
            this.lbFactNro.AutoSize = true;
            this.lbFactNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFactNro.Location = new System.Drawing.Point(353, 36);
            this.lbFactNro.Name = "lbFactNro";
            this.lbFactNro.Size = new System.Drawing.Size(110, 24);
            this.lbFactNro.TabIndex = 2;
            this.lbFactNro.Text = "0000000000";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(393, 386);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(85, 38);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(26, 68);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(75, 20);
            this.lbFecha.TabIndex = 4;
            this.lbFecha.Text = "00-00-00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total: ";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(88, 347);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(18, 20);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "$";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(26, 98);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(95, 20);
            this.lbCliente.TabIndex = 7;
            this.lbCliente.Text = "Jorge Soria";
            // 
            // lvItems
            // 
            this.lvItems.BackColor = System.Drawing.SystemColors.Menu;
            this.lvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvItems.Location = new System.Drawing.Point(30, 137);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(431, 191);
            this.lvItems.TabIndex = 8;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            // 
            // lbNombreHotel
            // 
            this.lbNombreHotel.AutoSize = true;
            this.lbNombreHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreHotel.Location = new System.Drawing.Point(26, 38);
            this.lbNombreHotel.Name = "lbNombreHotel";
            this.lbNombreHotel.Size = new System.Drawing.Size(108, 20);
            this.lbNombreHotel.TabIndex = 9;
            this.lbNombreHotel.Text = "NombreHotel";
            // 
            // frmConfirmarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 436);
            this.Controls.Add(this.lbNombreHotel);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lbFactNro);
            this.Controls.Add(this.lbFrbaHotel);
            this.Name = "frmConfirmarFactura";
            this.Text = "frmConfirmarFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFrbaHotel;
        private System.Windows.Forms.Label lbFactNro;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.Label lbNombreHotel;
    }
}