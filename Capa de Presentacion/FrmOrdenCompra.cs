using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            this.lbl_nombreProducto.Text = "PRODUCTO: " + Program.nombreProduct;
            this.lbl_MarcaProducto.Text = "MARCA: " + Program.marcaProduct;
        }

        public void LimpiarOrdenCompra()
        {
            txt_nroDocumento.Clear();
            txtCantidad.Clear();
            txtIdP.Clear();
            txtTotal.Clear();
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

                Program.ordenCompra.Total = Convert.ToDouble(txtTotal.Text, new CultureInfo("en-US"));
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
                txt_nroDocumento.BackColor = System.Drawing.SystemColors.ControlLight;
            }
            else
            {
                txt_nroDocumento.Enabled = true;
                txt_nroDocumento.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            }
        }

        private void FrmOrdenCompra_Activated(object sender, EventArgs e)
        {
            this.lbl_nombreProducto.Text = "PRODUCTO: " + Program.nombreProduct;
            this.lbl_MarcaProducto.Text = "MARCA: " + Program.marcaProduct;
        }

        private void OnlyDouble_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tBox = (TextBox)sender;

            if (!((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
               || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
               || (e.KeyCode == Keys.Decimal && !(tBox.Text.Contains('.'))
                   && !(tBox.Text.Length == 0)
                   && !((tBox.Text.Length == 1)
                      && (tBox.Text.Contains('-') || tBox.Text.Contains('+'))))
               || (e.KeyCode == Keys.OemPeriod && !(tBox.Text.Contains('.'))
                   && !(tBox.Text.Length == 0)
                   && !((tBox.Text.Length == 1)
                      && (tBox.Text.Contains('-') || tBox.Text.Contains('+'))))
               || (e.KeyCode == Keys.Subtract && ((tBox.Text.Length == 0) ||
                   tBox.Text.EndsWith("e") || tBox.Text.EndsWith("E")))
               || (e.KeyCode == Keys.OemMinus && ((tBox.Text.Length == 0) ||
                   tBox.Text.EndsWith("e") || tBox.Text.EndsWith("E")))
               || (e.KeyCode == Keys.Add && ((tBox.Text.Length == 0) ||
                   tBox.Text.EndsWith("e") || tBox.Text.EndsWith("E")))
               || (e.KeyCode == Keys.Oemplus && ((tBox.Text.Length == 0) ||
                   tBox.Text.EndsWith("e") || tBox.Text.EndsWith("E")))
               || e.KeyCode == Keys.Delete
               || e.KeyCode == Keys.Back
               || e.KeyCode == Keys.Left
               || e.KeyCode == Keys.Right
               || (e.KeyCode == Keys.E) && !(tBox.Text.Contains('e')) &&
                   (tBox.Text.Contains('.') && !tBox.Text.EndsWith("."))))
            {
                e.SuppressKeyPress = true;
            }
            
                
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_nroDocumento.Text="";
            rbn_guia.Checked =true;
            txtCantidad.Clear();
            txtTotal.Clear();
            date_Fecha.Value = DateTime.Now;            
        }

        private void txt_nroDocumento_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void lbl_nombreProducto_Click(object sender, EventArgs e)
        {

        }

        private void txt_nroDocumento_TextChanged(object sender, EventArgs e)
        {

        }




    }
}
