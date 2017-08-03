using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestorComercial;
using System.Globalization;
using DevComponents.DotNetBar;

namespace Capa_de_Presentacion
{
    public partial class FrmAlmacen : DevComponents.DotNetBar.Metro.MetroForm
    {
        int Listado = 0;
        private clsProducto P = new clsProducto();

        private clsCategoria C = new clsCategoria();
        private int cat_index = -1;

        public bool EditarFlag = false;

        public FrmAlmacen()
        {
            InitializeComponent();
            
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
           

            Program.frmAlmacen = this;

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

            ListarElementos();
            CargarListado();
            dataGridView1.ClearSelection();


        }

        private void ListarElementos()
        {
            if (IdProduct.Text.Trim() != "")
            {
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.ValueMember = "IdCategoria";
                cbxCategoria.DataSource = C.Listar();
                cbxCategoria.SelectedValue = IdProduct.Text;

               
            }
            else
            {
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.ValueMember = "IdCategoria";
                cbxCategoria.DataSource = C.Listar();
            }

            cbox_ListaCategorias.DisplayMember = "Descripcion";
            cbox_ListaCategorias.ValueMember = "IdCategoria";
            cbox_ListaCategorias.DataSource = C.Listar();




           


        }

        public void CargarListado()
        {
            DataTable dt = new DataTable();
            dt = P.Listar();
            try
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = Convert.ToDateTime(dt.Rows[i][7].ToString()).ToShortDateString();
                    dataGridView1.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                FrmEditarProducto P = new FrmEditarProducto();
                P.txtIdP.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                P.IdC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                P.txtProducto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                P.txtMarca.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                P.txtPCompra.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                P.txtPVenta.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                P.txtStock.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                P.dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                P.actualStock = Int32.Parse(P.txtStock.Text);
                P.actualPCompra = Double.Parse(P.txtPCompra.Text);
                P.txtUnidad.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
               
                
                P.Show();
                
                dataGridView1.ClearSelection();
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(this,"Debe Seleccionar la Fila a Editar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       

        private void BusquedaProductos()
        {
            DataTable dt = new DataTable();
            try
            {
                P.Marca = txtBuscarProducto.Text;
                dt = P.BusquedaProductos(P.Marca);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = Convert.ToDateTime(dt.Rows[i][7].ToString()).ToShortDateString();
                    dataGridView1.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
        }
        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BusquedaProductos();
     
            }
            else
            {
                CargarListado();
      
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                    dataGridView1.ClearSelection();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            EditarFlag = true;
            try
            {
                Program.frmEditarProducto.txtIdP.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Program.frmEditarProducto.IdC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Program.frmEditarProducto.txtProducto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Program.frmEditarProducto.txtMarca.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Program.frmEditarProducto.txtPCompra.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Program.frmEditarProducto.txtPVenta.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Program.frmEditarProducto.txtStock.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Program.frmEditarProducto.dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                Program.frmEditarProducto.actualStock = Int32.Parse(Program.frmEditarProducto.txtStock.Text);
                Program.frmEditarProducto.actualPCompra = Double.Parse(Program.frmEditarProducto.txtPCompra.Text);
                Program.frmEditarProducto.txtUnidad.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                Program.frmEditarProducto.Show();
                Program.frmEditarProducto.Focus();
            }
            catch
            {
                Program.frmEditarProducto = new FrmEditarProducto();
                Program.frmEditarProducto.txtIdP.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Program.frmEditarProducto.IdC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Program.frmEditarProducto.txtProducto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Program.frmEditarProducto.txtMarca.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Program.frmEditarProducto.txtPCompra.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Program.frmEditarProducto.txtPVenta.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Program.frmEditarProducto.txtStock.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Program.frmEditarProducto.dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                Program.frmEditarProducto.actualStock = Int32.Parse(Program.frmEditarProducto.txtStock.Text);
                Program.frmEditarProducto.actualPCompra = Double.Parse(Program.frmEditarProducto.txtPCompra.Text);
                Program.frmEditarProducto.txtUnidad.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                Program.frmEditarProducto.Show();
            }

          
                
                dataGridView1.ClearSelection();
            



            
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Program.nombreProduct = txtProducto.Text + " Marca : " + txtMarca.Text;
                cat_index = cbxCategoria.SelectedIndex;
                Program.frmOrdenCompra.Show();
               
            }
            catch
            {
                Program.frmOrdenCompra = new FrmOrdenCompra();
                Program.frmOrdenCompra.Show();
            }
        }


        private void Limpiar()
        {
            txtProducto.Text = "";
            txtMarca.Clear();
            txtPCompra.Text = "0.0";
            txtPVenta.Clear();
            txtUnidad.Clear();
            IdProduct.Clear();
            txtIdP.Clear();
            txtStock.Text = "0";
            dateTimePicker1.Value = DateTime.Now;
            txtProducto.Focus();
            Program.ordenCompra = new clsCompra();
            cbxCategoria.SelectedItem = null;
           
            

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
                                    P.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                                    P.Producto = txtProducto.Text;
                                    P.Marca = txtMarca.Text;
                                    P.Unidad = txtUnidad.Text;
                                    P.PrecioCompra = Convert.ToDecimal(txtPCompra.Text);
                                    P.PrecioVenta = Convert.ToDecimal(txtPVenta.Text, new CultureInfo("en-US"));
                                    P.Stock = Convert.ToInt32(txtStock.Text);
                                    P.FechaVencimiento = Convert.ToDateTime(dateTimePicker1.Value);

                                    Mensaje = P.RegistrarProductos(Program.ordenCompra);

                                    if (Mensaje == "Registrado Correctamente.")
                                    {
                                        DevComponents.DotNetBar.MessageBoxEx.Show(this, Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        Limpiar();
                                        this.CargarListado();
                                    }
                                    else
                                    {
                                        DevComponents.DotNetBar.MessageBoxEx.Show(this, Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Limpiar();
                                    }


                                  
                                }
                                else
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show(this, "Por Favor Ingrese Stock del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtStock.Focus();
                                }
                            }
                            else
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show(this, "Por Favor Ingrese Precio de Venta del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPVenta.Focus();
                            }
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show(this, "Por Favor Ingrese Precio de Compra del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPCompra.Focus();
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show(this, "Por Favor Ingrese Unidad del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUnidad.Focus();
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(this, "Por Favor Ingrese Marca del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMarca.Focus();
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(this, "Por Favor Ingrese Nombre del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProducto.Focus();
            }
        }

        private void OnlyDouble_KeyPress(object sender, KeyPressEventArgs e)
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

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            try { Program.frmOrdenCompra.Close(); }
            catch { }

            try { Program.frmEditarProducto.Close(); }
            catch { }

            

            this.Close();
        }

        private void FrmAlmacen_Activated(object sender, EventArgs e)
        {
            if (!EditarFlag)
            {
                txtStock.Text = Program.ordenCompra.Cantidad.ToString();
                if (Program.ordenCompra.Cantidad != 0)
                    txtPCompra.Text = Math.Round(Program.ordenCompra.Total, 1).ToString();
            }
        
        }

        private void btn_LimpiarRegistroProductos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show(this, "¿Está Seguro que Desea Eliminar la categoria? \n Se eliminarán todos los productos asociados", "Sistema de Ventas.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {

                clsCategoria categoria = new clsCategoria();
                categoria.IdC = Convert.ToInt32(cbox_ListaCategorias.SelectedValue);
                MessageBoxEx.Show(this, categoria.EliminarCategoria(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarElementos();
                CargarListado();
            }
           

        }

        private void LimpiarCategoria()
        {
            txtCategoria.Clear();
            txtCategoria.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clsCategoria C = new clsCategoria();
            String Mensaje = "";
            try
            {
                if (txtCategoria.Text.Trim() != "")
                {
                    if (Program.Evento == 0)
                    {
                        C.Descripcion = txtCategoria.Text;
                        Mensaje = C.RegistrarCategoria();
                        if (Mensaje == "Categoria ya se encuentra Registrada.")
                        {
                            MessageBoxEx.Show(this, Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBoxEx.Show(this, Mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListarElementos();
                        }

                    }
                    else
                    {
                        C.IdC = Convert.ToInt32(txt_IdCat.Text);
                        C.Descripcion = txtCategoria.Text;
                        MessageBoxEx.Show(this, C.ActualizarCategoria(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                    }
                }
                else
                {
                    MessageBoxEx.Show(this, "Por Favor Digíte Datos.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCategoria.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
            LimpiarCategoria();
            ListarElementos();
        }


    }
}
