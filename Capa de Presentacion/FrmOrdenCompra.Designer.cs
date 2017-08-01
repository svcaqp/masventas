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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.IdC = new System.Windows.Forms.TextBox();
            this.txtIdP = new System.Windows.Forms.TextBox();
            this.rbn_boleta = new System.Windows.Forms.RadioButton();
            this.rbn_factura = new System.Windows.Forms.RadioButton();
            this.rbn_guia = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_Fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_nombreProducto = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nroDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(288, 174);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 69);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "&Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(288, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 34);
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
            // rbn_boleta
            // 
            this.rbn_boleta.AutoSize = true;
            this.rbn_boleta.Checked = true;
            this.rbn_boleta.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_boleta.Location = new System.Drawing.Point(184, 20);
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
            this.rbn_factura.Location = new System.Drawing.Point(275, 20);
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
            this.rbn_guia.Location = new System.Drawing.Point(36, 20);
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
            this.groupBox1.Controls.Add(this.rbn_guia);
            this.groupBox1.Controls.Add(this.rbn_factura);
            this.groupBox1.Controls.Add(this.rbn_boleta);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 47);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documento (*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha  (*)";
            this.label6.Visible = false;
            // 
            // date_Fecha
            // 
            this.date_Fecha.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Fecha.Location = new System.Drawing.Point(107, 15);
            this.date_Fecha.Name = "date_Fecha";
            this.date_Fecha.Size = new System.Drawing.Size(176, 22);
            this.date_Fecha.TabIndex = 11;
            // 
            // lbl_nombreProducto
            // 
            this.lbl_nombreProducto.AutoSize = true;
            this.lbl_nombreProducto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreProducto.Location = new System.Drawing.Point(10, 20);
            this.lbl_nombreProducto.Name = "lbl_nombreProducto";
            this.lbl_nombreProducto.Size = new System.Drawing.Size(82, 14);
            this.lbl_nombreProducto.TabIndex = 26;
            this.lbl_nombreProducto.Text = "PRODUCTO: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_nombreProducto);
            this.groupBox2.Location = new System.Drawing.Point(13, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 48);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.date_Fecha);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 47);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fecha (*)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCantidad);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtTotal);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txt_nroDocumento);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(14, 168);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(260, 146);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(16, 71);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(228, 22);
            this.txtCantidad.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 14);
            this.label8.TabIndex = 25;
            this.label8.Text = "Cantidad  (*)";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(16, 112);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(226, 22);
            this.txtTotal.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 14);
            this.label3.TabIndex = 24;
            this.label3.Text = "Precio Unitario (S/.) ";
            // 
            // txt_nroDocumento
            // 
            this.txt_nroDocumento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nroDocumento.Location = new System.Drawing.Point(15, 30);
            this.txt_nroDocumento.Name = "txt_nroDocumento";
            this.txt_nroDocumento.Size = new System.Drawing.Size(229, 22);
            this.txt_nroDocumento.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nro Documento (*)";
            // 
            // FrmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 326);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtIdP);
            this.Controls.Add(this.IdC);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox IdC;
        public System.Windows.Forms.TextBox txtIdP;
        private System.Windows.Forms.RadioButton rbn_boleta;
        private System.Windows.Forms.RadioButton rbn_factura;
        private System.Windows.Forms.RadioButton rbn_guia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker date_Fecha;
        private System.Windows.Forms.Label lbl_nombreProducto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_nroDocumento;
        private System.Windows.Forms.Label label2;
    }
}