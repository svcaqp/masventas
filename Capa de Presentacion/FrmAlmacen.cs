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
    public partial class FrmAlmacen : DevComponents.DotNetBar.Metro.MetroForm
    {
        int Listado = 0;
        private clsProducto P = new clsProducto();

        public FrmAlmacen()
        {
            InitializeComponent();
            
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            this.Location = new Point(1, 1);
            
            int window_width = Convert.ToInt32(Screen.FromControl(this).Bounds.Width-472);
            int window_height = Convert.ToInt32(Screen.FromControl(this).Bounds.Height -66);
            this.Size = new System.Drawing.Size(window_width, window_height);


            int control_height = Convert.ToInt32(this.Size.Height*0.75);
            int control_width = Convert.ToInt32(this.Size.Width*0.95);
            this.panel1.Size = new System.Drawing.Size(control_width, control_height);
            this.dataGridView1.Size = new System.Drawing.Size(control_width, control_height);

            


            NuevoProducto();

            Program.frmRegistroProductos.Location = new Point(this.Size.Width + 5, 96);

            FormRegresar();
            Program.frmregresar.Location = new Point(this.Size.Width + 5, this.Location.Y);
            CargarListado();
            dataGridView1.ClearSelection();
            Program.frmAlmacen = this;

            Program.frmCategoria = new FrmRegistrarCategoria();
            Program.frmCategoria.Location = new Point(this.Size.Width + 5, Program.frmRegistroProductos.Size.Height + 101);
            Program.frmCategoria.Show();

            Program.ordenCompra = new clsCompra();



            //Program.frmCategoria.Hide();

            


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
                timer1.Stop();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoProducto()
        {
            
            Program.frmRegistroProductos = new FrmRegistroProductos();
            dataGridView1.ClearSelection();
            Program.frmRegistroProductos.Show();

        }

        private void FormRegresar()
        {

            Program.frmregresar = new Frmregresar();
            Program.frmregresar.Show();

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (Listado)
            {
                case 0: CargarListado(); break;
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
                timer1.Stop();
            }
            else
            {
                CargarListado();
                timer1.Start();
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

            dataGridView1.ClearSelection();



            
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
