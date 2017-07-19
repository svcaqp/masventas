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
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_server)).BeginInit();
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
            this.groupBox3.Location = new System.Drawing.Point(189, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 277);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conectividad";
            // 
            // btn_ProbarConexion
            // 
            this.btn_ProbarConexion.Location = new System.Drawing.Point(55, 217);
            this.btn_ProbarConexion.Name = "btn_ProbarConexion";
            this.btn_ProbarConexion.Size = new System.Drawing.Size(113, 29);
            this.btn_ProbarConexion.TabIndex = 12;
            this.btn_ProbarConexion.Text = "Verificar Conexión";
            this.btn_ProbarConexion.UseVisualStyleBackColor = true;
            this.btn_ProbarConexion.Click += new System.EventHandler(this.btn_ProbarConexion_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Password";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(23, 130);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(180, 20);
            this.txt_user.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Usuario";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(23, 169);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(180, 20);
            this.txt_pass.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Base de Datos";
            // 
            // txt_basedatos
            // 
            this.txt_basedatos.Location = new System.Drawing.Point(23, 83);
            this.txt_basedatos.Name = "txt_basedatos";
            this.txt_basedatos.Size = new System.Drawing.Size(180, 20);
            this.txt_basedatos.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "IP Servidor";
            // 
            // txt_server
            // 
            this.txt_server.Location = new System.Drawing.Point(23, 44);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(180, 20);
            this.txt_server.TabIndex = 12;
            // 
            // pbox_loading
            // 
            this.pbox_loading.Image = global::Capa_de_Presentacion.Properties.Resources.preloader;
            this.pbox_loading.Location = new System.Drawing.Point(15, 220);
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
            this.pbox_server.Location = new System.Drawing.Point(22, 63);
            this.pbox_server.Name = "pbox_server";
            this.pbox_server.Size = new System.Drawing.Size(142, 138);
            this.pbox_server.TabIndex = 11;
            this.pbox_server.TabStop = false;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 302);
            this.Controls.Add(this.pbox_loading);
            this.Controls.Add(this.pbox_server);
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.Name = "FrmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServer_FormClosed);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_server)).EndInit();
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
    }
}