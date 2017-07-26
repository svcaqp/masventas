using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capa_de_Presentacion
{
    public partial class FrmCaja : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmCaja()
        {
            InitializeComponent();
        }

        private void FrmCaja_Load(object sender, EventArgs e)
        {
            lbl_usuario.Text = "Usuario : " + Program.NombreEmpleadoLogueado;
            clsCaja caja = new clsCaja(Program.IdEmpleadoLogueado + "");

            if (caja.IdCaja != null)
            {
                btn_AbrirCaja.Hide();
                btn_CerrarCaja.Show();
                btn_Egresos.Show();
                lbl_SaldoCaja.Show();
                lbl_SaldoCaja.Text = "Saldo en Caja: s/." + Program.SaldoAbierto + ".00";
            }

        }

        private void btn_AbrirCaja_Click(object sender, EventArgs e)
        {
           
            FrmAbrirCaja cajaForm = new FrmAbrirCaja();
            cajaForm.Show();
        }

        private void btn_CerrarCaja_Click(object sender, EventArgs e)
        {
            clsCaja caja = new clsCaja(Program.IdEmpleadoLogueado + "") { SaldoCerrado = Program.SaldoAbierto };
            caja.CerrarCaja();
            Program.IdCaja = null;
            Program.SaldoAbierto = 0;
            //Panel_items.Hide();
            //lbl_CajaCerrada.Show();
            this.Close();
        }
    }
}
