namespace Capa_de_Presentacion
{
    partial class FrmReportesKardex
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.date_final = new System.Windows.Forms.DateTimePicker();
            this.date_inicial = new System.Windows.Forms.DateTimePicker();
            this.cbox_productos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DemoPracticaKardex = new Capa_de_Presentacion.DemoPracticaKardex();
            this.ReporteKardexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteKardexTableAdapter = new Capa_de_Presentacion.DemoPracticaKardexTableAdapters.ReporteKardexTableAdapter();
            this.demoPracticaProducto = new Capa_de_Presentacion.DemoPracticaProducto();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Capa_de_Presentacion.DemoPracticaProductoTableAdapters.ProductoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DemoPracticaKardex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteKardexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.date_final);
            this.groupBox1.Controls.Add(this.date_inicial);
            this.groupBox1.Controls.Add(this.cbox_productos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Filtros ";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(764, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 42);
            this.button2.TabIndex = 13;
            this.button2.Text = "&Generar Reporte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // date_final
            // 
            this.date_final.Location = new System.Drawing.Point(484, 57);
            this.date_final.Name = "date_final";
            this.date_final.Size = new System.Drawing.Size(246, 20);
            this.date_final.TabIndex = 11;
            // 
            // date_inicial
            // 
            this.date_inicial.Location = new System.Drawing.Point(162, 57);
            this.date_inicial.Name = "date_inicial";
            this.date_inicial.Size = new System.Drawing.Size(246, 20);
            this.date_inicial.TabIndex = 10;
            // 
            // cbox_productos
            // 
            this.cbox_productos.DataSource = this.productoBindingSource;
            this.cbox_productos.DisplayMember = "Marca";
            this.cbox_productos.FormattingEnabled = true;
            this.cbox_productos.Location = new System.Drawing.Point(129, 20);
            this.cbox_productos.Name = "cbox_productos";
            this.cbox_productos.Size = new System.Drawing.Size(322, 21);
            this.cbox_productos.TabIndex = 7;
            this.cbox_productos.ValueMember = "IdProducto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "HASTA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DE: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FECHA : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTO :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteKardexBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_de_Presentacion.ReportKardex.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 117);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(967, 327);
            this.reportViewer1.TabIndex = 2;
            // 
            // DemoPracticaKardex
            // 
            this.DemoPracticaKardex.DataSetName = "DemoPracticaKardex";
            this.DemoPracticaKardex.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteKardexBindingSource
            // 
            this.ReporteKardexBindingSource.DataMember = "ReporteKardex";
            this.ReporteKardexBindingSource.DataSource = this.DemoPracticaKardex;
            // 
            // ReporteKardexTableAdapter
            // 
            this.ReporteKardexTableAdapter.ClearBeforeFill = true;
            // 
            // demoPracticaProducto
            // 
            this.demoPracticaProducto.DataSetName = "DemoPracticaProducto";
            this.demoPracticaProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.demoPracticaProducto;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportesKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 456);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "FrmReportesKardex";
            this.Text = "Reportes de Ventas";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DemoPracticaKardex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteKardexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker date_final;
        private System.Windows.Forms.DateTimePicker date_inicial;
        private System.Windows.Forms.ComboBox cbox_productos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DemoPracticaClientes demoPracticaClientes;
        private DemoPracticaClientesTableAdapters.ListarClientesTableAdapter listarClientesTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource ReporteKardexBindingSource;
        private DemoPracticaKardex DemoPracticaKardex;
        private DemoPracticaKardexTableAdapters.ReporteKardexTableAdapter ReporteKardexTableAdapter;
        private DemoPracticaProducto demoPracticaProducto;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DemoPracticaProductoTableAdapters.ProductoTableAdapter productoTableAdapter;
    }
}