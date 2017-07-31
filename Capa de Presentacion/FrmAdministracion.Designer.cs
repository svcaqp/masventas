namespace Capa_de_Presentacion
{
    partial class FrmAdministracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministracion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_caja = new System.Windows.Forms.Button();
            this.btn_igv = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbox_caja = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoAbiertoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAbiertoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaAbiertoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoCerradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCerradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCerradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajasCerradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoPracticaCajasCerradas = new Capa_de_Presentacion.DemoPracticaCajasCerradas();
            this.pbox_icon = new System.Windows.Forms.PictureBox();
            this.cajasCerradasTableAdapter = new Capa_de_Presentacion.DemoPracticaCajasCerradasTableAdapters.CajasCerradasTableAdapter();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.gbox_usuarios = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoPracticaUsuarios = new Capa_de_Presentacion.DemoPracticaUsuarios();
            this.usuarioTableAdapter = new Capa_de_Presentacion.DemoPracticaUsuariosTableAdapters.UsuarioTableAdapter();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.gbox_opciones = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gbox_informacion = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre_empresa = new System.Windows.Forms.TextBox();
            this.txt_ruc_empresa = new System.Windows.Forms.TextBox();
            this.txt_direccion_empresa = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.gbox_impresora = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbox_igv = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbox_seguridad = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbox_caja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajasCerradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaCajasCerradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_icon)).BeginInit();
            this.gbox_usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaUsuarios)).BeginInit();
            this.gbox_opciones.SuspendLayout();
            this.gbox_informacion.SuspendLayout();
            this.gbox_impresora.SuspendLayout();
            this.gbox_igv.SuspendLayout();
            this.gbox_seguridad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_caja
            // 
            this.btn_caja.Location = new System.Drawing.Point(35, 19);
            this.btn_caja.Name = "btn_caja";
            this.btn_caja.Size = new System.Drawing.Size(122, 43);
            this.btn_caja.TabIndex = 1;
            this.btn_caja.Text = "Reapertura de Caja";
            this.btn_caja.UseVisualStyleBackColor = true;
            this.btn_caja.Click += new System.EventHandler(this.btn_caja_Click);
            // 
            // btn_igv
            // 
            this.btn_igv.Location = new System.Drawing.Point(192, 19);
            this.btn_igv.Name = "btn_igv";
            this.btn_igv.Size = new System.Drawing.Size(122, 43);
            this.btn_igv.TabIndex = 2;
            this.btn_igv.Text = "IGV";
            this.btn_igv.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Información de la Empresa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbox_caja
            // 
            this.gbox_caja.Controls.Add(this.dataGridView1);
            this.gbox_caja.Location = new System.Drawing.Point(28, 166);
            this.gbox_caja.Name = "gbox_caja";
            this.gbox_caja.Size = new System.Drawing.Size(659, 223);
            this.gbox_caja.TabIndex = 5;
            this.gbox_caja.TabStop = false;
            this.gbox_caja.Text = "Reapertura de Caja";
            this.gbox_caja.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleadoDataGridViewTextBoxColumn,
            this.idCajaDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.saldoAbiertoDataGridViewTextBoxColumn,
            this.fechaAbiertoDataGridViewTextBoxColumn,
            this.horaAbiertoDataGridViewTextBoxColumn,
            this.saldoCerradoDataGridViewTextBoxColumn,
            this.fechaCerradoDataGridViewTextBoxColumn,
            this.horaCerradoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cajasCerradasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "IdEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            this.idEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEmpleadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idCajaDataGridViewTextBoxColumn
            // 
            this.idCajaDataGridViewTextBoxColumn.DataPropertyName = "IdCaja";
            this.idCajaDataGridViewTextBoxColumn.HeaderText = "IdCaja";
            this.idCajaDataGridViewTextBoxColumn.Name = "idCajaDataGridViewTextBoxColumn";
            this.idCajaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoAbiertoDataGridViewTextBoxColumn
            // 
            this.saldoAbiertoDataGridViewTextBoxColumn.DataPropertyName = "SaldoAbierto";
            this.saldoAbiertoDataGridViewTextBoxColumn.HeaderText = "SaldoAbierto";
            this.saldoAbiertoDataGridViewTextBoxColumn.Name = "saldoAbiertoDataGridViewTextBoxColumn";
            this.saldoAbiertoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaAbiertoDataGridViewTextBoxColumn
            // 
            this.fechaAbiertoDataGridViewTextBoxColumn.DataPropertyName = "FechaAbierto";
            this.fechaAbiertoDataGridViewTextBoxColumn.HeaderText = "FechaAbierto";
            this.fechaAbiertoDataGridViewTextBoxColumn.Name = "fechaAbiertoDataGridViewTextBoxColumn";
            this.fechaAbiertoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaAbiertoDataGridViewTextBoxColumn
            // 
            this.horaAbiertoDataGridViewTextBoxColumn.DataPropertyName = "HoraAbierto";
            this.horaAbiertoDataGridViewTextBoxColumn.HeaderText = "HoraAbierto";
            this.horaAbiertoDataGridViewTextBoxColumn.Name = "horaAbiertoDataGridViewTextBoxColumn";
            this.horaAbiertoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoCerradoDataGridViewTextBoxColumn
            // 
            this.saldoCerradoDataGridViewTextBoxColumn.DataPropertyName = "SaldoCerrado";
            this.saldoCerradoDataGridViewTextBoxColumn.HeaderText = "SaldoCerrado";
            this.saldoCerradoDataGridViewTextBoxColumn.Name = "saldoCerradoDataGridViewTextBoxColumn";
            this.saldoCerradoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCerradoDataGridViewTextBoxColumn
            // 
            this.fechaCerradoDataGridViewTextBoxColumn.DataPropertyName = "FechaCerrado";
            this.fechaCerradoDataGridViewTextBoxColumn.HeaderText = "FechaCerrado";
            this.fechaCerradoDataGridViewTextBoxColumn.Name = "fechaCerradoDataGridViewTextBoxColumn";
            this.fechaCerradoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaCerradoDataGridViewTextBoxColumn
            // 
            this.horaCerradoDataGridViewTextBoxColumn.DataPropertyName = "HoraCerrado";
            this.horaCerradoDataGridViewTextBoxColumn.HeaderText = "HoraCerrado";
            this.horaCerradoDataGridViewTextBoxColumn.Name = "horaCerradoDataGridViewTextBoxColumn";
            this.horaCerradoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cajasCerradasBindingSource
            // 
            this.cajasCerradasBindingSource.DataMember = "CajasCerradas";
            this.cajasCerradasBindingSource.DataSource = this.demoPracticaCajasCerradas;
            // 
            // demoPracticaCajasCerradas
            // 
            this.demoPracticaCajasCerradas.DataSetName = "DemoPracticaCajasCerradas";
            this.demoPracticaCajasCerradas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pbox_icon
            // 
            this.pbox_icon.Image = ((System.Drawing.Image)(resources.GetObject("pbox_icon.Image")));
            this.pbox_icon.Location = new System.Drawing.Point(29, 24);
            this.pbox_icon.Name = "pbox_icon";
            this.pbox_icon.Size = new System.Drawing.Size(138, 110);
            this.pbox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_icon.TabIndex = 0;
            this.pbox_icon.TabStop = false;
            // 
            // cajasCerradasTableAdapter
            // 
            this.cajasCerradasTableAdapter.ClearBeforeFill = true;
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Location = new System.Drawing.Point(350, 68);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(122, 43);
            this.btn_usuarios.TabIndex = 6;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // gbox_usuarios
            // 
            this.gbox_usuarios.Controls.Add(this.label1);
            this.gbox_usuarios.Controls.Add(this.dataGridView2);
            this.gbox_usuarios.Location = new System.Drawing.Point(29, 165);
            this.gbox_usuarios.Name = "gbox_usuarios";
            this.gbox_usuarios.Size = new System.Drawing.Size(659, 242);
            this.gbox_usuarios.TabIndex = 6;
            this.gbox_usuarios.TabStop = false;
            this.gbox_usuarios.Text = "Usuarios";
            this.gbox_usuarios.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "* Doble click sobre el campo para editar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn1,
            this.contraseñaDataGridViewTextBoxColumn,
            this.Actualizar,
            this.Eliminar});
            this.dataGridView2.DataSource = this.usuarioBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(647, 198);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn1
            // 
            this.usuarioDataGridViewTextBoxColumn1.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn1.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn1.Name = "usuarioDataGridViewTextBoxColumn1";
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle1.NullValue = "********";
            this.contraseñaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            this.contraseñaDataGridViewTextBoxColumn.ToolTipText = "*********";
            // 
            // Actualizar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Actualizar";
            this.Actualizar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Actualizar.HeaderText = "Actualizar";
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.ToolTipText = "Actualizar";
            // 
            // Eliminar
            // 
            this.Eliminar.DataPropertyName = "Eliminar";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Eliminar";
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.ToolTipText = "Eliminar";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.demoPracticaUsuarios;
            // 
            // demoPracticaUsuarios
            // 
            this.demoPracticaUsuarios.DataSetName = "DemoPracticaUsuarios";
            this.demoPracticaUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensaje.Location = new System.Drawing.Point(270, 226);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(308, 33);
            this.lbl_mensaje.TabIndex = 7;
            this.lbl_mensaje.Text = "Seleccione una opción";
            // 
            // gbox_opciones
            // 
            this.gbox_opciones.Controls.Add(this.button3);
            this.gbox_opciones.Controls.Add(this.button1);
            this.gbox_opciones.Controls.Add(this.btn_usuarios);
            this.gbox_opciones.Controls.Add(this.button2);
            this.gbox_opciones.Controls.Add(this.btn_igv);
            this.gbox_opciones.Controls.Add(this.btn_caja);
            this.gbox_opciones.Location = new System.Drawing.Point(183, 24);
            this.gbox_opciones.Name = "gbox_opciones";
            this.gbox_opciones.Size = new System.Drawing.Size(505, 136);
            this.gbox_opciones.TabIndex = 8;
            this.gbox_opciones.TabStop = false;
            this.gbox_opciones.Text = "Opciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Seguridad";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "Impresora";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // gbox_informacion
            // 
            this.gbox_informacion.Controls.Add(this.button4);
            this.gbox_informacion.Controls.Add(this.txt_direccion_empresa);
            this.gbox_informacion.Controls.Add(this.txt_ruc_empresa);
            this.gbox_informacion.Controls.Add(this.txt_nombre_empresa);
            this.gbox_informacion.Controls.Add(this.label4);
            this.gbox_informacion.Controls.Add(this.label3);
            this.gbox_informacion.Controls.Add(this.label2);
            this.gbox_informacion.Location = new System.Drawing.Point(27, 168);
            this.gbox_informacion.Name = "gbox_informacion";
            this.gbox_informacion.Size = new System.Drawing.Size(654, 233);
            this.gbox_informacion.TabIndex = 9;
            this.gbox_informacion.TabStop = false;
            this.gbox_informacion.Text = "Información de la empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre de la empresa :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "RUC de la empresa :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Direccion de la empresa :";
            // 
            // txt_nombre_empresa
            // 
            this.txt_nombre_empresa.Location = new System.Drawing.Point(22, 53);
            this.txt_nombre_empresa.Name = "txt_nombre_empresa";
            this.txt_nombre_empresa.Size = new System.Drawing.Size(306, 20);
            this.txt_nombre_empresa.TabIndex = 13;
            // 
            // txt_ruc_empresa
            // 
            this.txt_ruc_empresa.Location = new System.Drawing.Point(22, 108);
            this.txt_ruc_empresa.Name = "txt_ruc_empresa";
            this.txt_ruc_empresa.Size = new System.Drawing.Size(306, 20);
            this.txt_ruc_empresa.TabIndex = 14;
            // 
            // txt_direccion_empresa
            // 
            this.txt_direccion_empresa.Location = new System.Drawing.Point(22, 158);
            this.txt_direccion_empresa.Name = "txt_direccion_empresa";
            this.txt_direccion_empresa.Size = new System.Drawing.Size(306, 20);
            this.txt_direccion_empresa.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(445, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 50);
            this.button4.TabIndex = 16;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // gbox_impresora
            // 
            this.gbox_impresora.Controls.Add(this.button5);
            this.gbox_impresora.Controls.Add(this.textBox3);
            this.gbox_impresora.Controls.Add(this.label7);
            this.gbox_impresora.Location = new System.Drawing.Point(30, 221);
            this.gbox_impresora.Name = "gbox_impresora";
            this.gbox_impresora.Size = new System.Drawing.Size(654, 112);
            this.gbox_impresora.TabIndex = 17;
            this.gbox_impresora.TabStop = false;
            this.gbox_impresora.Text = "Impresora";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(460, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 50);
            this.button5.TabIndex = 16;
            this.button5.Text = "Impresion de prueba";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(22, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(306, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nombre de la impresora";
            // 
            // gbox_igv
            // 
            this.gbox_igv.Controls.Add(this.button6);
            this.gbox_igv.Controls.Add(this.textBox1);
            this.gbox_igv.Controls.Add(this.label5);
            this.gbox_igv.Location = new System.Drawing.Point(29, 221);
            this.gbox_igv.Name = "gbox_igv";
            this.gbox_igv.Size = new System.Drawing.Size(654, 112);
            this.gbox_igv.TabIndex = 18;
            this.gbox_igv.TabStop = false;
            this.gbox_igv.Text = "IGV";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(460, 34);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 50);
            this.button6.TabIndex = 16;
            this.button6.Text = "Guardar Cambios";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tasa de IGV(%)";
            // 
            // gbox_seguridad
            // 
            this.gbox_seguridad.Controls.Add(this.button7);
            this.gbox_seguridad.Controls.Add(this.textBox2);
            this.gbox_seguridad.Controls.Add(this.label6);
            this.gbox_seguridad.Location = new System.Drawing.Point(27, 221);
            this.gbox_seguridad.Name = "gbox_seguridad";
            this.gbox_seguridad.Size = new System.Drawing.Size(654, 112);
            this.gbox_seguridad.TabIndex = 19;
            this.gbox_seguridad.TabStop = false;
            this.gbox_seguridad.Text = "Seguridad";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(460, 34);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(138, 50);
            this.button7.TabIndex = 16;
            this.button7.Text = "Generar copia de seguridad";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ubicacion del archivo (.Backup)";
            // 
            // FrmAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 429);
            this.Controls.Add(this.gbox_seguridad);
            this.Controls.Add(this.gbox_igv);
            this.Controls.Add(this.gbox_impresora);
            this.Controls.Add(this.gbox_informacion);
            this.Controls.Add(this.gbox_opciones);
            this.Controls.Add(this.gbox_usuarios);
            this.Controls.Add(this.gbox_caja);
            this.Controls.Add(this.pbox_icon);
            this.Controls.Add(this.lbl_mensaje);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdministracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.FrmAdministracion_Load);
            this.gbox_caja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajasCerradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaCajasCerradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_icon)).EndInit();
            this.gbox_usuarios.ResumeLayout(false);
            this.gbox_usuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoPracticaUsuarios)).EndInit();
            this.gbox_opciones.ResumeLayout(false);
            this.gbox_informacion.ResumeLayout(false);
            this.gbox_informacion.PerformLayout();
            this.gbox_impresora.ResumeLayout(false);
            this.gbox_impresora.PerformLayout();
            this.gbox_igv.ResumeLayout(false);
            this.gbox_igv.PerformLayout();
            this.gbox_seguridad.ResumeLayout(false);
            this.gbox_seguridad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_icon;
        private System.Windows.Forms.Button btn_caja;
        private System.Windows.Forms.Button btn_igv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbox_caja;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DemoPracticaCajasCerradas demoPracticaCajasCerradas;
        private System.Windows.Forms.BindingSource cajasCerradasBindingSource;
        private DemoPracticaCajasCerradasTableAdapters.CajasCerradasTableAdapter cajasCerradasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoAbiertoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAbiertoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaAbiertoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoCerradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCerradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCerradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.GroupBox gbox_usuarios;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DemoPracticaUsuarios demoPracticaUsuarios;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DemoPracticaUsuariosTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Actualizar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.GroupBox gbox_opciones;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbox_informacion;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_direccion_empresa;
        private System.Windows.Forms.TextBox txt_ruc_empresa;
        private System.Windows.Forms.TextBox txt_nombre_empresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbox_impresora;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbox_igv;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbox_seguridad;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}