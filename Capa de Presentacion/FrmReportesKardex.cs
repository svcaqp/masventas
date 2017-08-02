using Capa_de_Presentacion.Properties;
using CapaLogicaNegocio;
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
           
      

            clsPreferences preferences = new clsPreferences();
            Settings.Default["DemoPracticaConnectionString1"] = preferences.getConnectionString();
            Settings.Default.Save();

            this.productoTableAdapter.Fill(this.demoPracticaProducto.Producto);
        

        


            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            IdProducto = (int)cbox_productos.SelectedValue;
            
            this.ReporteKardexTableAdapter.Fill(this.DemoPracticaKardex.ReporteKardex, IdProducto, date_inicial.Value, date_final.Value);
           
            this.reportViewer1.RefreshReport();
            
        }

    

        
    }
}




