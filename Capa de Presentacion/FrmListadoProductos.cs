﻿using System;
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

namespace Capa_de_Presentacion
{
    public partial class FrmListadoProductos : DevComponents.DotNetBar.Metro.MetroForm
    {
        int Listado = 0;
        private clsProducto P = new clsProducto();

        public FrmListadoProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 5000;
            CargarListado();
            dataGridView1.ClearSelection();
        }

        private void CargarListado() {
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            /*if (dataGridView1.SelectedRows.Count > 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("La Fila no debe Estar Seleccionada.");
                FrmRegistroProductos P = new FrmRegistroProductos();
                dataGridView1.ClearSelection();
                P.Show();
            }
            else
            {*/
                
                if (dataGridView1.SelectedRows.Count > 0)
                    Program.Evento = 1;
                else
                    Program.Evento = 0;
                dataGridView1.ClearSelection();
             
                //}
            }
        
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (Listado)
            {
                case 0: CargarListado(); break;        
            }
        }

        private void BusquedaProductos() {
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
            else {
                CargarListado();
                timer1.Start();
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13){
             if(dataGridView1.SelectedRows.Count>0)
            dataGridView1.ClearSelection();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
                Program.IdProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Program.Descripcion = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Program.Marca = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Program.Unidad = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                Program.PrecioVenta = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                Program.Stock = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                this.Close();
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
