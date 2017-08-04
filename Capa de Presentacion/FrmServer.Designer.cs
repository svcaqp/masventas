namespace Capa_de_Presentacion
{
    partial class FrmServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServer));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ProbarConexion = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_basedatos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.pbox_loading = new System.Windows.Forms.PictureBox();
            this.pbox_server = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_server)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btn_ProbarConexion);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_user);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_pass);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_basedatos);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_server);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(175, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 291);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conectividad ";
            // 
            // btn_ProbarConexion
            // 
            this.btn_ProbarConexion.Location = new System.Drawing.Point(89, 218);
            this.btn_ProbarConexion.Name = "btn_ProbarConexion";
            this.btn_ProbarConexion.Size = new System.Drawing.Size(98, 54);
            this.btn_ProbarConexion.TabIndex = 12;
            this.btn_ProbarConexion.Text = "&Verificar \r\nConexión";
            this.btn_ProbarConexion.UseVisualStyleBackColor = true;
            this.btn_ProbarConexion.Click += new System.EventHandler(this.btn_ProbarConexion_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 14);
            this.label13.TabIndex = 19;
            this.label13.Text = "PASSWORD:";
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_user.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(12, 132);
            this.txt_user.MaxLength = 29;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(249, 26);
            this.txt_user.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 14);
            this.label12.TabIndex = 17;
            this.label12.Text = "USUARIO: ";
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_pass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(12, 176);
            this.txt_pass.MaxLength = 29;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(249, 26);
            this.txt_pass.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 14);
            this.label11.TabIndex = 15;
            this.label11.Text = "BASE DE DATOS:";
            // 
            // txt_basedatos
            // 
            this.txt_basedatos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_basedatos.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_basedatos.Location = new System.Drawing.Point(12, 87);
            this.txt_basedatos.MaxLength = 29;
            this.txt_basedatos.Name = "txt_basedatos";
            this.txt_basedatos.Size = new System.Drawing.Size(249, 26);
            this.txt_basedatos.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 14);
            this.label9.TabIndex = 13;
            this.label9.Text = "IP SERVIDOR:";
            // 
            // txt_server
            // 
            this.txt_server.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_server.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_server.Location = new System.Drawing.Point(12, 44);
            this.txt_server.MaxLength = 29;
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(249, 26);
            this.txt_server.TabIndex = 12;
            // 
            // pbox_loading
            // 
            this.pbox_loading.Image = global::Capa_de_Presentacion.Properties.Resources.preloader;
            this.pbox_loading.Location = new System.Drawing.Point(8, 288);
            this.pbox_loading.Name = "pbox_loading";
            this.pbox_loading.Size = new System.Drawing.Size(161, 27);
            this.pbox_loading.TabIndex = 12;
            this.pbox_loading.TabStop = false;
            this.pbox_loading.Visible = false;
            this.pbox_loading.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbox_server
            // 
            this.pbox_server.Image = global::Capa_de_Presentacion.Properties.Resources.server;
            this.pbox_server.Location = new System.Drawing.Point(15, 131);
            this.pbox_server.Name = "pbox_server";
            this.pbox_server.Size = new System.Drawing.Size(142, 138);
            this.pbox_server.TabIndex = 11;
            this.pbox_server.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(15, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 52);
            this.panel4.TabIndex = 1011;
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
            this.button2.Location = new System.Drawing.Point(280, 10);
            this.button2.MaximumSize = new System.Drawing.Size(141, 33);
            this.button2.MinimumSize = new System.Drawing.Size(141, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Regresar ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 388);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pbox_loading);
            this.Controls.Add(this.pbox_server);
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(489, 426);
            this.MinimumSize = new System.Drawing.Size(489, 426);
            this.Name = "FrmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " CONFIGURACION TÉCNICA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServer_FormClosed);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_server)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_ProbarConexion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_basedatos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.PictureBox pbox_server;
        private System.Windows.Forms.PictureBox pbox_loading;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
    }
}