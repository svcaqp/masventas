namespace Capa_de_Presentacion
{
    partial class FrmReportesVentas
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
            this.ReporteVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DemoPracticaReporteVentas = new Capa_de_Presentacion.DemoPracticaReporteVentas();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_documentos = new System.Windows.Forms.CheckBox();
            this.check_clientes = new System.Windows.Forms.CheckBox();
            this.check_usuarios = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.date_final = new System.Windows.Forms.DateTimePicker();
            this.date_inicial = new System.Windows.Forms.DateTimePicker();
            this.cbox_cliente = new System.Windows.Forms.ComboBox();
            this.listarClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoPracticaClientes1 = new Capa_de_Presentacion.DemoPracticaClientes();
            this.cbox_documentos = new System.Windows.Forms.ComboBox();
            this.cbox_empleado = new System.Windows.Forms.ComboBox();
            this.listarEmpleadosCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoPracticaEmpleados = new Capa_de_Presentacion.DemoPracticaEmpleados();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listarEmpleadosCompletoTableAdapter = new Capa_de_Presentacion.DemoPracticaEmpleadosTableAdapters.ListarEmpleadosCompletoTableAdapter();
            this.listarClientesTableAdapter1 = new Capa_de_Presentacion.DemoPracticaClientesTableAdapters.ListarClientesTableAdapter();
            this.DataSetReporteProductos = new Capa_de_Presentacion.DataSetReporteProductos();
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteTableAdapter = new Capa_de_Presentacion.DataSetReporteProductosTableAdapters.ClienteTableAdapter();
            this.ReporteVentasTableAdapter = new Capa_de_Presentacion.DemoPracticaReporteVentasTableAdapters.ReporteVentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemoPracticaReporteVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listarClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaClientes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarEmpleadosCompletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteVentasBindingSource
            // 
            this.ReporteVentasBindingSource.DataMember = "ReporteVentas";
            this.ReporteVentasBindingSource.DataSource = this.DemoPracticaReporteVentas;
            // 
            // DemoPracticaReporteVentas
            // 
            this.DemoPracticaReporteVentas.DataSetName = "DemoPracticaReporteVentas";
            this.DemoPracticaReporteVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check_documentos);
            this.groupBox1.Controls.Add(this.check_clientes);
            this.groupBox1.Controls.Add(this.check_usuarios);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.date_final);
            this.groupBox1.Controls.Add(this.date_inicial);
            this.groupBox1.Controls.Add(this.cbox_cliente);
            this.groupBox1.Controls.Add(this.cbox_documentos);
            this.groupBox1.Controls.Add(this.cbox_empleado);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Filtros ";
            // 
            // check_documentos
            // 
            this.check_documentos.AutoSize = true;
            this.check_documentos.Location = new System.Drawing.Point(482, 47);
            this.check_documentos.Name = "check_documentos";
            this.check_documentos.Size = new System.Drawing.Size(133, 17);
            this.check_documentos.TabIndex = 16;
            this.check_documentos.Text = "Todos los documentos";
            this.check_documentos.UseVisualStyleBackColor = true;
            this.check_documentos.CheckedChanged += new System.EventHandler(this.check_documentos_CheckedChanged);
            // 
            // check_clientes
            // 
            this.check_clientes.AutoSize = true;
            this.check_clientes.Location = new System.Drawing.Point(482, 77);
            this.check_clientes.Name = "check_clientes";
            this.check_clientes.Size = new System.Drawing.Size(111, 17);
            this.check_clientes.TabIndex = 15;
            this.check_clientes.Text = "Todos los clientes";
            this.check_clientes.UseVisualStyleBackColor = true;
            this.check_clientes.CheckedChanged += new System.EventHandler(this.check_clientes_CheckedChanged);
            // 
            // check_usuarios
            // 
            this.check_usuarios.AutoSize = true;
            this.check_usuarios.Location = new System.Drawing.Point(482, 18);
            this.check_usuarios.Name = "check_usuarios";
            this.check_usuarios.Size = new System.Drawing.Size(114, 17);
            this.check_usuarios.TabIndex = 14;
            this.check_usuarios.Text = "Todos los usuarios";
            this.check_usuarios.UseVisualStyleBackColor = true;
            this.check_usuarios.CheckedChanged += new System.EventHandler(this.cbox_todos_CheckedChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(755, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 42);
            this.button2.TabIndex = 13;
            this.button2.Text = "&Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // date_final
            // 
            this.date_final.Location = new System.Drawing.Point(482, 100);
            this.date_final.Name = "date_final";
            this.date_final.Size = new System.Drawing.Size(246, 20);
            this.date_final.TabIndex = 11;
            // 
            // date_inicial
            // 
            this.date_inicial.Location = new System.Drawing.Point(160, 100);
            this.date_inicial.Name = "date_inicial";
            this.date_inicial.Size = new System.Drawing.Size(246, 20);
            this.date_inicial.TabIndex = 10;
            // 
            // cbox_cliente
            // 
            this.cbox_cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listarClientesBindingSource, "IdCliente", true));
            this.cbox_cliente.DataSource = this.listarClientesBindingSource;
            this.cbox_cliente.DisplayMember = "Nombres";
            this.cbox_cliente.FormattingEnabled = true;
            this.cbox_cliente.Location = new System.Drawing.Point(129, 73);
            this.cbox_cliente.Name = "cbox_cliente";
            this.cbox_cliente.Size = new System.Drawing.Size(322, 21);
            this.cbox_cliente.TabIndex = 9;
            this.cbox_cliente.ValueMember = "IdCliente";
            this.cbox_cliente.SelectedIndexChanged += new System.EventHandler(this.cbox_cliente_SelectedIndexChanged);
            // 
            // listarClientesBindingSource
            // 
            this.listarClientesBindingSource.DataMember = "ListarClientes";
            this.listarClientesBindingSource.DataSource = this.demoPracticaClientes1;
            // 
            // demoPracticaClientes1
            // 
            this.demoPracticaClientes1.DataSetName = "DemoPracticaClientes";
            this.demoPracticaClientes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbox_documentos
            // 
            this.cbox_documentos.FormattingEnabled = true;
            this.cbox_documentos.Items.AddRange(new object[] {
            "Factura",
            "Boleta",
            "Nota de venta"});
            this.cbox_documentos.Location = new System.Drawing.Point(129, 47);
            this.cbox_documentos.Name = "cbox_documentos";
            this.cbox_documentos.Size = new System.Drawing.Size(322, 21);
            this.cbox_documentos.TabIndex = 8;
            this.cbox_documentos.SelectedIndexChanged += new System.EventHandler(this.cbox_documentos_SelectedIndexChanged);
            // 
            // cbox_empleado
            // 
            this.cbox_empleado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listarEmpleadosCompletoBindingSource, "IdEmpleado", true));
            this.cbox_empleado.DataSource = this.listarEmpleadosCompletoBindingSource;
            this.cbox_empleado.DisplayMember = "Column1";
            this.cbox_empleado.FormattingEnabled = true;
            this.cbox_empleado.Location = new System.Drawing.Point(129, 20);
            this.cbox_empleado.Name = "cbox_empleado";
            this.cbox_empleado.Size = new System.Drawing.Size(322, 21);
            this.cbox_empleado.TabIndex = 7;
            this.cbox_empleado.ValueMember = "IdEmpleado";
            this.cbox_empleado.SelectedIndexChanged += new System.EventHandler(this.cbox_empleado_SelectedIndexChanged);
            // 
            // listarEmpleadosCompletoBindingSource
            // 
            this.listarEmpleadosCompletoBindingSource.DataMember = "ListarEmpleadosCompleto";
            this.listarEmpleadosCompletoBindingSource.DataSource = this.demoPracticaEmpleados;
            // 
            // demoPracticaEmpleados
            // 
            this.demoPracticaEmpleados.DataSetName = "DemoPracticaEmpleados";
            this.demoPracticaEmpleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "HASTA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DE: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FECHA : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CLIENTE: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOCUMENTO :";
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
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetReporteVentas";
            reportDataSource1.Value = this.ReporteVentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_de_Presentacion.ReportVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 156);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(967, 246);
            this.reportViewer1.TabIndex = 2;
            // 
            // listarEmpleadosCompletoTableAdapter
            // 
            this.listarEmpleadosCompletoTableAdapter.ClearBeforeFill = true;
            // 
            // listarClientesTableAdapter1
            // 
            this.listarClientesTableAdapter1.ClearBeforeFill = true;
            // 
            // DataSetReporteProductos
            // 
            this.DataSetReporteProductos.DataSetName = "DataSetReporteProductos";
            this.DataSetReporteProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataMember = "Cliente";
            this.ClienteBindingSource.DataSource = this.DataSetReporteProductos;
            // 
            // ClienteTableAdapter
            // 
            this.ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteVentasTableAdapter
            // 
            this.ReporteVentasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 456);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "FrmReportes";
            this.Text = "Reportes de Ventas";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemoPracticaReporteVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listarClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaClientes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarEmpleadosCompletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker date_final;
        private System.Windows.Forms.DateTimePicker date_inicial;
        private System.Windows.Forms.ComboBox cbox_cliente;
        private System.Windows.Forms.ComboBox cbox_documentos;
        private System.Windows.Forms.ComboBox cbox_empleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

        private System.Windows.Forms.CheckBox check_usuarios;
        private DemoPracticaClientes demoPracticaClientes;
        private DemoPracticaClientesTableAdapters.ListarClientesTableAdapter listarClientesTableAdapter;
        private DemoPracticaEmpleados demoPracticaEmpleados;
        private System.Windows.Forms.BindingSource listarEmpleadosCompletoBindingSource;
        private DemoPracticaEmpleadosTableAdapters.ListarEmpleadosCompletoTableAdapter listarEmpleadosCompletoTableAdapter;
        private DemoPracticaClientes demoPracticaClientes1;
        private System.Windows.Forms.BindingSource listarClientesBindingSource;
        private DemoPracticaClientesTableAdapters.ListarClientesTableAdapter listarClientesTableAdapter1;
        private System.Windows.Forms.CheckBox check_clientes;
        private System.Windows.Forms.CheckBox check_documentos;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private DataSetReporteProductos DataSetReporteProductos;
        private DataSetReporteProductosTableAdapters.ClienteTableAdapter ClienteTableAdapter;
        private System.Windows.Forms.BindingSource ReporteVentasBindingSource;
        private DemoPracticaReporteVentas DemoPracticaReporteVentas;
        private DemoPracticaReporteVentasTableAdapters.ReporteVentasTableAdapter ReporteVentasTableAdapter;
    }
}