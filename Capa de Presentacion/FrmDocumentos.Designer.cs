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
            this.demoPracticaCompras = new Capa_de_Presentacion.DemoPracticaCompras();
            this.listarComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listarComprasTableAdapter = new Capa_de_Presentacion.DemoPracticaComprasTableAdapters.ListarComprasTableAdapter();
            this.cbox_Documentos = new System.Windows.Forms.ComboBox();
            this.data_pagos = new System.Windows.Forms.DataGridView();
            this.demoPracticaPagos = new Capa_de_Presentacion.DemoPracticaPagos();
            this.listarPagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listarPagosTableAdapter = new Capa_de_Presentacion.DemoPracticaPagosTableAdapters.ListarPagosTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_documentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarDocumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaDocumentos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_compras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_pagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarPagosBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.data_documentos.Location = new System.Drawing.Point(9, 117);
            this.data_documentos.Name = "data_documentos";
            this.data_documentos.ReadOnly = true;
            this.data_documentos.Size = new System.Drawing.Size(541, 317);
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
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Anular
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Anular";
            this.Anular.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.btn_Buscar.Location = new System.Drawing.Point(171, 65);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(103, 23);
            this.btn_Buscar.TabIndex = 6;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Visible = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cbox_Tipo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(562, 50);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 47);
            this.toolStripLabel1.Text = "Tipo Documento:";
            // 
            // cbox_Tipo
            // 
            this.cbox_Tipo.Items.AddRange(new object[] {
            "Ventas",
            "Compras",
            "Egresos"});
            this.cbox_Tipo.Name = "cbox_Tipo";
            this.cbox_Tipo.Size = new System.Drawing.Size(120, 50);
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
            this.data_compras.Location = new System.Drawing.Point(9, 117);
            this.data_compras.Name = "data_compras";
            this.data_compras.ReadOnly = true;
            this.data_compras.Size = new System.Drawing.Size(541, 317);
            this.data_compras.TabIndex = 8;
            this.data_compras.Visible = false;
            this.data_compras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_facturas_CellContentClick);
            // 
            // demoPracticaCompras
            // 
            this.demoPracticaCompras.DataSetName = "DemoPracticaCompras";
            this.demoPracticaCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listarComprasBindingSource
            // 
            this.listarComprasBindingSource.DataMember = "ListarCompras";
            this.listarComprasBindingSource.DataSource = this.demoPracticaCompras;
            // 
            // listarComprasTableAdapter
            // 
            this.listarComprasTableAdapter.ClearBeforeFill = true;
            // 
            // cbox_Documentos
            // 
            this.cbox_Documentos.FormattingEnabled = true;
            this.cbox_Documentos.Items.AddRange(new object[] {
            "Factura",
            "Boleta",
            "Nota"});
            this.cbox_Documentos.Location = new System.Drawing.Point(9, 65);
            this.cbox_Documentos.Name = "cbox_Documentos";
            this.cbox_Documentos.Size = new System.Drawing.Size(147, 21);
            this.cbox_Documentos.TabIndex = 9;
            this.cbox_Documentos.Text = "Selecciona Documento";
            this.cbox_Documentos.Visible = false;
            // 
            // data_pagos
            // 
            this.data_pagos.AllowUserToAddRows = false;
            this.data_pagos.AllowUserToDeleteRows = false;
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
            this.data_pagos.Location = new System.Drawing.Point(9, 117);
            this.data_pagos.Name = "data_pagos";
            this.data_pagos.ReadOnly = true;
            this.data_pagos.Size = new System.Drawing.Size(541, 317);
            this.data_pagos.TabIndex = 10;
            this.data_pagos.Visible = false;
            this.data_pagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_facturas_CellContentClick);
            // 
            // demoPracticaPagos
            // 
            this.demoPracticaPagos.DataSetName = "DemoPracticaPagos";
            this.demoPracticaPagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listarPagosBindingSource
            // 
            this.listarPagosBindingSource.DataMember = "ListarPagos";
            this.listarPagosBindingSource.DataSource = this.demoPracticaPagos;
            // 
            // listarPagosTableAdapter
            // 
            this.listarPagosTableAdapter.ClearBeforeFill = true;
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
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Anular";
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewButtonColumn1.HeaderText = "Anular";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Anular";
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
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Anular";
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewButtonColumn2.HeaderText = "Anular";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "Anular";
            // 
            // FrmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 446);
            this.Controls.Add(this.data_pagos);
            this.Controls.Add(this.cbox_Documentos);
            this.Controls.Add(this.data_compras);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.data_documentos);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "FrmDocumentos";
            this.Text = "FrmDocumentos";
            this.Load += new System.EventHandler(this.FrmDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_documentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarDocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaDocumentos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_compras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_pagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarPagosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_documentos;
        private System.Windows.Forms.BindingSource listarDocumentosBindingSource;
        private DemoPracticaDocumentos demoPracticaDocumentos;
        private DemoPracticaDocumentosTableAdapters.ListarDocumentosTableAdapter listarDocumentosTableAdapter;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Anular;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}