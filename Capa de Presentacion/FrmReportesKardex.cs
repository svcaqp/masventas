using Capa_de_Presentacion.Properties;
using GestorComercial;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmReportesKardex : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmReportesKardex()
        {
            InitializeComponent();
        }

        int IdProducto = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'demoPracticaProductosDetalle.ListadoProductosDetalle' Puede moverla o quitarla según sea necesario.
            this.listadoProductosDetalleTableAdapter.Fill(this.demoPracticaProductosDetalle.ListadoProductosDetalle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
                
            clsPreferences preferences = new clsPreferences();
            Settings.Default["DemoPracticaConnectionString1"] = preferences.getConnectionString();
            Settings.Default.Save();

            this.productoTableAdapter.Fill(this.demoPracticaProducto.Producto);
        

        


            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            IdProducto = (int)cbox_productos.SelectedValue;
            
            this.ReporteKardexTableAdapter.Fill(this.DemoPracticaKardex.ReporteKardex, IdProducto, date_inicial.Value, date_final.Value);

            ReportParameter[] parameters = new ReportParameter[4];
            parameters[0] = new ReportParameter("DiaInicio", date_final.Value.ToString().Substring(0,10));
            parameters[1] = new ReportParameter("DiaFin", date_final.Value.ToString().Substring(0, 10));
            parameters[2] = new ReportParameter("Codigo", IdProducto +"");
            parameters[3] = new ReportParameter("Detalle", cbox_productos.Text);
            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        
    }
}




