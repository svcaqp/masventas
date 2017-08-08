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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportesKardex));
            this.ReporteKardexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DemoPracticaKardex = new Capa_de_Presentacion.DemoPracticaKardex();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.date_final = new System.Windows.Forms.DateTimePicker();
            this.date_inicial = new System.Windows.Forms.DateTimePicker();
            this.cbox_productos = new System.Windows.Forms.ComboBox();
            this.listadoProductosDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoPracticaProductosDetalle = new Capa_de_Presentacion.DemoPracticaProductosDetalle();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoPracticaProducto = new Capa_de_Presentacion.DemoPracticaProducto();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.productoTableAdapter = new Capa_de_Presentacion.DemoPracticaProductoTableAdapters.ProductoTableAdapter();
            this.ReporteKardexTableAdapter = new Capa_de_Presentacion.DemoPracticaKardexTableAdapters.ReporteKardexTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listadoProductosDetalleTableAdapter = new Capa_de_Presentacion.DemoPracticaProductosDetalleTableAdapters.ListadoProductosDetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteKardexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemoPracticaKardex)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoProductosDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaProductosDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaProducto)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteKardexBindingSource
            // 
            this.ReporteKardexBindingSource.DataMember = "ReporteKardex";
            this.ReporteKardexBindingSource.DataSource = this.DemoPracticaKardex;
            // 
            // DemoPracticaKardex
            // 
            this.DemoPracticaKardex.DataSetName = "DemoPracticaKardex";
            this.DemoPracticaKardex.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.date_final);
            this.groupBox1.Controls.Add(this.date_inicial);
            this.groupBox1.Controls.Add(this.cbox_productos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox1.Location = new System.Drawing.Point(17, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Filtros ";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(856, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "&Generar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // date_final
            // 
            this.date_final.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_final.Location = new System.Drawing.Point(539, 46);
            this.date_final.Name = "date_final";
            this.date_final.Size = new System.Drawing.Size(289, 22);
            this.date_final.TabIndex = 11;
            // 
            // date_inicial
            // 
            this.date_inicial.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_inicial.Location = new System.Drawing.Point(179, 46);
            this.date_inicial.Name = "date_inicial";
            this.date_inicial.Size = new System.Drawing.Size(289, 22);
            this.date_inicial.TabIndex = 10;
            // 
            // cbox_productos
            // 
            this.cbox_productos.DataSource = this.listadoProductosDetalleBindingSource;
            this.cbox_productos.DisplayMember = "Column1";
            this.cbox_productos.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_productos.FormattingEnabled = true;
            this.cbox_productos.Location = new System.Drawing.Point(129, 16);
            this.cbox_productos.Name = "cbox_productos";
            this.cbox_productos.Size = new System.Drawing.Size(322, 24);
            this.cbox_productos.TabIndex = 7;
            this.cbox_productos.ValueMember = "IdProducto";
            // 
            // listadoProductosDetalleBindingSource
            // 
            this.listadoProductosDetalleBindingSource.DataMember = "ListadoProductosDetalle";
            this.listadoProductosDetalleBindingSource.DataSource = this.demoPracticaProductosDetalle;
            // 
            // demoPracticaProductosDetalle
            // 
            this.demoPracticaProductosDetalle.DataSetName = "DemoPracticaProductosDetalle";
            this.demoPracticaProductosDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(483, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "HASTA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "DESDE: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "FECHA : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTO :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.demoPracticaProducto;
            // 
            // demoPracticaProducto
            // 
            this.demoPracticaProducto.DataSetName = "DemoPracticaProducto";
            this.demoPracticaProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetKardex";
            reportDataSource1.Value = this.ReporteKardexBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_de_Presentacion.ReportKardex.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(17, 167);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(998, 249);
            this.reportViewer1.TabIndex = 2;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteKardexTableAdapter
            // 
            this.ReporteKardexTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lbl_title);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(17, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(998, 52);
            this.panel4.TabIndex = 1013;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(93, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(79, 23);
            this.lbl_title.TabIndex = 1013;
            this.lbl_title.Text = "KARDEX";
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
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(845, 8);
            this.button3.MaximumSize = new System.Drawing.Size(141, 33);
            this.button3.MinimumSize = new System.Drawing.Size(141, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "Regresar ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listadoProductosDetalleTableAdapter
            // 
            this.listadoProductosDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportesKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 435);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportesKardex";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteKardexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemoPracticaKardex)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoProductosDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaProductosDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaProducto)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
       
        private DemoPracticaProducto demoPracticaProducto;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DemoPracticaProductoTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource ReporteKardexBindingSource;
        private DemoPracticaKardex DemoPracticaKardex;
        private DemoPracticaKardexTableAdapters.ReporteKardexTableAdapter ReporteKardexTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private DemoPracticaProductosDetalle demoPracticaProductosDetalle;
        private System.Windows.Forms.BindingSource listadoProductosDetalleBindingSource;
        private DemoPracticaProductosDetalleTableAdapters.ListadoProductosDetalleTableAdapter listadoProductosDetalleTableAdapter;
    }
}