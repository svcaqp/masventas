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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nroDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.IdC = new System.Windows.Forms.TextBox();
            this.txtIdP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.rbn_boleta = new System.Windows.Forms.RadioButton();
            this.rbn_factura = new System.Windows.Forms.RadioButton();
            this.rbn_guia = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_Fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_nombreProducto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nro Documento (*)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_nroDocumento
            // 
            this.txt_nroDocumento.Location = new System.Drawing.Point(15, 167);
            this.txt_nroDocumento.Name = "txt_nroDocumento";
            this.txt_nroDocumento.Size = new System.Drawing.Size(235, 21);
            this.txt_nroDocumento.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio Unitario (S/.) ";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(16, 268);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(228, 21);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnlyDouble_KeyDown);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(282, 167);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 69);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "&Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(282, 253);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 36);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "&Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cantidad  (*)";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(16, 215);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(228, 21);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnlyDouble_KeyDown);
            // 
            // rbn_boleta
            // 
            this.rbn_boleta.AutoSize = true;
            this.rbn_boleta.Checked = true;
            this.rbn_boleta.Location = new System.Drawing.Point(16, 32);
            this.rbn_boleta.Name = "rbn_boleta";
            this.rbn_boleta.Size = new System.Drawing.Size(65, 20);
            this.rbn_boleta.TabIndex = 1;
            this.rbn_boleta.TabStop = true;
            this.rbn_boleta.Text = "Boleta";
            this.rbn_boleta.UseVisualStyleBackColor = true;
            // 
            // rbn_factura
            // 
            this.rbn_factura.AutoSize = true;
            this.rbn_factura.Location = new System.Drawing.Point(87, 32);
            this.rbn_factura.Name = "rbn_factura";
            this.rbn_factura.Size = new System.Drawing.Size(71, 20);
            this.rbn_factura.TabIndex = 23;
            this.rbn_factura.TabStop = true;
            this.rbn_factura.Text = "Factura";
            this.rbn_factura.UseVisualStyleBackColor = true;
            // 
            // rbn_guia
            // 
            this.rbn_guia.AutoSize = true;
            this.rbn_guia.Location = new System.Drawing.Point(164, 32);
            this.rbn_guia.Name = "rbn_guia";
            this.rbn_guia.Size = new System.Drawing.Size(54, 20);
            this.rbn_guia.TabIndex = 24;
            this.rbn_guia.TabStop = true;
            this.rbn_guia.Text = "Guia";
            this.rbn_guia.UseVisualStyleBackColor = true;
            this.rbn_guia.CheckedChanged += new System.EventHandler(this.rbn_guia_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbn_guia);
            this.groupBox1.Controls.Add(this.rbn_factura);
            this.groupBox1.Controls.Add(this.rbn_boleta);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 85);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documento (*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha  (*)";
            // 
            // date_Fecha
            // 
            this.date_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Fecha.Location = new System.Drawing.Point(261, 80);
            this.date_Fecha.Name = "date_Fecha";
            this.date_Fecha.Size = new System.Drawing.Size(121, 21);
            this.date_Fecha.TabIndex = 11;
            // 
            // lbl_nombreProducto
            // 
            this.lbl_nombreProducto.AutoSize = true;
            this.lbl_nombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreProducto.Location = new System.Drawing.Point(13, 19);
            this.lbl_nombreProducto.Name = "lbl_nombreProducto";
            this.lbl_nombreProducto.Size = new System.Drawing.Size(68, 15);
            this.lbl_nombreProducto.TabIndex = 26;
            this.lbl_nombreProducto.Text = "Pruducto:";
            // 
            // FrmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 326);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_nombreProducto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdP);
            this.Controls.Add(this.IdC);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.date_Fecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nroDocumento);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(422, 360);
            this.MinimumSize = new System.Drawing.Size(422, 360);
            this.Name = "FrmOrdenCompra";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Compra";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FrmOrdenCompra_Activated);
            this.Load += new System.EventHandler(this.FrmRegistroProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txt_nroDocumento;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox IdC;
        public System.Windows.Forms.TextBox txtIdP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.RadioButton rbn_boleta;
        private System.Windows.Forms.RadioButton rbn_factura;
        private System.Windows.Forms.RadioButton rbn_guia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker date_Fecha;
        private System.Windows.Forms.Label lbl_nombreProducto;
    }
}