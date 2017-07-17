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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.Panel_items = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.lbl_CajaCerrada = new System.Windows.Forms.Label();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_AbrirCaja = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_titleSaldoCaja = new System.Windows.Forms.Label();
            this.lbl_saldoCaja = new System.Windows.Forms.Label();
            this.btn_CerrarCaja = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TipodeUsuario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Panel_items.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1112, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE VENTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(875, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblFecha.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(991, 46);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(96, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(876, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblHora.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(1003, 66);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(94, 20);
            this.lblHora.TabIndex = 4;
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // Panel_items
            // 
            this.Panel_items.BackColor = System.Drawing.Color.Transparent;
            this.Panel_items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_items.Controls.Add(this.label11);
            this.Panel_items.Controls.Add(this.label10);
            this.Panel_items.Controls.Add(this.label9);
            this.Panel_items.Controls.Add(this.label8);
            this.Panel_items.Controls.Add(this.label7);
            this.Panel_items.Controls.Add(this.label6);
            this.Panel_items.Controls.Add(this.btnEmpleados);
            this.Panel_items.Controls.Add(this.btnReportes);
            this.Panel_items.Controls.Add(this.lbl_CajaCerrada);
            this.Panel_items.Controls.Add(this.btnVentas);
            this.Panel_items.Controls.Add(this.btnUsuarios);
            this.Panel_items.Controls.Add(this.btnClientes);
            this.Panel_items.Controls.Add(this.btnProductos);
            this.Panel_items.ForeColor = System.Drawing.Color.Black;
            this.Panel_items.Location = new System.Drawing.Point(58, 144);
            this.Panel_items.Name = "Panel_items";
            this.Panel_items.Size = new System.Drawing.Size(990, 216);
            this.Panel_items.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(817, 170);
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
            this.label10.Location = new System.Drawing.Point(681, 165);
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
            this.label9.Location = new System.Drawing.Point(526, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Empleados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(395, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Productos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 165);
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
            this.label6.Location = new System.Drawing.Point(109, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ventas";
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.BackgroundImage")));
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Location = new System.Drawing.Point(498, 48);
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
            this.btnReportes.Location = new System.Drawing.Point(644, 48);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(134, 114);
            this.btnReportes.TabIndex = 0;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // lbl_CajaCerrada
            // 
            this.lbl_CajaCerrada.AutoSize = true;
            this.lbl_CajaCerrada.BackColor = System.Drawing.Color.Snow;
            this.lbl_CajaCerrada.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CajaCerrada.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_CajaCerrada.Location = new System.Drawing.Point(73, 81);
            this.lbl_CajaCerrada.Name = "lbl_CajaCerrada";
            this.lbl_CajaCerrada.Size = new System.Drawing.Size(103, 50);
            this.lbl_CajaCerrada.TabIndex = 11;
            this.lbl_CajaCerrada.Text = "CAJA\r\nCERRADA";
            this.lbl_CajaCerrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVentas
            // 
            this.btnVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVentas.BackgroundImage")));
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVentas.Enabled = false;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(59, 48);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(131, 114);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.BackgroundImage")));
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(794, 48);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(130, 119);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.BackgroundImage")));
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(205, 48);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(128, 114);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.BackgroundImage")));
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(352, 48);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(133, 114);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario Activo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(145, 14);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(289, 23);
            this.lblUsuario.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_AbrirCaja
            // 
            this.btn_AbrirCaja.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_AbrirCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AbrirCaja.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_AbrirCaja.FlatAppearance.BorderSize = 0;
            this.btn_AbrirCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_AbrirCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btn_AbrirCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AbrirCaja.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AbrirCaja.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AbrirCaja.Location = new System.Drawing.Point(108, 46);
            this.btn_AbrirCaja.Name = "btn_AbrirCaja";
            this.btn_AbrirCaja.Size = new System.Drawing.Size(142, 33);
            this.btn_AbrirCaja.TabIndex = 2;
            this.btn_AbrirCaja.Text = "ABRIR CAJA";
            this.btn_AbrirCaja.UseVisualStyleBackColor = false;
            this.btn_AbrirCaja.Click += new System.EventHandler(this.btn_AbrirCaja_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(958, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_titleSaldoCaja
            // 
            this.lbl_titleSaldoCaja.AutoSize = true;
            this.lbl_titleSaldoCaja.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_titleSaldoCaja.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleSaldoCaja.Location = new System.Drawing.Point(54, 41);
            this.lbl_titleSaldoCaja.Name = "lbl_titleSaldoCaja";
            this.lbl_titleSaldoCaja.Size = new System.Drawing.Size(97, 16);
            this.lbl_titleSaldoCaja.TabIndex = 9;
            this.lbl_titleSaldoCaja.Text = "Saldo en Caja :";
            this.lbl_titleSaldoCaja.Visible = false;
            // 
            // lbl_saldoCaja
            // 
            this.lbl_saldoCaja.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_saldoCaja.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldoCaja.Location = new System.Drawing.Point(156, 36);
            this.lbl_saldoCaja.Name = "lbl_saldoCaja";
            this.lbl_saldoCaja.Size = new System.Drawing.Size(86, 23);
            this.lbl_saldoCaja.TabIndex = 10;
            this.lbl_saldoCaja.Visible = false;
            this.lbl_saldoCaja.Click += new System.EventHandler(this.lbl_saldoCaja_Click);
            // 
            // btn_CerrarCaja
            // 
            this.btn_CerrarCaja.BackColor = System.Drawing.Color.Orange;
            this.btn_CerrarCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_CerrarCaja.FlatAppearance.BorderSize = 0;
            this.btn_CerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CerrarCaja.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CerrarCaja.Location = new System.Drawing.Point(809, 9);
            this.btn_CerrarCaja.Name = "btn_CerrarCaja";
            this.btn_CerrarCaja.Size = new System.Drawing.Size(143, 33);
            this.btn_CerrarCaja.TabIndex = 12;
            this.btn_CerrarCaja.Text = "Cerrar Caja";
            this.btn_CerrarCaja.UseVisualStyleBackColor = false;
            this.btn_CerrarCaja.Visible = false;
            this.btn_CerrarCaja.Click += new System.EventHandler(this.btn_CerrarCaja_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lbl_TipodeUsuario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 35);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_TipodeUsuario
            // 
            this.lbl_TipodeUsuario.AutoSize = true;
            this.lbl_TipodeUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_TipodeUsuario.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipodeUsuario.Location = new System.Drawing.Point(951, 8);
            this.lbl_TipodeUsuario.Name = "lbl_TipodeUsuario";
            this.lbl_TipodeUsuario.Size = new System.Drawing.Size(0, 18);
            this.lbl_TipodeUsuario.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(867, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Usuario:";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1112, 456);
            this.ControlBox = false;
            this.Controls.Add(this.btn_CerrarCaja);
            this.Controls.Add(this.lbl_saldoCaja);
            this.Controls.Add(this.lbl_titleSaldoCaja);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_AbrirCaja);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Panel_items);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Activated += new System.EventHandler(this.FrmMenuPrincipal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.Panel_items.ResumeLayout(false);
            this.Panel_items.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button btn_AbrirCaja;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_titleSaldoCaja;
        private System.Windows.Forms.Label lbl_saldoCaja;
        private System.Windows.Forms.Label lbl_CajaCerrada;
        private System.Windows.Forms.Button btn_CerrarCaja;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TipodeUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;


    }
}