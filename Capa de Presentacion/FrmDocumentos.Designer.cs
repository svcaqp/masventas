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
            this.data_facturas = new System.Windows.Forms.DataGridView();
            this.idVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listarDocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoPracticaDocumentos = new Capa_de_Presentacion.DemoPracticaDocumentos();
            this.listarDocumentosTableAdapter = new Capa_de_Presentacion.DemoPracticaDocumentosTableAdapters.ListarDocumentosTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.tipoDocumentoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.fillToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tipoDocumentoToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tipoDocumentoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.data_facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarDocumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaDocumentos)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.fillToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_facturas
            // 
            this.data_facturas.AllowUserToAddRows = false;
            this.data_facturas.AllowUserToDeleteRows = false;
            this.data_facturas.AutoGenerateColumns = false;
            this.data_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_facturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVentaDataGridViewTextBoxColumn,
            this.idEmpleadoDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.nroDocumentoDataGridViewTextBoxColumn,
            this.tipoDocumentoDataGridViewTextBoxColumn,
            this.fechaVentaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.eliminadoDataGridViewTextBoxColumn});
            this.data_facturas.DataSource = this.listarDocumentosBindingSource;
            this.data_facturas.Location = new System.Drawing.Point(12, 53);
            this.data_facturas.Name = "data_facturas";
            this.data_facturas.ReadOnly = true;
            this.data_facturas.Size = new System.Drawing.Size(638, 317);
            this.data_facturas.TabIndex = 3;
            // 
            // idVentaDataGridViewTextBoxColumn
            // 
            this.idVentaDataGridViewTextBoxColumn.DataPropertyName = "IdVenta";
            this.idVentaDataGridViewTextBoxColumn.HeaderText = "IdVenta";
            this.idVentaDataGridViewTextBoxColumn.Name = "idVentaDataGridViewTextBoxColumn";
            this.idVentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "IdEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            this.idEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
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
            // fechaVentaDataGridViewTextBoxColumn
            // 
            this.fechaVentaDataGridViewTextBoxColumn.DataPropertyName = "FechaVenta";
            this.fechaVentaDataGridViewTextBoxColumn.HeaderText = "FechaVenta";
            this.fechaVentaDataGridViewTextBoxColumn.Name = "fechaVentaDataGridViewTextBoxColumn";
            this.fechaVentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eliminadoDataGridViewTextBoxColumn
            // 
            this.eliminadoDataGridViewTextBoxColumn.DataPropertyName = "Eliminado";
            this.eliminadoDataGridViewTextBoxColumn.HeaderText = "Eliminado";
            this.eliminadoDataGridViewTextBoxColumn.Name = "eliminadoDataGridViewTextBoxColumn";
            this.eliminadoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDocumentoToolStripLabel,
            this.toolStripComboBox1});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(681, 25);
            this.fillToolStrip.TabIndex = 4;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // tipoDocumentoToolStripLabel
            // 
            this.tipoDocumentoToolStripLabel.Name = "tipoDocumentoToolStripLabel";
            this.tipoDocumentoToolStripLabel.Size = new System.Drawing.Size(97, 22);
            this.tipoDocumentoToolStripLabel.Text = "TipoDocumento:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Factura",
            "Boleta",
            "Nota"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // fillToolStrip1
            // 
            this.fillToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDocumentoToolStripLabel1,
            this.tipoDocumentoToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip1.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip1.Name = "fillToolStrip1";
            this.fillToolStrip1.Size = new System.Drawing.Size(681, 25);
            this.fillToolStrip1.TabIndex = 5;
            this.fillToolStrip1.Text = "fillToolStrip1";
            // 
            // tipoDocumentoToolStripLabel1
            // 
            this.tipoDocumentoToolStripLabel1.Name = "tipoDocumentoToolStripLabel1";
            this.tipoDocumentoToolStripLabel1.Size = new System.Drawing.Size(97, 15);
            this.tipoDocumentoToolStripLabel1.Text = "TipoDocumento:";
            // 
            // tipoDocumentoToolStripTextBox
            // 
            this.tipoDocumentoToolStripTextBox.Name = "tipoDocumentoToolStripTextBox";
            this.tipoDocumentoToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 19);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // FrmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 446);
            this.Controls.Add(this.fillToolStrip1);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.data_facturas);
            this.Name = "FrmDocumentos";
            this.Text = "FrmDocumentos";
            ((System.ComponentModel.ISupportInitialize)(this.data_facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarDocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaDocumentos)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.fillToolStrip1.ResumeLayout(false);
            this.fillToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_facturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eliminadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listarDocumentosBindingSource;
        private DemoPracticaDocumentos demoPracticaDocumentos;
        private DemoPracticaDocumentosTableAdapters.ListarDocumentosTableAdapter listarDocumentosTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel tipoDocumentoToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStrip fillToolStrip1;
        private System.Windows.Forms.ToolStripLabel tipoDocumentoToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tipoDocumentoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
    }
}