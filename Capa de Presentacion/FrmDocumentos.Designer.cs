namespace Capa_de_Presentacion
{
    partial class FrmDocumentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocumentos));
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.data_documentos = new System.Windows.Forms.DataGridView();
            this.idVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anular = new System.Windows.Forms.DataGridViewButtonColumn();
            this.listarDocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoPracticaDocumentos = new Capa_de_Presentacion.DemoPracticaDocumentos();
            this.listarDocumentosTableAdapter = new Capa_de_Presentacion.DemoPracticaDocumentosTableAdapters.ListarDocumentosTableAdapter();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbox_Tipo = new System.Windows.Forms.ToolStripComboBox();
            this.data_compras = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.listarComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoPracticaCompras = new Capa_de_Presentacion.DemoPracticaCompras();
            this.cbox_Documentos = new System.Windows.Forms.ComboBox();
            this.data_pagos = new System.Windows.Forms.DataGridView();
            this.idPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.listarPagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoPracticaPagos = new Capa_de_Presentacion.DemoPracticaPagos();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listarPagosTableAdapter = new Capa_de_Presentacion.DemoPracticaPagosTableAdapters.ListarPagosTableAdapter();
            this.listarComprasTableAdapter = new Capa_de_Presentacion.DemoPracticaComprasTableAdapters.ListarComprasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.data_documentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarDocumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaDocumentos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_compras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_pagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarPagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaPagos)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensaje.Location = new System.Drawing.Point(302, 324);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(442, 50);
            this.lbl_mensaje.TabIndex = 1017;
            this.lbl_mensaje.Text = "Por favor, \r\nSeleccionar el tipo de Documento a visualizar.";
            this.lbl_mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // data_documentos
            // 
            this.data_documentos.AllowUserToAddRows = false;
            this.data_documentos.AllowUserToDeleteRows = false;
            this.data_documentos.AutoGenerateColumns = false;
            this.data_documentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_documentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVentaDataGridViewTextBoxColumn,
            this.fechaVentaDataGridViewTextBoxColumn,
            this.nroDocumentoDataGridViewTextBoxColumn,
            this.tipoDocumentoDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.Anular});
            this.data_documentos.DataSource = this.listarDocumentosBindingSource;
            this.data_documentos.Location = new System.Drawing.Point(26, 178);
            this.data_documentos.Name = "data_documentos";
            this.data_documentos.ReadOnly = true;
            this.data_documentos.Size = new System.Drawing.Size(986, 476);
            this.data_documentos.TabIndex = 3;
            this.data_documentos.Visible = false;
            this.data_documentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_facturas_CellContentClick);
            // 
            // idVentaDataGridViewTextBoxColumn
            // 
            this.idVentaDataGridViewTextBoxColumn.DataPropertyName = "IdVenta";
            this.idVentaDataGridViewTextBoxColumn.HeaderText = "IdVenta";
            this.idVentaDataGridViewTextBoxColumn.Name = "idVentaDataGridViewTextBoxColumn";
            this.idVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaVentaDataGridViewTextBoxColumn
            // 
            this.fechaVentaDataGridViewTextBoxColumn.DataPropertyName = "FechaVenta";
            this.fechaVentaDataGridViewTextBoxColumn.FillWeight = 200F;
            this.fechaVentaDataGridViewTextBoxColumn.HeaderText = "FechaVenta";
            this.fechaVentaDataGridViewTextBoxColumn.Name = "fechaVentaDataGridViewTextBoxColumn";
            this.fechaVentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nroDocumentoDataGridViewTextBoxColumn
            // 
            this.nroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NroDocumento";
            this.nroDocumentoDataGridViewTextBoxColumn.HeaderText = "NroDocumento";
            this.nroDocumentoDataGridViewTextBoxColumn.Name = "nroDocumentoDataGridViewTextBoxColumn";
            this.nroDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDocumentoDataGridViewTextBoxColumn
            // 
            this.tipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "TipoDocumento";
            this.tipoDocumentoDataGridViewTextBoxColumn.HeaderText = "TipoDocumento";
            this.tipoDocumentoDataGridViewTextBoxColumn.Name = "tipoDocumentoDataGridViewTextBoxColumn";
            this.tipoDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            dataGridViewCellStyle1.Format = "N1";
            dataGridViewCellStyle1.NullValue = null;
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Anular
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Anular";
            this.Anular.DefaultCellStyle = dataGridViewCellStyle2;
            this.Anular.HeaderText = "Anular";
            this.Anular.Name = "Anular";
            this.Anular.ReadOnly = true;
            this.Anular.Text = "Anular";
            // 
            // listarDocumentosBindingSource
            // 
            this.listarDocumentosBindingSource.DataMember = "ListarDocumentos";
            this.listarDocumentosBindingSource.DataSource = this.demoPracticaDocumentos;
            // 
            // demoPracticaDocumentos
            // 
            this.demoPracticaDocumentos.DataSetName = "DemoPracticaDocumentos";
            this.demoPracticaDocumentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listarDocumentosTableAdapter
            // 
            this.listarDocumentosTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(580, 87);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(98, 35);
            this.btn_Buscar.TabIndex = 6;
            this.btn_Buscar.Text = "&Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Visible = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cbox_Tipo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1038, 175);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(177, 172);
            this.toolStripLabel1.Text = "CATEGORIA DE DOCUMENTO: ";
            // 
            // cbox_Tipo
            // 
            this.cbox_Tipo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Tipo.Items.AddRange(new object[] {
            "Ventas",
            "Compras",
            "Egresos"});
            this.cbox_Tipo.Name = "cbox_Tipo";
            this.cbox_Tipo.Size = new System.Drawing.Size(220, 175);
            this.cbox_Tipo.Text = "Seleccionar";
            this.cbox_Tipo.SelectedIndexChanged += new System.EventHandler(this.cbox_Tipo_SelectedIndexChanged);
            // 
            // data_compras
            // 
            this.data_compras.AllowUserToAddRows = false;
            this.data_compras.AllowUserToDeleteRows = false;
            this.data_compras.AutoGenerateColumns = false;
            this.data_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_compras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.FechaRegistro,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewButtonColumn1});
            this.data_compras.DataSource = this.listarComprasBindingSource;
            this.data_compras.Location = new System.Drawing.Point(26, 178);
            this.data_compras.Name = "data_compras";
            this.data_compras.ReadOnly = true;
            this.data_compras.Size = new System.Drawing.Size(986, 476);
            this.data_compras.TabIndex = 8;
            this.data_compras.Visible = false;
            this.data_compras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_facturas_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "IdCompra";
            this.Column1.FillWeight = 1F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 2;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Visible = false;
            this.Column1.Width = 2;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.DataPropertyName = "FechaRegistro";
            this.FechaRegistro.HeaderText = "FechaRegistro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TipoDocumento";
            this.dataGridViewTextBoxColumn4.HeaderText = "TipoDocumento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NroDocumento";
            this.dataGridViewTextBoxColumn3.HeaderText = "NroDocumento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Total";
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "Anular";
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewButtonColumn1.HeaderText = "Anular";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Anular";
            // 
            // listarComprasBindingSource
            // 
            this.listarComprasBindingSource.DataMember = "ListarCompras";
            this.listarComprasBindingSource.DataSource = this.demoPracticaCompras;
            // 
            // demoPracticaCompras
            // 
            this.demoPracticaCompras.DataSetName = "DemoPracticaCompras";
            this.demoPracticaCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbox_Documentos
            // 
            this.cbox_Documentos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Documentos.FormattingEnabled = true;
            this.cbox_Documentos.Items.AddRange(new object[] {
            "Factura",
            "Boleta",
            "Nota"});
            this.cbox_Documentos.Location = new System.Drawing.Point(12, 109);
            this.cbox_Documentos.Name = "cbox_Documentos";
            this.cbox_Documentos.Size = new System.Drawing.Size(522, 22);
            this.cbox_Documentos.TabIndex = 9;
            this.cbox_Documentos.Text = "Selecciona Documento";
            this.cbox_Documentos.Visible = false;
            // 
            // data_pagos
            // 
            this.data_pagos.AllowUserToAddRows = false;
            this.data_pagos.AllowUserToDeleteRows = false;
            this.data_pagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_pagos.AutoGenerateColumns = false;
            this.data_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_pagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPagoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.dataGridViewButtonColumn2});
            this.data_pagos.DataSource = this.listarPagosBindingSource;
            this.data_pagos.Location = new System.Drawing.Point(26, 178);
            this.data_pagos.Name = "data_pagos";
            this.data_pagos.ReadOnly = true;
            this.data_pagos.Size = new System.Drawing.Size(986, 453);
            this.data_pagos.TabIndex = 10;
            this.data_pagos.Visible = false;
            this.data_pagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_facturas_CellContentClick);
            // 
            // idPagoDataGridViewTextBoxColumn
            // 
            this.idPagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idPagoDataGridViewTextBoxColumn.DataPropertyName = "IdPago";
            this.idPagoDataGridViewTextBoxColumn.FillWeight = 5F;
            this.idPagoDataGridViewTextBoxColumn.HeaderText = "IdPago";
            this.idPagoDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.idPagoDataGridViewTextBoxColumn.Name = "idPagoDataGridViewTextBoxColumn";
            this.idPagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPagoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idPagoDataGridViewTextBoxColumn.Visible = false;
            this.idPagoDataGridViewTextBoxColumn.Width = 2;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.MaxInputLength = 5;
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            dataGridViewCellStyle5.Format = "N1";
            dataGridViewCellStyle5.NullValue = null;
            this.montoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = "Anular";
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewButtonColumn2.HeaderText = "Anular";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "Anular";
            // 
            // listarPagosBindingSource
            // 
            this.listarPagosBindingSource.DataMember = "ListarPagos";
            this.listarPagosBindingSource.DataSource = this.demoPracticaPagos;
            // 
            // demoPracticaPagos
            // 
            this.demoPracticaPagos.DataSetName = "DemoPracticaPagos";
            this.demoPracticaPagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lbl_title);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(17, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1005, 52);
            this.panel4.TabIndex = 1016;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(93, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(133, 23);
            this.lbl_title.TabIndex = 1013;
            this.lbl_title.Text = "DOCUMENTOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(852, 8);
            this.button1.MaximumSize = new System.Drawing.Size(141, 33);
            this.button1.MinimumSize = new System.Drawing.Size(141, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Regresar ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listarPagosTableAdapter
            // 
            this.listarPagosTableAdapter.ClearBeforeFill = true;
            // 
            // listarComprasTableAdapter
            // 
            this.listarComprasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 676);
            this.ControlBox = false;
            this.Controls.Add(this.cbox_Documentos);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.data_pagos);
            this.Controls.Add(this.data_compras);
            this.Controls.Add(this.data_documentos);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1054, 715);
            this.MinimumSize = new System.Drawing.Size(1054, 715);
            this.Name = "FrmDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_documentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarDocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaDocumentos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_compras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_pagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarPagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaPagos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_documentos;
        private System.Windows.Forms.BindingSource listarDocumentosBindingSource;
        private DemoPracticaDocumentos demoPracticaDocumentos;
        private DemoPracticaDocumentosTableAdapters.ListarDocumentosTableAdapter listarDocumentosTableAdapter;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbox_Tipo;
        private System.Windows.Forms.DataGridView data_compras;
        private DemoPracticaCompras demoPracticaCompras;
        private System.Windows.Forms.BindingSource listarComprasBindingSource;
        private DemoPracticaComprasTableAdapters.ListarComprasTableAdapter listarComprasTableAdapter;
        private System.Windows.Forms.ComboBox cbox_Documentos;
        private System.Windows.Forms.DataGridView data_pagos;
        private DemoPracticaPagos demoPracticaPagos;
        private System.Windows.Forms.BindingSource listarPagosBindingSource;
        private DemoPracticaPagosTableAdapters.ListarPagosTableAdapter listarPagosTableAdapter;

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Anular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        

    }
}