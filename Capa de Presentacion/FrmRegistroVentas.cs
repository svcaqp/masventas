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
using LibPrintTicket;

namespace Capa_de_Presentacion
{
    public partial class FrmRegistroVentas : DevComponents.DotNetBar.Metro.MetroForm
    {
        clsVentas Ventas = new clsVentas();
        clsDetalleVenta Detalle = new clsDetalleVenta();
        double documento = 0.0;

        private List<clsVenta> lst = new List<clsVenta>();

        public FrmRegistroVentas()
        {
            InitializeComponent();
            txtIgv.Visible = false;
            label12.Visible = false;
            rbnNotaVenta.Checked = true;
        }


        private void rbnFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnFactura.Checked == true)
            {
                lblTipo.Text = "FACTURA";
                txtIgv.Visible = true;
                txtIgv.Text = "18 %";
                label12.Visible = true;
                documento = 1.0;
                label5.Text = "RUC";
            }
            else if (rbnBoleta.Checked == true)
            {
                lblTipo.Text = "BOLETA DE VENTA";
                txtIgv.Visible = false;
                label12.Visible = false;
                documento = 0.0;
                label5.Text = "Doc. Identidad";
            }
            else
            {
                lblTipo.Text = "NOTA DE VENTA";
                txtIgv.Visible = false;
                label12.Visible = false;
                documento = 0.0;
                label5.Text = "Doc. Identidad";
            }
            LlenarGrilla();
            GenerarNumeroComprobante();
        }

        private void rbnBoleta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnFactura.Checked == true)
            {
                lblTipo.Text = "FACTURA";
                txtIgv.Visible = true;
                txtIgv.Text = "18 %";
                label12.Visible = true;
                documento = 1.0;
                label5.Text = "RUC";
            }
            else if (rbnBoleta.Checked == true)
            {
                lblTipo.Text = "BOLETA DE VENTA";
                txtIgv.Visible = false;
                label12.Visible = false;
                documento = 0.0;
                label5.Text = "Doc. Identidad";
            }
            else
            {
                lblTipo.Text = "NOTA DE VENTA";
                txtIgv.Visible = false;
                label12.Visible = false;
                documento = 0.0;
                label5.Text = "Doc. Identidad";
            }
            LlenarGrilla();
            GenerarNumeroComprobante();
        }
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            GenerarNumeroComprobante();
            GenerarIdVenta();
            GenerarSeriedeDocumento();
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void GenerarIdVenta()
        {
            txtIdVenta.Text = Ventas.GenerarIdVenta();
        }

        private void GenerarSeriedeDocumento()
        {
            lblSerie.Text = Ventas.GenerarSerieDocumento();
        }

        private void GenerarNumeroComprobante()
        {
            if (rbnNotaVenta.Checked == true)
                lblNroCorrelativo.Text = Ventas.NumeroComprobante("Nota");
            else if (rbnBoleta.Checked == true)
                lblNroCorrelativo.Text = Ventas.NumeroComprobante("Boleta");
            else
                lblNroCorrelativo.Text = Ventas.NumeroComprobante("Factura");
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            FrmListadoClientes C = new FrmListadoClientes();
            C.Show();
        }

        private void FrmVentas_Activated(object sender, EventArgs e)
        {
            txtDocIdentidad.Text = Program.DocumentoIdentidad;
            txtDatos.Text = Program.ApellidosCliente + ", " + Program.NombreCliente;
            txtIdProducto.Text = Program.IdProducto + "";
            txtDescripcion.Text = Program.Descripcion;
            txtUnidad.Text = Program.Unidad;
            txtMarca.Text = Program.Marca;
            txtStock.Text = Program.Stock + "";
            txtPVenta.Text = Program.PrecioVenta + "";
            
        }

        private void btnBusquedaProducto_Click(object sender, EventArgs e)
        {
            FrmListadoProductos P = new FrmListadoProductos();
            P.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsVenta V = new clsVenta();
            if (this.txtDocIdentidad.Text.Trim() != "")
            {
                if (txtDescripcion.Text.Trim() != "")
                    {
                   //if (txtUnidad.Text.Trim() != "")
                    //  {
                        if (txtCantidad.Text.Trim() != "")
                        {
                            if (Convert.ToInt32(txtCantidad.Text) > 0)
                            {
                                if (Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(txtStock.Text))
                                {
                                    V.IdProducto = Convert.ToInt32(txtIdProducto.Text);
                                    V.IdVenta = Convert.ToInt32(txtIdVenta.Text);
                                    V.Descripcion = txtDescripcion.Text + " - " + txtMarca.Text;
                                    V.Cantidad = Convert.ToInt32(txtCantidad.Text);
                                    V.PrecioVenta = Convert.ToDecimal(txtPVenta.Text);
                                    V.Igv = Math.Round(Convert.ToDecimal(txtPVenta.Text) * Convert.ToDecimal(0.18), 2);

                                    V.SubTotal = 0;
                                    lst.Add(V);
                                    LlenarGrilla();
                                    Limpiar();
                                }
                                else
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("Stock Insuficiente para Realizar la Venta.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                                }
                            }
                            else
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("Cantidad Ingresada no Válida.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                txtCantidad.Clear();
                                txtCantidad.Focus();
                            }
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Busque el Producto a Vender.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            txtCantidad.Focus();
                        }
                    }
                     else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Busque el Producto a Vender.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                 //   else
                   // {
                   //     DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Busque el Producto a Vender.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    //}
                //}
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Busque el Cliente a Vender.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        

        private void LlenarGrilla()
        {
            Decimal SumaSubTotal = 0; Decimal SumaIgv = 0; Decimal SumaTotal = 0;
            dataGridView1.Rows.Clear();
            if ((rbnBoleta.Checked == true) || (rbnNotaVenta.Checked == true))
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = lst[i].IdVenta;
                    dataGridView1.Rows[i].Cells[1].Value = lst[i].Cantidad;
                    dataGridView1.Rows[i].Cells[2].Value = lst[i].Descripcion;

                    dataGridView1.Rows[i].Cells[3].Value = lst[i].PrecioVenta;


                    dataGridView1.Rows[i].Cells[4].Value = lst[i].PrecioVenta * lst[i].Cantidad;
                    dataGridView1.Rows[i].Cells[5].Value = lst[i].IdProducto;
                    SumaSubTotal += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }

                dataGridView1.Rows.Add();
                dataGridView1.Rows.Add();
                dataGridView1.Rows.Add();
                dataGridView1.Rows.Add();
                dataGridView1.Rows[lst.Count + 3].Cells[3].Value = "     TOTAL     S/.";
                SumaTotal += SumaSubTotal;
                dataGridView1.Rows[lst.Count + 3].Cells[4].Value = SumaTotal;
                dataGridView1.ClearSelection();
            }
            else
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = lst[i].IdVenta;
                    dataGridView1.Rows[i].Cells[1].Value = lst[i].Cantidad;
                    dataGridView1.Rows[i].Cells[2].Value = lst[i].Descripcion;
                    decimal desc = (lst[i].PrecioVenta * Convert.ToDecimal(0.18));

                    dataGridView1.Rows[i].Cells[3].Value = lst[i].PrecioVenta - desc;

                    dataGridView1.Rows[i].Cells[4].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) * lst[i].Cantidad;
                    dataGridView1.Rows[i].Cells[5].Value = lst[i].IdProducto;

                    dataGridView1.Rows[i].Cells[6].Value = lst[i].Igv * lst[i].Cantidad;
                    SumaIgv += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
                    SumaSubTotal += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }

                dataGridView1.Rows.Add();
                dataGridView1.Rows.Add();
                dataGridView1.Rows[lst.Count + 1].Cells[3].Value = "SUB-TOTAL  S/.";
                dataGridView1.Rows[lst.Count + 1].Cells[4].Value = SumaSubTotal;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[lst.Count + 2].Cells[3].Value = "      I.G.V.        %";
                dataGridView1.Rows[lst.Count + 2].Cells[4].Value = SumaIgv;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[lst.Count + 3].Cells[3].Value = "     TOTAL     S/.";
                SumaTotal += SumaSubTotal + SumaIgv;
                dataGridView1.Rows[lst.Count + 3].Cells[4].Value = SumaTotal;
                dataGridView1.ClearSelection();
            }
        }


        private void Limpiar()
        {
            txtDescripcion.Clear();
            txtUnidad.Clear();
            txtMarca.Clear();
            txtStock.Clear();
            txtPVenta.Clear();
            txtCantidad.Clear();
            txtCantidad.Focus();
            Program.Descripcion = "";
            Program.Stock = 0;
            Program.Marca = "";
            Program.PrecioVenta = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Está Seguro que Desea Salir.?", "Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected == true)
                {
                    if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) != "")
                    {
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                        lst.RemoveAt(dataGridView1.CurrentRow.Index);
                        LlenarGrilla();
                        DevComponents.DotNetBar.MessageBoxEx.Show("Producto Eliminado de la Lista Ok.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No Existe Ningun Elemento en la Lista.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView1.ClearSelection();
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Por Favor Seleccione Item a Eliminar de la Lista.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No Existe Ningun Elemento en la Lista", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) != "")
                {
                    GuardarVenta();
                    try
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            Decimal SumaIgv = 0; Decimal SumaSubTotal = 0;
                            if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) != "")
                            {
                                SumaIgv += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
                                SumaSubTotal += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                                GuardarDetalleVenta(
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value),
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value),
                                Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value),
                                Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value),
                                SumaIgv, SumaSubTotal
                                );
                                //DevComponents.DotNetBar.MessageBoxEx.Show("Contiene Datos.");
                            }
                            else
                            {
                                //DevComponents.DotNetBar.MessageBoxEx.Show("Fila Vacia.");
                            }
                        }
                        Limpiar1();

                    }
                    catch (Exception ex)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No Existe Ningún Elemento en la Lista.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No Existe Ningún Elemento en la Lista.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarVenta()
        {
            decimal Total = 0;
            if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) != "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    Total = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }
                string TipoDocumento = "";
                if (rbnNotaVenta.Checked == true)
                    TipoDocumento = "Nota";
                else if (rbnBoleta.Checked == true)
                    TipoDocumento = "Boleta";
                else
                    TipoDocumento = "Factura";

                Ventas.IdEmpleado = Program.IdEmpleadoLogueado;
                Ventas.IdCliente = Program.IdCliente;
                Ventas.Serie = lblSerie.Text;
                Ventas.NroComprobante = lblNroCorrelativo.Text;
                Ventas.TipoDocumento = TipoDocumento;
                Ventas.FechaVenta = Convert.ToDateTime(dateTimePicker1.Value);
                Ventas.Total = Total;
                DevComponents.DotNetBar.MessageBoxEx.Show(Ventas.RegistrarVenta(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GuardarDetalleVenta(Int32 objIdProducto, Int32 objIdVenta, Int32 objCantidad, Decimal objPUnitario,
            Decimal objIgv, Decimal objSubTotal)
        {

            Detalle.IdProducto = objIdProducto;
            Detalle.IdVenta = objIdVenta;
            Detalle.Cantidad = objCantidad;
            Detalle.PUnitario = objPUnitario;
            Detalle.Igv = objIgv;
            Detalle.SubTotal = objSubTotal;
            Detalle.RegistrarDetalleVenta();

            GenerarIdVenta();

        }

        private void Limpiar1()
        {
            txtIgv.Clear();
            txtDocIdentidad.Clear();
            txtDatos.Clear();
            dataGridView1.Rows.Clear();
            Program.IdCliente = 0;
            txtIdProducto.Clear();
            rbnBoleta.Checked = true;
            rbnNotaVenta.Checked = true;
            rbnFactura.Checked = false;
            Program.DocumentoIdentidad = "";
            Program.ApellidosCliente = "";
            Program.NombreCliente = "";
            txtIgv.Clear();
            lst = new List<clsVenta>();
            GenerarNumeroComprobante();
            LlenarGrilla();
        }

        private void Imprimir()
        {
            Ticket ticket = new Ticket();
            ticket.FontSize = 7;
            ticket.AddHeaderLine("VENDEMAS");
            ticket.AddHeaderLine("EXPEDIDO EN: PREVEN PERU");
            ticket.AddHeaderLine("URB. ENTEL PERU C - 5");
            ticket.AddHeaderLine("YANAHUARA, AREQUIPA");
            ticket.AddHeaderLine("RUC:" + label3.Text);

            ticket.AddSubHeaderLine(lblTipo.Text + ": " + lblSerie.Text + "-" + lblNroCorrelativo.Text);
            ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());


            ticket.AddItem("Cant", "Nombre Producto", "Total");

            ticket.AddItem("", "", "");
            ticket.AddTotal("SUBTOTAL", "12");
            ticket.AddTotal("IVA", "0");
            ticket.AddTotal("TOTAL", "24");
            ticket.AddTotal("", "");
            ticket.AddTotal("RECIBIDO", "0");
            ticket.AddTotal("CAMBIO", "0");
            ticket.AddTotal("", "");

            ticket.AddFooterLine("VUELVA PRONTO");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");

            ticket.PrintTicket("Star SP500 Tear Bar (SP512)"); //Nombre de la impresora de tickets
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtIgv_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIdVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            Limpiar1();
            LlenarGrilla();
        }

        private void txtPVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rbnNotaVenta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnFactura.Checked == true)
            {
                lblTipo.Text = "FACTURA";
                txtIgv.Visible = true;
                txtIgv.Text = "18 %";
                label12.Visible = true;
                documento = 1.0;
                label5.Text = "RUC";
            }
            else if (rbnBoleta.Checked == true)
            {
                lblTipo.Text = "BOLETA DE VENTA";
                txtIgv.Visible = false;
                label12.Visible = false;
                documento = 0.0;
                label5.Text = "Doc. Identidad";
            }
            else
            {
                lblTipo.Text = "NOTA DE VENTA";
                txtIgv.Visible = false;
                label12.Visible = false;
                documento = 0.0;
                label5.Text = "Doc. Identidad";
            } 
            
            GenerarNumeroComprobante();

            //private void btnQuitar_Click(object sender, EventArgs e)
            //{
            //    DialogResult Resultado = new DialogResult();
            //    Resultado = DevComponents.DotNetBar.MessageBoxEx.Show("¿Está Seguro Que Desea Quitar Este Producto.?", "Sistema de Ventas.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //       if(Resultado==DialogResult.OK){
            //            try{	        
            //                foreach (DataGridViewRow row in dataGridView1.Rows)
            //                {
            //                    Boolean Activo=Convert.ToBoolean(row.Cells["Eliminar"].Value);
            //                    if(Activo){
            //                        for (int i = 0; i < dataGridView1.RowCount; i++)
            //                        {
            //                            dataGridView1.Rows.RemoveAt(i);
            //                        }
            //                    }
            //                }
            //            }catch (Exception ex){
            //                 DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
            //            }
            //       }
            //}

        }
    }
}