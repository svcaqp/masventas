namespace Capa_de_Presentacion
{
    partial class FrmCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaja));
            this.btn_AbrirCaja = new System.Windows.Forms.Button();
            this.btn_CerrarCaja = new System.Windows.Forms.Button();
            this.lbl_SaldoCaja = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbox_egresos = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbox_egresos.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AbrirCaja
            // 
            this.btn_AbrirCaja.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_AbrirCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AbrirCaja.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_AbrirCaja.FlatAppearance.BorderSize = 0;
            this.btn_AbrirCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_AbrirCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btn_AbrirCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AbrirCaja.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AbrirCaja.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AbrirCaja.Location = new System.Drawing.Point(367, 87);
            this.btn_AbrirCaja.MaximumSize = new System.Drawing.Size(145, 45);
            this.btn_AbrirCaja.MinimumSize = new System.Drawing.Size(145, 45);
            this.btn_AbrirCaja.Name = "btn_AbrirCaja";
            this.btn_AbrirCaja.Size = new System.Drawing.Size(145, 45);
            this.btn_AbrirCaja.TabIndex = 3;
            this.btn_AbrirCaja.Text = "ABRIR CAJA";
            this.btn_AbrirCaja.UseVisualStyleBackColor = false;
            this.btn_AbrirCaja.Click += new System.EventHandler(this.btn_AbrirCaja_Click);
            // 
            // btn_CerrarCaja
            // 
            this.btn_CerrarCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_CerrarCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_CerrarCaja.FlatAppearance.BorderSize = 0;
            this.btn_CerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CerrarCaja.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CerrarCaja.Location = new System.Drawing.Point(368, 87);
            this.btn_CerrarCaja.MaximumSize = new System.Drawing.Size(145, 45);
            this.btn_CerrarCaja.MinimumSize = new System.Drawing.Size(145, 45);
            this.btn_CerrarCaja.Name = "btn_CerrarCaja";
            this.btn_CerrarCaja.Size = new System.Drawing.Size(145, 45);
            this.btn_CerrarCaja.TabIndex = 13;
            this.btn_CerrarCaja.Text = "CERRAR CAJA";
            this.btn_CerrarCaja.UseVisualStyleBackColor = false;
            this.btn_CerrarCaja.Visible = false;
            this.btn_CerrarCaja.Click += new System.EventHandler(this.btn_CerrarCaja_Click);
            // 
            // lbl_SaldoCaja
            // 
            this.lbl_SaldoCaja.AutoSize = true;
            this.lbl_SaldoCaja.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SaldoCaja.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SaldoCaja.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_SaldoCaja.Location = new System.Drawing.Point(6, 84);
            this.lbl_SaldoCaja.Name = "lbl_SaldoCaja";
            this.lbl_SaldoCaja.Size = new System.Drawing.Size(100, 16);
            this.lbl_SaldoCaja.TabIndex = 14;
            this.lbl_SaldoCaja.Text = "Saldo en Caja:";
            this.lbl_SaldoCaja.Visible = false;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_usuario.Location = new System.Drawing.Point(6, 61);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(61, 16);
            this.lbl_usuario.TabIndex = 17;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbox_egresos
            // 
            this.gbox_egresos.Controls.Add(this.button1);
            this.gbox_egresos.Controls.Add(this.label2);
            this.gbox_egresos.Controls.Add(this.txt_monto);
            this.gbox_egresos.Controls.Add(this.label1);
            this.gbox_egresos.Controls.Add(this.txt_descripcion);
            this.gbox_egresos.Enabled = false;
            this.gbox_egresos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_egresos.Location = new System.Drawing.Point(303, 153);
            this.gbox_egresos.Name = "gbox_egresos";
            this.gbox_egresos.Size = new System.Drawing.Size(267, 191);
            this.gbox_egresos.TabIndex = 18;
            this.gbox_egresos.TabStop = false;
            this.gbox_egresos.Text = "Salida de dinero";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(75, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "REGISTRAR EGRESO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monto(s/.) *";
            // 
            // txt_monto
            // 
            this.txt_monto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto.Location = new System.Drawing.Point(26, 86);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(195, 22);
            this.txt_monto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción *";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(26, 39);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(195, 22);
            this.txt_descripcion.TabIndex = 0;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_fecha.Location = new System.Drawing.Point(6, 14);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(54, 16);
            this.lbl_fecha.TabIndex = 19;
            this.lbl_fecha.Text = "Fecha :";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hora.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_hora.Location = new System.Drawing.Point(6, 37);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(128, 16);
            this.lbl_hora.TabIndex = 20;
            this.lbl_hora.Text = "Hora de Apertura:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(407, 14);
            this.button2.MaximumSize = new System.Drawing.Size(143, 33);
            this.button2.MinimumSize = new System.Drawing.Size(143, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Regresar ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(13, 22);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(51, 23);
            this.lbl_title.TabIndex = 10;
            this.lbl_title.Text = "CAJA";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.lbl_title);
            this.panel4.Location = new System.Drawing.Point(15, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(559, 65);
            this.panel4.TabIndex = 1009;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_hora);
            this.panel1.Controls.Add(this.lbl_SaldoCaja);
            this.panel1.Controls.Add(this.lbl_usuario);
            this.panel1.Controls.Add(this.lbl_fecha);
            this.panel1.Location = new System.Drawing.Point(15, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 121);
            this.panel1.TabIndex = 1010;
            // 
            // FrmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 360);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.gbox_egresos);
            this.Controls.Add(this.btn_CerrarCaja);
            this.Controls.Add(this.btn_AbrirCaja);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja";
            this.Activated += new System.EventHandler(this.FrmCaja_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCaja_FormClosing);
            this.Load += new System.EventHandler(this.FrmCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbox_egresos.ResumeLayout(false);
            this.gbox_egresos.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_AbrirCaja;
        private System.Windows.Forms.Button btn_CerrarCaja;
        private System.Windows.Forms.Label lbl_SaldoCaja;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.GroupBox gbox_egresos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
    }
}