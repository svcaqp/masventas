namespace Capa_de_Presentacion
{
    partial class FrmOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenCompra));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.IdC = new System.Windows.Forms.TextBox();
            this.txtIdP = new System.Windows.Forms.TextBox();
            this.rbn_boleta = new System.Windows.Forms.RadioButton();
            this.rbn_factura = new System.Windows.Forms.RadioButton();
            this.rbn_guia = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nroDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_Fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_nombreProducto = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_MarcaProducto = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(353, 369);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 35);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // IdC
            // 
            this.IdC.BackColor = System.Drawing.SystemColors.Control;
            this.IdC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdC.Location = new System.Drawing.Point(541, 156);
            this.IdC.Name = "IdC";
            this.IdC.Size = new System.Drawing.Size(17, 14);
            this.IdC.TabIndex = 17;
            this.IdC.Visible = false;
            // 
            // txtIdP
            // 
            this.txtIdP.Location = new System.Drawing.Point(604, 42);
            this.txtIdP.Name = "txtIdP";
            this.txtIdP.Size = new System.Drawing.Size(48, 21);
            this.txtIdP.TabIndex = 18;
            // 
            // rbn_boleta
            // 
            this.rbn_boleta.AutoSize = true;
            this.rbn_boleta.Checked = true;
            this.rbn_boleta.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_boleta.Location = new System.Drawing.Point(215, 20);
            this.rbn_boleta.Name = "rbn_boleta";
            this.rbn_boleta.Size = new System.Drawing.Size(59, 18);
            this.rbn_boleta.TabIndex = 1;
            this.rbn_boleta.TabStop = true;
            this.rbn_boleta.Text = "Boleta";
            this.rbn_boleta.UseVisualStyleBackColor = true;
            // 
            // rbn_factura
            // 
            this.rbn_factura.AutoSize = true;
            this.rbn_factura.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_factura.Location = new System.Drawing.Point(306, 20);
            this.rbn_factura.Name = "rbn_factura";
            this.rbn_factura.Size = new System.Drawing.Size(65, 18);
            this.rbn_factura.TabIndex = 23;
            this.rbn_factura.TabStop = true;
            this.rbn_factura.Text = "Factura";
            this.rbn_factura.UseVisualStyleBackColor = true;
            // 
            // rbn_guia
            // 
            this.rbn_guia.AutoSize = true;
            this.rbn_guia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_guia.Location = new System.Drawing.Point(67, 20);
            this.rbn_guia.Name = "rbn_guia";
            this.rbn_guia.Size = new System.Drawing.Size(117, 18);
            this.rbn_guia.TabIndex = 24;
            this.rbn_guia.TabStop = true;
            this.rbn_guia.Text = "Guia de Remisión";
            this.rbn_guia.UseVisualStyleBackColor = true;
            this.rbn_guia.CheckedChanged += new System.EventHandler(this.rbn_guia_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nroDocumento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbn_guia);
            this.groupBox1.Controls.Add(this.rbn_factura);
            this.groupBox1.Controls.Add(this.rbn_boleta);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 125);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documento (*)";
            // 
            // txt_nroDocumento
            // 
            this.txt_nroDocumento.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_nroDocumento.Font = new System.Drawing.Font("Tahoma", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nroDocumento.Location = new System.Drawing.Point(15, 67);
            this.txt_nroDocumento.MaxLength = 23;
            this.txt_nroDocumento.Multiline = true;
            this.txt_nroDocumento.Name = "txt_nroDocumento";
            this.txt_nroDocumento.Size = new System.Drawing.Size(418, 47);
            this.txt_nroDocumento.TabIndex = 25;
            this.txt_nroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nroDocumento.EnabledChanged += new System.EventHandler(this.txt_nroDocumento_EnabledChanged);
            this.txt_nroDocumento.TextChanged += new System.EventHandler(this.txt_nroDocumento_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 14);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nro. Documento:";
            // 
            // date_Fecha
            // 
            this.date_Fecha.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Fecha.Location = new System.Drawing.Point(15, 23);
            this.date_Fecha.Name = "date_Fecha";
            this.date_Fecha.Size = new System.Drawing.Size(262, 22);
            this.date_Fecha.TabIndex = 11;
            // 
            // lbl_nombreProducto
            // 
            this.lbl_nombreProducto.AutoSize = true;
            this.lbl_nombreProducto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreProducto.Location = new System.Drawing.Point(10, 19);
            this.lbl_nombreProducto.Name = "lbl_nombreProducto";
            this.lbl_nombreProducto.Size = new System.Drawing.Size(82, 14);
            this.lbl_nombreProducto.TabIndex = 26;
            this.lbl_nombreProducto.Text = "PRODUCTO: ";
            this.lbl_nombreProducto.Click += new System.EventHandler(this.lbl_nombreProducto_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_MarcaProducto);
            this.groupBox2.Controls.Add(this.lbl_nombreProducto);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 65);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // lbl_MarcaProducto
            // 
            this.lbl_MarcaProducto.AutoSize = true;
            this.lbl_MarcaProducto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MarcaProducto.Location = new System.Drawing.Point(10, 37);
            this.lbl_MarcaProducto.Name = "lbl_MarcaProducto";
            this.lbl_MarcaProducto.Size = new System.Drawing.Size(57, 14);
            this.lbl_MarcaProducto.TabIndex = 27;
            this.lbl_MarcaProducto.Text = "MARCA:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.date_Fecha);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(172, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 62);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fecha (*)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTotal);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtCantidad);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(12, 268);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(149, 150);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(68, 96);
            this.txtTotal.MaxLength = 4;
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(64, 42);
            this.txtTotal.TabIndex = 23;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 39);
            this.label1.TabIndex = 26;
            this.label1.Text = "S/.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCantidad.Font = new System.Drawing.Font("Tahoma", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(16, 33);
            this.txtCantidad.MaxLength = 5;
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(116, 42);
            this.txtCantidad.TabIndex = 22;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 14);
            this.label8.TabIndex = 25;
            this.label8.Text = "Cantidad  (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 14);
            this.label3.TabIndex = 24;
            this.label3.Text = "Precio Unitario (*) ";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(220, 10);
            this.button2.MaximumSize = new System.Drawing.Size(141, 33);
            this.button2.MinimumSize = new System.Drawing.Size(141, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Regresar ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.lbl_title);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(93, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 52);
            this.panel4.TabIndex = 1010;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(14, 15);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(180, 23);
            this.lbl_title.TabIndex = 11;
            this.lbl_title.Text = "ORDEN DE COMPRA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(243, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 1011;
            this.button1.Text = "&Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(473, 426);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtIdP);
            this.Controls.Add(this.IdC);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(489, 465);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(489, 465);
            this.Name = "FrmOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FrmOrdenCompra_Activated);
            this.Load += new System.EventHandler(this.FrmRegistroProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox IdC;
        public System.Windows.Forms.TextBox txtIdP;
        private System.Windows.Forms.RadioButton rbn_boleta;
        private System.Windows.Forms.RadioButton rbn_factura;
        private System.Windows.Forms.RadioButton rbn_guia;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker date_Fecha;
        private System.Windows.Forms.Label lbl_nombreProducto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txt_nroDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_MarcaProducto;
        private System.Windows.Forms.Label label1;
    }
}