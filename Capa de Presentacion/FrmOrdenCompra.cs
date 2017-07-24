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
    public partial class FrmOrdenCompra : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmOrdenCompra()
        {
            InitializeComponent();
        }
        private void FrmRegistroProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if ((txt_nroDocumento.Text.Trim()!="" || rbn_guia.Checked )
                && txtCantidad.Text.Trim() != ""
                && txtTotal.Text.Trim() != "")
            {
                Program.ordenCompra.NroDocumento = txt_nroDocumento.Text;
                if (rbn_boleta.Checked)
                    Program.ordenCompra.TipoDocumento = "Boleta";
                if (rbn_factura.Checked)
                    Program.ordenCompra.TipoDocumento = "Factura";
                if (rbn_guia.Checked)
                    Program.ordenCompra.TipoDocumento = "Guia";
                Program.ordenCompra.Total = Double.Parse(txtTotal.Text);
                Program.ordenCompra.Cantidad = Int32.Parse(txtCantidad.Text);
                Program.ordenCompra.FechaRegistro = date_Fecha.Value.Date;

                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Los campos con (*) son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void rbn_guia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn_guia.Checked)
            {
                txt_nroDocumento.Text = "";
                txt_nroDocumento.Enabled = false;
            }
            else
            {
                txt_nroDocumento.Enabled = true;
            }
        }

        private void FrmOrdenCompra_Activated(object sender, EventArgs e)
        {
           
        }
    }
}
