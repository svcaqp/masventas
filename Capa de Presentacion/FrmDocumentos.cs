using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestorComercial;

namespace Capa_de_Presentacion
{
    public partial class FrmDocumentos : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmDocumentos()
        {
            InitializeComponent();
        }


       

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.listarDocumentosTableAdapter.Fill(this.demoPracticaDocumentos.ListarDocumentos,
                    cbox_Documentos.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void data_facturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                if (DevComponents.DotNetBar.MessageBoxEx.Show(this, "¿Está Seguro que Desea Anular este Documento? ", "Sistema de Ventas.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    
                    clsDocumento documento = null;
                    if (cbox_Tipo.SelectedIndex == 0)
                    {
                        string iddocumento = data_documentos.CurrentRow.Cells[0].Value.ToString();
                        documento = new clsDocumento(iddocumento, "Venta");
                    }
                    if (cbox_Tipo.SelectedIndex == 1)
                    {
                        string iddocumento = data_compras.CurrentRow.Cells[0].Value.ToString();
                        documento = new clsDocumento(iddocumento, "Compra");
                    }
                    if (cbox_Tipo.SelectedIndex == 2)
                    {
                        string iddocumento = data_pagos.CurrentRow.Cells[0].Value.ToString();
                        documento = new clsDocumento(iddocumento, "Pago");
                    }
                    if(documento != null)
                        System.Windows.Forms.MessageBox.Show(documento.AnularDocumento());

                    if (cbox_Tipo.SelectedIndex == 0)
                    {
                        this.listarDocumentosTableAdapter.Fill(this.demoPracticaDocumentos.ListarDocumentos,
                       cbox_Documentos.Text);

                    }
                    if (cbox_Tipo.SelectedIndex == 1)
                    {
                        this.listarComprasTableAdapter.Fill(this.demoPracticaCompras.ListarCompras);
                    }
                    if (cbox_Tipo.SelectedIndex == 2)
                    {
                        this.listarPagosTableAdapter.Fill(this.demoPracticaPagos.ListarPagos);
                    }

                    

                }
            }
        }

        private void fillToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbox_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_mensaje.Visible = false;
            if (cbox_Tipo.SelectedIndex == 0)
            {
                
                cbox_Documentos.Visible = true;
                btn_Buscar.Visible = true;
                data_documentos.Visible = true;
                data_compras.Visible = false;
                data_pagos.Visible = false;
            }
            if (cbox_Tipo.SelectedIndex == 1)
            {

                cbox_Documentos.Visible = false;
                btn_Buscar.Visible = false;
                this.listarComprasTableAdapter.Fill(this.demoPracticaCompras.ListarCompras);
                data_documentos.Visible = false;
                data_compras.Visible = true;
                data_pagos.Visible = false;
            }
            if (cbox_Tipo.SelectedIndex == 2)
            {

                this.listarPagosTableAdapter.Fill(this.demoPracticaPagos.ListarPagos);
                cbox_Documentos.Visible = false;
                btn_Buscar.Visible = false;
                data_documentos.Visible = false;
                data_compras.Visible = false;
                data_pagos.Visible = true;
            }
            
        }

        private void FrmDocumentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'demoPracticaPagos.ListarPagos' Puede moverla o quitarla según sea necesario.
            
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
