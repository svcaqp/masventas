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
using CapaLogicaNegocio;
using System.Globalization;

namespace Capa_de_Presentacion
{
    public partial class FrmEditarProducto : DevComponents.DotNetBar.Metro.MetroForm
    {
        private clsCategoria C = new clsCategoria();
        private clsProducto P = new clsProducto();
        FrmOrdenCompra frm_orden_compra = new FrmOrdenCompra();

        public int actualStock = 0;
        public double actualPCompra = 0.0;

        private int cat_index = -1;

        public FrmEditarProducto()
        {
            InitializeComponent();
        }

        private void FrmRegistroProductos_Load(object sender, EventArgs e)
        {
            ListarElementos();
        }


   
        private void ListarElementos()
        {
            if (IdC.Text.Trim() != "")
            {
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.ValueMember = "IdCategoria";
                cbxCategoria.DataSource = C.Listar();
                cbxCategoria.SelectedValue = IdC.Text;
            }
            else
            {
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.ValueMember = "IdCategoria";
                cbxCategoria.DataSource = C.Listar();
            }

            
            
            
            txtStock.Text = (actualStock + Program.ordenCompra.Cantidad).ToString();
            
            if (Program.ordenCompra.Cantidad != 0)
            {
                txtPCompra.Text = Math.Round((actualPCompra + (Program.ordenCompra.Total / Program.ordenCompra.Cantidad)) / 2.0, 1).ToString();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String Mensaje = "";
            if (txtProducto.Text.Trim() != "")
            {
                if (txtMarca.Text.Trim() != "")
                {
                    if (txtUnidad.Text.Trim() != "")
                    {
                        if (txtPCompra.Text.Trim() != "")
                        {
                            if (txtPVenta.Text.Trim() != "")
                            {
                                if (txtStock.Text.Trim() != "")
                                {
                                    P.IdP = Convert.ToInt32(txtIdP.Text);
                                    P.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                                    P.Producto = txtProducto.Text;
                                    P.Marca = txtMarca.Text;
                                    P.Unidad = txtUnidad.Text;
                                    P.PrecioCompra = Convert.ToDecimal(txtPCompra.Text);
                                    if (txtPVenta.Text.Contains("."))
                                        P.PrecioVenta = Convert.ToDecimal(txtPVenta.Text, new CultureInfo("en-US"));
                                    else
                                        P.PrecioVenta = Convert.ToDecimal(txtPVenta.Text);

                                    P.Stock = Convert.ToInt32(txtStock.Text);
                                    P.FechaVencimiento = Convert.ToDateTime(dateTimePicker1.Value);

                                    Mensaje = P.ActualizarProductos(Program.ordenCompra);

                                    if (Mensaje == "Registro Actualizado Correctamente.")
                                    {
                                        DevComponents.DotNetBar.MessageBoxEx.Show(this, Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        Limpiar();
                                        Program.frmAlmacen.CargarListado();
                                    }
                                    else
                                    {
                                        DevComponents.DotNetBar.MessageBoxEx.Show(this, Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Limpiar();
                                    }
                                  
                                       
                                   
                                }
                                else
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show(this,"Por Favor Ingrese Stock del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtStock.Focus();
                                }
                            }
                            else
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show(this,"Por Favor Ingrese Precio de Venta del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPVenta.Focus();
                            }
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show(this,"Por Favor Ingrese Precio de Compra del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPCompra.Focus();
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show(this,"Por Favor Ingrese Unidad del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUnidad.Focus();
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(this,"Por Favor Ingrese Marca del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMarca.Focus();
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(this,"Por Favor Ingrese Nombre del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProducto.Focus();
            }
            FrmListadoProductos LP = new FrmListadoProductos();
            LP.timer1.Start();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Program.frmCategoria.Show();

        }

        private void Limpiar()
        {
            txtProducto.Text = "";
            txtMarca.Clear();
            txtPCompra.Clear();
            txtPVenta.Clear();
            txtUnidad.Clear();
            IdC.Clear();
            txtIdP.Clear();
            txtStock.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txtProducto.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            /*if (DevComponents.DotNetBar.MessageBoxEx.Show(this,"¿Está Seguro que Desea Salir.?", "Sistema de Ventas.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                this.Close();
            }*/
            this.Close();

        }

        private void txtPCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txtPCompra.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void txtPVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txtPVenta.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }



        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            //    e.Handled = false;
            //else
            //    e.Handled = true;
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cat_index = cbxCategoria.SelectedIndex;
                frm_orden_compra.Location = new Point(this.Location.X + 30, this.Location.Y + 30);
                frm_orden_compra.Show();
            }
            catch
            {
                frm_orden_compra = new FrmOrdenCompra();
                frm_orden_compra.Location = new Point(this.Location.X + 30, this.Location.Y + 30);
                frm_orden_compra.Show();
            }

        }

        private void FrmRegistroProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                frm_orden_compra.Close();
            }
            catch (Exception exeption)
            {
                Console.Write("FrmRegistroProductos_FormClosed" + exeption.Message);
            }
        }

        private void FrmRegistroProductos_Activated(object sender, EventArgs e)
        {
            ListarElementos();
            if (cat_index != -1)
            {
                cbxCategoria.SelectedIndex = cat_index;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show(this, "¿Está Seguro que Desea Eliminar el Producto?", "Sistema de Ventas.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                P.IdP = Convert.ToInt32(txtIdP.Text);
                
                DevComponents.DotNetBar.MessageBoxEx.Show(this, P.EliminarProducto(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.frmAlmacen.CargarListado();
                this.Close();
            }
        }

    }
}
