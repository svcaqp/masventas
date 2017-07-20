using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaLogicaNegocio;

namespace Capa_de_Presentacion
{
    public partial class FrmAbrirCaja : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmAbrirCaja()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            if (txt_cantidad.Text.Trim() != "")
            {
                clsCaja caja = new clsCaja(Program.IdEmpleadoLogueado.ToString(), Convert.ToDouble(txt_cantidad.Text));
                mensaje = caja.RegistrarCaja();
                DevComponents.DotNetBar.MessageBoxEx.Show(mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Program.IdCaja = caja.IdCaja;
                Program.SaldoAbierto = Convert.ToDouble(txt_cantidad.Text);
                this.Close();

            }
            else
            {
                mensaje = "Debe Ingresar la cantidad";
                DevComponents.DotNetBar.MessageBoxEx.Show(mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAbrirCaja_Load(object sender, EventArgs e)
        {

        }
    }
}
