using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevComponents.DotNetBar;
using GestorComercial;
using Capa_de_Presentacion.Properties;

namespace Capa_de_Presentacion
{
    public partial class FrmLogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        clsUsuarios U = new clsUsuarios();
    

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Está Seguro que Desea Salir.?", "Sistema de Ventas.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) {
                Application.Exit();
            }
               
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (Settings.Default["TecnicoUser"].ToString() == txtUser.Text &&
                Settings.Default["TecnicoPass"].ToString() == txtPassword.Text)
                {
                    FrmServer frmServer = new FrmServer();
                    frmServer.Show();
                    txtUser.Text = "";
                    txtPassword.Text = "";
                
                    return;
                }



            if (txtUser.Text.Trim() != "")
            {
                if (txtPassword.Text.Trim() != "")
                {
                    clsPreferences preferences  = new clsPreferences();
                    if (!preferences.getConnection())
                    {

                        MessageBox.Show("Error de Conexión : "+preferences.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                        
                   
                    String Mensaje = "";
                    U.User = txtUser.Text;
                    U.Password = txtPassword.Text;
                    Mensaje = U.IniciarSesion();
                    if (Mensaje == "Su Contraseña es Incorrecta.")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtPassword.Clear();
                        txtPassword.Focus();
                    }
                    else
                        if (Mensaje == "El Nombre de Usuario no Existe.")
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show(Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            txtUser.Clear();
                            txtPassword.Clear();
                            txtUser.Focus();
                        }
                        else
                        {
                            
                            FrmMenuPrincipal MP = new FrmMenuPrincipal();
                            try
                            {
                                RecuperarDatosSesion();
                                MP.Show();
                                this.Hide();
                            }
                            catch (Exception exception)
                            {
                                
                                if (!preferences.getConnection())
                                {
                                    MessageBox.Show("Error de Conexión: "+exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                
                                
                            }
                            
                            
                        }
                }else {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese su Contraseña.","Sistema de Ventas.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
            }else{
                DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Ingrese Nombre de Usuario.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
                }
        }

        private void RecuperarDatosSesion() {
            DataRow row;
            DataTable dt = new DataTable();
            dt = U.DevolverDatosSesion(txtUser.Text,txtPassword.Text);
            if (dt == null)
                throw new Exception("Error al recuperar los datos");
            if (dt.Rows.Count == 1) {
                row = dt.Rows[0];
                Program.IdEmpleadoLogueado = Convert.ToInt32(row[0].ToString());
                Program.NombreEmpleadoLogueado = row[1].ToString();
                Program.IdCargoEmpleadoLogueado = row[2].ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Activated(object sender, EventArgs e)
        {
           
        }
    }
}
