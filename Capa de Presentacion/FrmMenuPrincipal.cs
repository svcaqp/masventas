using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio;
using DevComponents.DotNetBar;

namespace Capa_de_Presentacion
{
    public partial class FrmMenuPrincipal : DevComponents.DotNetBar.Metro.MetroForm
    {
        int EnviarFecha = 0;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            lblUsuario.Text = Program.NombreEmpleadoLogueado;
            clsCaja caja = new clsCaja(Program.IdEmpleadoLogueado + "");
            
            if (caja.IdCaja != null)
            {
                
                Program.SaldoAbierto = caja.SaldoAbierto;
                btn_AbrirCaja.Hide();
                lbl_saldoCaja.Text = Program.SaldoAbierto + " S/.";
                lbl_saldoCaja.Show();
                lbl_titleSaldoCaja.Show();
                btnVentas.Enabled = true;
                lbl_CajaCerrada.Hide();
                btn_CerrarCaja.Show();
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
                btnReportes.Hide();
                btnUsuarios.Hide();
                lbl_TipodeUsuario.Text = "Trabajador";

            }






        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmListadoProductos P = new FrmListadoProductos();
            P.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmListadoClientes C = new FrmListadoClientes();
            C.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmRegistroVentas V = new FrmRegistroVentas();
            V.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuarios U = new FrmRegistrarUsuarios();
            U.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(EnviarFecha){
                case 0: CapturarFechaSistema(); break;
            }
        }

        private void CapturarFechaSistema() {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmListadoEmpleados E = new FrmListadoEmpleados();
            E.Show();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes R = new FrmReportes();
            R.Show();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_AbrirCaja_Click(object sender, EventArgs e)
        {
            FrmAbrirCaja cajaForm = new FrmAbrirCaja();
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

            clsCaja caja = new clsCaja(Program.IdEmpleadoLogueado + "") 
                                        {SaldoCerrado = Program.SaldoAbierto};
            caja.CerrarCaja();
            Program.IdCaja = null;
            Program.SaldoAbierto = 0;
            btn_AbrirCaja.Hide();
            lbl_saldoCaja.Hide();
            lbl_titleSaldoCaja.Hide();
            Panel_items.Hide();
            lbl_CajaCerrada.Show();
            btn_CerrarCaja.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_saldoCaja_Click(object sender, EventArgs e)
        {

        }
    }
}
