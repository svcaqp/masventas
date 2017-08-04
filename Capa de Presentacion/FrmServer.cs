using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using GestorComercial;

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
        public void VerifiedConnection()
        {
            try
            {
                clsPreferences preferences = new clsPreferences();
                preferences.setServer(this.txt_server.Text);
                preferences.setDatabase(this.txt_basedatos.Text);
                preferences.setUser(this.txt_user.Text);
                preferences.setPassword(this.txt_pass.Text);
                preferences.SaveSettings();
                if (preferences.getConnection())
                {
                    MessageBox.Show("El Servidor está vivo.", "Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                    MessageBox.Show("Error de Conexión : " + preferences.message, "Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.pbox_loading.Hide();
            }

            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread Abort Exception");
            }
            finally
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }

        private void btn_ProbarConexion_Click(object sender, EventArgs e)
        {
            pbox_loading.Show();
            CheckForIllegalCrossThreadCalls = false;
            ThreadStart childref = new ThreadStart(VerifiedConnection);
            
            Thread childThread = new Thread(childref);
            childThread.Start();

            


        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
       
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
