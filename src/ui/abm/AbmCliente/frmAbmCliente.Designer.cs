namespace FrbaHotel.AbmCliente
{
    partial class frmABMCliente
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.cbTipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frmModificarCliente = new System.Windows.Forms.Button();
            this.frmBaja = new System.Windows.Forms.Button();
            this.frmAlta = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gD1C2018DataSet = new FrbaHotel.GD1C2018DataSet();
            this.gD1C2018DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.HotelTableAdapter();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.ClienteTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.tbApellidoCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNroDocCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMailCliente = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.cliedoctipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliedocnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieapellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clietelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliedirecalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clielocalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienacionalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliehabilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tipo de identifficacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre:";
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Location = new System.Drawing.Point(89, 282);
            this.tbNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.Size = new System.Drawing.Size(103, 20);
            this.tbNombreCliente.TabIndex = 21;
            // 
            // cbTipoIdentificacion
            // 
            this.cbTipoIdentificacion.FormattingEnabled = true;
            this.cbTipoIdentificacion.Items.AddRange(new object[] {
            "pasaporte",
            "dni"});
            this.cbTipoIdentificacion.Location = new System.Drawing.Point(154, 340);
            this.cbTipoIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoIdentificacion.Name = "cbTipoIdentificacion";
            this.cbTipoIdentificacion.Size = new System.Drawing.Size(38, 21);
            this.cbTipoIdentificacion.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "ABM Cliente";
            // 
            // frmModificarCliente
            // 
            this.frmModificarCliente.Location = new System.Drawing.Point(651, 181);
            this.frmModificarCliente.Name = "frmModificarCliente";
            this.frmModificarCliente.Size = new System.Drawing.Size(109, 26);
            this.frmModificarCliente.TabIndex = 17;
            this.frmModificarCliente.Text = "Modificacion";
            this.frmModificarCliente.UseVisualStyleBackColor = true;
            this.frmModificarCliente.Click += new System.EventHandler(this.frmModificarCliente_Click);
            // 
            // frmBaja
            // 
            this.frmBaja.Location = new System.Drawing.Point(651, 144);
            this.frmBaja.Name = "frmBaja";
            this.frmBaja.Size = new System.Drawing.Size(109, 26);
            this.frmBaja.TabIndex = 16;
            this.frmBaja.Text = "Baja";
            this.frmBaja.UseVisualStyleBackColor = true;
            this.frmBaja.Click += new System.EventHandler(this.frmBaja_Click);
            // 
            // frmAlta
            // 
            this.frmAlta.Location = new System.Drawing.Point(651, 107);
            this.frmAlta.Name = "frmAlta";
            this.frmAlta.Size = new System.Drawing.Size(109, 26);
            this.frmAlta.TabIndex = 15;
            this.frmAlta.Text = "Alta";
            this.frmAlta.UseVisualStyleBackColor = true;
            this.frmAlta.Click += new System.EventHandler(this.frmAlta_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(532, 284);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 34);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // gD1C2018DataSet
            // 
            this.gD1C2018DataSet.DataSetName = "GD1C2018DataSet";
            this.gD1C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gD1C2018DataSetBindingSource
            // 
            this.gD1C2018DataSetBindingSource.DataSource = this.gD1C2018DataSet;
            this.gD1C2018DataSetBindingSource.Position = 0;
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "Hotel";
            this.hotelBindingSource.DataSource = this.gD1C2018DataSetBindingSource;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.gD1C2018DataSetBindingSource;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Apellido:";
            // 
            // tbApellidoCliente
            // 
            this.tbApellidoCliente.Location = new System.Drawing.Point(89, 306);
            this.tbApellidoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbApellidoCliente.Name = "tbApellidoCliente";
            this.tbApellidoCliente.Size = new System.Drawing.Size(103, 20);
            this.tbApellidoCliente.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mail:";
            // 
            // tbNroDocCliente
            // 
            this.tbNroDocCliente.Location = new System.Drawing.Point(304, 277);
            this.tbNroDocCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbNroDocCliente.Name = "tbNroDocCliente";
            this.tbNroDocCliente.Size = new System.Drawing.Size(103, 20);
            this.tbNroDocCliente.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Numero:";
            // 
            // tbMailCliente
            // 
            this.tbMailCliente.Location = new System.Drawing.Point(304, 313);
            this.tbMailCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbMailCliente.Name = "tbMailCliente";
            this.tbMailCliente.Size = new System.Drawing.Size(103, 20);
            this.tbMailCliente.TabIndex = 29;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliedoctipoDataGridViewTextBoxColumn,
            this.cliedocnroDataGridViewTextBoxColumn,
            this.clienombreDataGridViewTextBoxColumn,
            this.clieapellidoDataGridViewTextBoxColumn,
            this.cliemailDataGridViewTextBoxColumn,
            this.clietelefonoDataGridViewTextBoxColumn,
            this.cliedirecalleDataGridViewTextBoxColumn,
            this.clielocalidadDataGridViewTextBoxColumn,
            this.clienacionalidadDataGridViewTextBoxColumn,
            this.cliehabilitadoDataGridViewCheckBoxColumn});
            this.dgvClientes.DataSource = this.clienteBindingSource2;
            this.dgvClientes.Location = new System.Drawing.Point(26, 50);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(606, 202);
            this.dgvClientes.TabIndex = 32;
            // 
            // cliedoctipoDataGridViewTextBoxColumn
            // 
            this.cliedoctipoDataGridViewTextBoxColumn.DataPropertyName = "clie_doc_tipo";
            this.cliedoctipoDataGridViewTextBoxColumn.HeaderText = "Tipo doc";
            this.cliedoctipoDataGridViewTextBoxColumn.Name = "cliedoctipoDataGridViewTextBoxColumn";
            this.cliedoctipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliedocnroDataGridViewTextBoxColumn
            // 
            this.cliedocnroDataGridViewTextBoxColumn.DataPropertyName = "clie_doc_nro";
            this.cliedocnroDataGridViewTextBoxColumn.HeaderText = "Nro doc";
            this.cliedocnroDataGridViewTextBoxColumn.Name = "cliedocnroDataGridViewTextBoxColumn";
            this.cliedocnroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienombreDataGridViewTextBoxColumn
            // 
            this.clienombreDataGridViewTextBoxColumn.DataPropertyName = "clie_nombre";
            this.clienombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.clienombreDataGridViewTextBoxColumn.Name = "clienombreDataGridViewTextBoxColumn";
            this.clienombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clieapellidoDataGridViewTextBoxColumn
            // 
            this.clieapellidoDataGridViewTextBoxColumn.DataPropertyName = "clie_apellido";
            this.clieapellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.clieapellidoDataGridViewTextBoxColumn.Name = "clieapellidoDataGridViewTextBoxColumn";
            this.clieapellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliemailDataGridViewTextBoxColumn
            // 
            this.cliemailDataGridViewTextBoxColumn.DataPropertyName = "clie_mail";
            this.cliemailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.cliemailDataGridViewTextBoxColumn.Name = "cliemailDataGridViewTextBoxColumn";
            this.cliemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clietelefonoDataGridViewTextBoxColumn
            // 
            this.clietelefonoDataGridViewTextBoxColumn.DataPropertyName = "clie_telefono";
            this.clietelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.clietelefonoDataGridViewTextBoxColumn.Name = "clietelefonoDataGridViewTextBoxColumn";
            this.clietelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliedirecalleDataGridViewTextBoxColumn
            // 
            this.cliedirecalleDataGridViewTextBoxColumn.DataPropertyName = "clie_dire_calle";
            this.cliedirecalleDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.cliedirecalleDataGridViewTextBoxColumn.Name = "cliedirecalleDataGridViewTextBoxColumn";
            this.cliedirecalleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clielocalidadDataGridViewTextBoxColumn
            // 
            this.clielocalidadDataGridViewTextBoxColumn.DataPropertyName = "clie_localidad";
            this.clielocalidadDataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.clielocalidadDataGridViewTextBoxColumn.Name = "clielocalidadDataGridViewTextBoxColumn";
            this.clielocalidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienacionalidadDataGridViewTextBoxColumn
            // 
            this.clienacionalidadDataGridViewTextBoxColumn.DataPropertyName = "clie_nacionalidad";
            this.clienacionalidadDataGridViewTextBoxColumn.HeaderText = "Nacionalidad";
            this.clienacionalidadDataGridViewTextBoxColumn.Name = "clienacionalidadDataGridViewTextBoxColumn";
            this.clienacionalidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliehabilitadoDataGridViewCheckBoxColumn
            // 
            this.cliehabilitadoDataGridViewCheckBoxColumn.DataPropertyName = "clie_habilitado";
            this.cliehabilitadoDataGridViewCheckBoxColumn.HeaderText = "Habilitado";
            this.cliehabilitadoDataGridViewCheckBoxColumn.Name = "cliehabilitadoDataGridViewCheckBoxColumn";
            this.cliehabilitadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataMember = "Cliente";
            this.clienteBindingSource2.DataSource = this.gD1C2018DataSetBindingSource;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.gD1C2018DataSetBindingSource;
            // 
            // frmABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 391);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMailCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNroDocCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbApellidoCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombreCliente);
            this.Controls.Add(this.cbTipoIdentificacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmModificarCliente);
            this.Controls.Add(this.frmBaja);
            this.Controls.Add(this.frmAlta);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmABMCliente";
            this.Text = "ABM Cliente";
            this.Load += new System.EventHandler(this.frmABMCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.ComboBox cbTipoIdentificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button frmModificarCliente;
        private System.Windows.Forms.Button frmBaja;
        private System.Windows.Forms.Button frmAlta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource gD1C2018DataSetBindingSource;
        private GD1C2018DataSet gD1C2018DataSet;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private GD1C2018DataSetTableAdapters.HotelTableAdapter hotelTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private GD1C2018DataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbApellidoCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNroDocCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMailCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliedoctipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliedocnroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieapellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clietelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliedirecalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clielocalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienacionalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cliehabilitadoDataGridViewCheckBoxColumn;

    }
}