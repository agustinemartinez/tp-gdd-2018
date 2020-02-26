namespace FrbaHotel.FacturarEstadia
{
    partial class frmFacturarEstadia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrarConsumible = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lvConsumibles = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoverConsumible = new System.Windows.Forms.Button();
            this.cbConsumible = new System.Windows.Forms.ComboBox();
            this.cbFormaDePago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNroReserva = new System.Windows.Forms.TextBox();
            this.btnFacturarEstadia = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNroTarjeta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Consumibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consumible:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // btnRegistrarConsumible
            // 
            this.btnRegistrarConsumible.Location = new System.Drawing.Point(98, 233);
            this.btnRegistrarConsumible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarConsumible.Name = "btnRegistrarConsumible";
            this.btnRegistrarConsumible.Size = new System.Drawing.Size(81, 30);
            this.btnRegistrarConsumible.TabIndex = 5;
            this.btnRegistrarConsumible.Text = "Agregar";
            this.btnRegistrarConsumible.UseVisualStyleBackColor = true;
            this.btnRegistrarConsumible.Click += new System.EventHandler(this.btnRegistrarConsumible_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(125, 193);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(54, 22);
            this.tbCantidad.TabIndex = 8;
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidad_KeyPress);
            // 
            // lvConsumibles
            // 
            this.lvConsumibles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Descripcion,
            this.Cantidad,
            this.Precio});
            this.lvConsumibles.FullRowSelect = true;
            this.lvConsumibles.GridLines = true;
            this.lvConsumibles.Location = new System.Drawing.Point(266, 162);
            this.lvConsumibles.Margin = new System.Windows.Forms.Padding(4);
            this.lvConsumibles.Name = "lvConsumibles";
            this.lvConsumibles.Size = new System.Drawing.Size(341, 110);
            this.lvConsumibles.TabIndex = 9;
            this.lvConsumibles.UseCompatibleStateImageBehavior = false;
            this.lvConsumibles.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Codigo";
            this.Codigo.Width = 67;
            // 
            // Descripcion
            // 
            this.Descripcion.DisplayIndex = 2;
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Width = 81;
            // 
            // Cantidad
            // 
            this.Cantidad.DisplayIndex = 3;
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 69;
            // 
            // Precio
            // 
            this.Precio.DisplayIndex = 1;
            this.Precio.Text = "Precio";
            // 
            // btnRemoverConsumible
            // 
            this.btnRemoverConsumible.Location = new System.Drawing.Point(615, 196);
            this.btnRemoverConsumible.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoverConsumible.Name = "btnRemoverConsumible";
            this.btnRemoverConsumible.Size = new System.Drawing.Size(81, 31);
            this.btnRemoverConsumible.TabIndex = 10;
            this.btnRemoverConsumible.Text = "Remover";
            this.btnRemoverConsumible.UseVisualStyleBackColor = true;
            this.btnRemoverConsumible.Click += new System.EventHandler(this.btnRemoverConsumible_Click);
            // 
            // cbConsumible
            // 
            this.cbConsumible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsumible.FormattingEnabled = true;
            this.cbConsumible.Location = new System.Drawing.Point(125, 162);
            this.cbConsumible.Name = "cbConsumible";
            this.cbConsumible.Size = new System.Drawing.Size(121, 24);
            this.cbConsumible.TabIndex = 12;
            // 
            // cbFormaDePago
            // 
            this.cbFormaDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaDePago.FormattingEnabled = true;
            this.cbFormaDePago.Items.AddRange(new object[] {
            "Efectivo",
            "Credito",
            "Debito"});
            this.cbFormaDePago.Location = new System.Drawing.Point(377, 67);
            this.cbFormaDePago.Name = "cbFormaDePago";
            this.cbFormaDePago.Size = new System.Drawing.Size(95, 24);
            this.cbFormaDePago.TabIndex = 16;
            this.cbFormaDePago.SelectedIndexChanged += new System.EventHandler(this.cbFormaDePago_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ingrese número de reserva";
            // 
            // tbNroReserva
            // 
            this.tbNroReserva.Location = new System.Drawing.Point(106, 67);
            this.tbNroReserva.Margin = new System.Windows.Forms.Padding(4);
            this.tbNroReserva.MaxLength = 16;
            this.tbNroReserva.Name = "tbNroReserva";
            this.tbNroReserva.Size = new System.Drawing.Size(140, 22);
            this.tbNroReserva.TabIndex = 14;
            this.tbNroReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroReserva_KeyPress);
            // 
            // btnFacturarEstadia
            // 
            this.btnFacturarEstadia.Location = new System.Drawing.Point(578, 309);
            this.btnFacturarEstadia.Margin = new System.Windows.Forms.Padding(4);
            this.btnFacturarEstadia.Name = "btnFacturarEstadia";
            this.btnFacturarEstadia.Size = new System.Drawing.Size(132, 37);
            this.btnFacturarEstadia.TabIndex = 13;
            this.btnFacturarEstadia.Text = "Facturar estadia";
            this.btnFacturarEstadia.UseVisualStyleBackColor = true;
            this.btnFacturarEstadia.Click += new System.EventHandler(this.btnFacturarEstadia_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Forma de pago:";
            // 
            // tbNroTarjeta
            // 
            this.tbNroTarjeta.Location = new System.Drawing.Point(487, 68);
            this.tbNroTarjeta.Name = "tbNroTarjeta";
            this.tbNroTarjeta.ReadOnly = true;
            this.tbNroTarjeta.Size = new System.Drawing.Size(120, 22);
            this.tbNroTarjeta.TabIndex = 18;
            this.tbNroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroTarjeta_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Reserva:";
            // 
            // frmFacturarEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 359);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNroTarjeta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFormaDePago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNroReserva);
            this.Controls.Add(this.btnFacturarEstadia);
            this.Controls.Add(this.cbConsumible);
            this.Controls.Add(this.btnRemoverConsumible);
            this.Controls.Add(this.lvConsumibles);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.btnRegistrarConsumible);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFacturarEstadia";
            this.Text = "Facturar Estadia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrarConsumible;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.ListView lvConsumibles;
        private System.Windows.Forms.Button btnRemoverConsumible;
        public System.Windows.Forms.ColumnHeader Codigo;
        public System.Windows.Forms.ColumnHeader Precio;
        public System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ComboBox cbConsumible;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ComboBox cbFormaDePago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNroReserva;
        private System.Windows.Forms.Button btnFacturarEstadia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNroTarjeta;
        private System.Windows.Forms.Label label6;
    }
}