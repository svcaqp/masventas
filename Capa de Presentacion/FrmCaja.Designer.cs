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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_AbrirCaja = new System.Windows.Forms.Button();
            this.btn_CerrarCaja = new System.Windows.Forms.Button();
            this.lbl_SaldoCaja = new System.Windows.Forms.Label();
            this.btn_Egresos = new System.Windows.Forms.Button();
            this.lbl_usuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.btn_AbrirCaja.Location = new System.Drawing.Point(214, 54);
            this.btn_AbrirCaja.Name = "btn_AbrirCaja";
            this.btn_AbrirCaja.Size = new System.Drawing.Size(124, 39);
            this.btn_AbrirCaja.TabIndex = 3;
            this.btn_AbrirCaja.Text = "Abrir Caja";
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
            this.btn_CerrarCaja.Location = new System.Drawing.Point(214, 30);
            this.btn_CerrarCaja.Name = "btn_CerrarCaja";
            this.btn_CerrarCaja.Size = new System.Drawing.Size(124, 39);
            this.btn_CerrarCaja.TabIndex = 13;
            this.btn_CerrarCaja.Text = "Cerrar Caja";
            this.btn_CerrarCaja.UseVisualStyleBackColor = false;
            this.btn_CerrarCaja.Visible = false;
            this.btn_CerrarCaja.Click += new System.EventHandler(this.btn_CerrarCaja_Click);
            // 
            // lbl_SaldoCaja
            // 
            this.lbl_SaldoCaja.AutoSize = true;
            this.lbl_SaldoCaja.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SaldoCaja.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SaldoCaja.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_SaldoCaja.Location = new System.Drawing.Point(78, 183);
            this.lbl_SaldoCaja.Name = "lbl_SaldoCaja";
            this.lbl_SaldoCaja.Size = new System.Drawing.Size(93, 16);
            this.lbl_SaldoCaja.TabIndex = 14;
            this.lbl_SaldoCaja.Text = "Saldo en Caja:";
            this.lbl_SaldoCaja.Visible = false;
            // 
            // btn_Egresos
            // 
            this.btn_Egresos.BackColor = System.Drawing.Color.Orange;
            this.btn_Egresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Egresos.FlatAppearance.BorderSize = 0;
            this.btn_Egresos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Egresos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Egresos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Egresos.Location = new System.Drawing.Point(214, 81);
            this.btn_Egresos.Name = "btn_Egresos";
            this.btn_Egresos.Size = new System.Drawing.Size(124, 39);
            this.btn_Egresos.TabIndex = 16;
            this.btn_Egresos.Text = "Egresos";
            this.btn_Egresos.UseVisualStyleBackColor = false;
            this.btn_Egresos.Visible = false;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_usuario.Location = new System.Drawing.Point(78, 157);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(56, 16);
            this.lbl_usuario.TabIndex = 17;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // FrmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 231);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.btn_Egresos);
            this.Controls.Add(this.lbl_SaldoCaja);
            this.Controls.Add(this.btn_CerrarCaja);
            this.Controls.Add(this.btn_AbrirCaja);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja";
            this.Activated += new System.EventHandler(this.FrmCaja_Load);
            this.Load += new System.EventHandler(this.FrmCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_AbrirCaja;
        private System.Windows.Forms.Button btn_CerrarCaja;
        private System.Windows.Forms.Label lbl_SaldoCaja;
        private System.Windows.Forms.Button btn_Egresos;
        private System.Windows.Forms.Label lbl_usuario;
    }
}