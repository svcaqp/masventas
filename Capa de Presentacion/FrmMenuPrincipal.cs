using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorComercial;
using DevComponents.DotNetBar;
using Capa_de_Presentacion.Properties;

namespace Capa_de_Presentacion
{
    public partial class FrmMenuPrincipal : DevComponents.DotNetBar.Metro.MetroForm
    {
        int EnviarFecha = 0;

        public FrmMenuPrincipal()
        {
            InitializeComponent();

            

            pictureBox1.Location = new Point((Screen.FromControl(this).Bounds.Width - pictureBox1.Size.Width) / 2, pictureBox1.Location.Y);
            Panel_items.Location = new Point((Screen.FromControl(this).Bounds.Width - Panel_items.Size.Width) / 2, (Screen.FromControl(this).Bounds.Height - Panel_items.Size.Height) / 2);


        }


        bool active = false;
        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
    
                

            lblUsuario.Text = Program.NombreEmpleadoLogueado;
            clsCaja caja = new clsCaja(Program.IdEmpleadoLogueado + "");

            if (caja.IdCaja != null)
            {

                Program.SaldoAbierto = caja.SaldoAbierto ;
             
                btnVentas.Enabled = true;
                lbl_CajaCerrada.Hide();
 
            }
            else
            {
                btnVentas.Enabled = false;
                lbl_CajaCerrada.Show();
            }
            if (Program.IdCargoEmpleadoLogueado == "1")
            {
                lbl_TipodeUsuario.Text = "Administrador";
            }

            if (Program.IdCargoEmpleadoLogueado == "2")
            {
                btnEmpleados.Hide();
                
                btnProductos.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                btnReportes.Hide();
                btnUsuarios.Hide();
                                                    
                lbl_TipodeUsuario.Text = "Trabajador";

            }







        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            clsEmpresa empresa = new clsEmpresa();

            if (!empresa.ProductoActivado())
            {
                MessageBox.Show("Error de Activacion ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            Program.frmAlmacen = new FrmAlmacen();
            Program.frmAlmacen.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {


            Program.frmClientes = new FrmListadoClientes();
            Program.frmClientes.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            clsEmpresa empresa = new clsEmpresa();

            if (!empresa.ProductoActivado())
            {
                MessageBox.Show("Error de Activacion ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            clsCaja caja = new clsCaja(Program.IdEmpleadoLogueado + "");
            string fechacaja = caja.FechaAbierto.Substring(0, 10);
            string fechaactual = DateTime.Now.ToString("dd/MM/yyyy");
            if (fechacaja != fechaactual)
                DevComponents.DotNetBar.MessageBoxEx.Show(this, "La caja no se cerro correctamente para el dia : "+caja.FechaAbierto.Substring(0, 10), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                FrmRegistroVentas V = new FrmRegistroVentas();
                V.Show();
            }
             
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
           
            Program.frmAdministracion = new FrmAdministracion();
            Program.frmAdministracion.Show();


         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (EnviarFecha)
            {
                case 0: CapturarFechaSistema(); break;
            }
        }

        private void CapturarFechaSistema()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            
            Program.frmEmpleados = new FrmListadoEmpleados();
            Program.frmEmpleados.Show();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try{ Program.frmCaja.Close();} catch { }
            try { Program.frmClientes.Close(); } catch { }
            try { Program.frmEmpleados.Close(); }catch { }
            try { Program.frmAlmacen.Close(); } catch { }
            try { Program.frmAdministracion.Close(); } catch { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            clsEmpresa empresa = new clsEmpresa();

            if (!empresa.ProductoActivado())
            {
                MessageBox.Show("Error de Activacion ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Program.frmReportes  = new FrmReportesMenu();
            Program.frmReportes.Show();

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_AbrirCaja_Click(object sender, EventArgs e)
        {
            
            FrmCaja cajaForm = new FrmCaja();
            cajaForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLogin loginForm = new FrmLogin();
            loginForm.Show();
            this.Close();
        }

        private void btn_CerrarCaja_Click(object sender, EventArgs e)
        {

            clsCaja caja = new clsCaja(Program.IdEmpleadoLogueado + "") { SaldoCerrado = Program.SaldoAbierto };
            caja.CerrarCaja();
            Program.IdCaja = null;
            Program.SaldoAbierto = 0;
            Panel_items.Hide();
            lbl_CajaCerrada.Show();
    
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenuCaja_Click(object sender, EventArgs e)
        {
            clsEmpresa empresa = new clsEmpresa();

            if (!empresa.ProductoActivado())
            {
                MessageBox.Show("Error de Activacion ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Program.frmCaja = new FrmCaja();
            Program.frmCaja.Show();
        }

        private void lbl_CajaCerrada_Click(object sender, EventArgs e)
        {

        }

        private void btnDocumentos_Click(object sender, EventArgs e)
        {
            clsEmpresa empresa = new clsEmpresa();

            if (!empresa.ProductoActivado())
            {
                MessageBox.Show("Error de Activacion ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            Program.frmDocumentos = new  FrmDocumentos();
            Program.frmDocumentos.Show();

        }

        private void Panel_items_Paint(object sender, PaintEventArgs e)
        {

        }



       

    }
}
