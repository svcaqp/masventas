namespace Capa_de_Presentacion
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.Panel_items = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_CajaCerrada = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_TipodeUsuario = new System.Windows.Forms.Label();
            this.lbl_prueba = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnMenuCaja = new System.Windows.Forms.Button();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.btnDocumentos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel_items.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(128, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblFecha.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(188, 71);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(109, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(128, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblHora.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(188, 91);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(109, 20);
            this.lblHora.TabIndex = 4;
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // Panel_items
            // 
            this.Panel_items.BackColor = System.Drawing.Color.Transparent;
            this.Panel_items.Controls.Add(this.label12);
            this.Panel_items.Controls.Add(this.label5);
            this.Panel_items.Controls.Add(this.label1);
            this.Panel_items.Controls.Add(this.label8);
            this.Panel_items.Controls.Add(this.btnProductos);
            this.Panel_items.Controls.Add(this.lbl_CajaCerrada);
            this.Panel_items.Controls.Add(this.btnMenuCaja);
            this.Panel_items.Controls.Add(this.btnTutorial);
            this.Panel_items.Controls.Add(this.btnDocumentos);
            this.Panel_items.Controls.Add(this.label11);
            this.Panel_items.Controls.Add(this.label10);
            this.Panel_items.Controls.Add(this.label9);
            this.Panel_items.Controls.Add(this.label7);
            this.Panel_items.Controls.Add(this.btnUsuarios);
            this.Panel_items.Controls.Add(this.label6);
            this.Panel_items.Controls.Add(this.btnEmpleados);
            this.Panel_items.Controls.Add(this.btnReportes);
            this.Panel_items.Controls.Add(this.btnVentas);
            this.Panel_items.Controls.Add(this.btnClientes);
            this.Panel_items.ForeColor = System.Drawing.Color.Black;
            this.Panel_items.Location = new System.Drawing.Point(69, 147);
            this.Panel_items.Name = "Panel_items";
            this.Panel_items.Size = new System.Drawing.Size(751, 317);
            this.Panel_items.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(622, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Documentos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(572, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tutorial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Caja";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Almacen";
            // 
            // lbl_CajaCerrada
            // 
            this.lbl_CajaCerrada.AutoSize = true;
            this.lbl_CajaCerrada.BackColor = System.Drawing.Color.Snow;
            this.lbl_CajaCerrada.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CajaCerrada.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_CajaCerrada.Location = new System.Drawing.Point(113, 58);
            this.lbl_CajaCerrada.Name = "lbl_CajaCerrada";
            this.lbl_CajaCerrada.Size = new System.Drawing.Size(103, 50);
            this.lbl_CajaCerrada.TabIndex = 11;
            this.lbl_CajaCerrada.Text = "CAJA\r\nCERRADA";
            this.lbl_CajaCerrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(469, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Administración";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(340, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Reportes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(194, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Empleados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Clientes";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ventas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(132, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario :";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(131, 64);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(198, 23);
            this.lblUsuario.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(165, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbl_prueba);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 40);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_TipodeUsuario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(940, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 40);
            this.panel3.TabIndex = 16;
            // 
            // lbl_TipodeUsuario
            // 
            this.lbl_TipodeUsuario.AutoSize = true;
            this.lbl_TipodeUsuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_TipodeUsuario.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipodeUsuario.ForeColor = System.Drawing.Color.White;
            this.lbl_TipodeUsuario.Location = new System.Drawing.Point(44, 9);
            this.lbl_TipodeUsuario.Name = "lbl_TipodeUsuario";
            this.lbl_TipodeUsuario.Size = new System.Drawing.Size(0, 18);
            this.lbl_TipodeUsuario.TabIndex = 14;
            // 
            // lbl_prueba
            // 
            this.lbl_prueba.AutoSize = true;
            this.lbl_prueba.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_prueba.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prueba.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_prueba.Location = new System.Drawing.Point(12, 12);
            this.lbl_prueba.Name = "lbl_prueba";
            this.lbl_prueba.Size = new System.Drawing.Size(0, 16);
            this.lbl_prueba.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 141);
            this.panel2.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lblHora);
            this.panel5.Controls.Add(this.lblFecha);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(759, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(361, 141);
            this.panel5.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lblUsuario);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(377, 141);
            this.panel4.TabIndex = 16;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(440, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.BackgroundImage")));
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(19, 166);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(133, 114);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnMenuCaja
            // 
            this.btnMenuCaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuCaja.BackgroundImage")));
            this.btnMenuCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenuCaja.Location = new System.Drawing.Point(240, 20);
            this.btnMenuCaja.Name = "btnMenuCaja";
            this.btnMenuCaja.Size = new System.Drawing.Size(133, 112);
            this.btnMenuCaja.TabIndex = 21;
            this.btnMenuCaja.UseVisualStyleBackColor = true;
            this.btnMenuCaja.Click += new System.EventHandler(this.btnMenuCaja_Click);
            // 
            // btnTutorial
            // 
            this.btnTutorial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTutorial.BackgroundImage")));
            this.btnTutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTutorial.Location = new System.Drawing.Point(526, 21);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(134, 114);
            this.btnTutorial.TabIndex = 20;
            this.btnTutorial.UseVisualStyleBackColor = true;
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDocumentos.BackgroundImage")));
            this.btnDocumentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDocumentos.Location = new System.Drawing.Point(594, 166);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Size = new System.Drawing.Size(128, 114);
            this.btnDocumentos.TabIndex = 19;
            this.btnDocumentos.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.BackgroundImage")));
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsuarios.Enabled = false;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(451, 166);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(130, 116);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.BackgroundImage")));
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Location = new System.Drawing.Point(163, 166);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(131, 114);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReportes.BackgroundImage")));
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(305, 166);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(134, 114);
            this.btnReportes.TabIndex = 0;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVentas.BackgroundImage")));
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVentas.Enabled = false;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(98, 20);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(131, 114);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.BackgroundImage")));
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(386, 20);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(128, 114);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1120, 468);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_items);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.FrmMenuPrincipal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.Panel_items.ResumeLayout(false);
            this.Panel_items.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel Panel_items;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_CajaCerrada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TipodeUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_prueba;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTutorial;
        private System.Windows.Forms.Button btnDocumentos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuCaja;
        private System.Windows.Forms.PictureBox pictureBox2;


    }
}