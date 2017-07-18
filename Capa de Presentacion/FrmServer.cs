using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaLogicaNegocio;

namespace Capa_de_Presentacion
{
    public partial class FrmServer : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmServer()
        {
            InitializeComponent();
            clsPreferences preferences = new clsPreferences();
           
            this.txt_server.Text = preferences.getServer();
            this.txt_basedatos.Text = preferences.getDatabase();
            this.txt_user.Text = preferences.getUser();
            this.txt_pass.Text = preferences.getPassword();
           
            
        }

        private void btn_ProbarConexion_Click(object sender, EventArgs e)
        {
            clsPreferences preferences = new clsPreferences();
            preferences.setServer(this.txt_server.Text);
            preferences.setDatabase(this.txt_basedatos.Text);
            preferences.setUser(this.txt_user.Text);
            preferences.setPassword(this.txt_pass.Text);
            preferences.SaveSettings();
            if (preferences.getConnection())
            {
                MessageBox.Show("El Servidor esta vivo", "Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
                this.Close();
            }
            else
                MessageBox.Show("Error de Conexión", "Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
       
        }
    }
}
