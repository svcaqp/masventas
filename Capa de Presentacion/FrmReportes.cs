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
    public partial class FrmReportes : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DemoPracticaVentas.Venta' Puede moverla o quitarla según sea necesario.
            this.VentaTableAdapter.Fill(this.DemoPracticaVentas.Venta);
            // TODO: esta línea de código carga datos en la tabla 'DataSetReporteProductos.Cliente' Puede moverla o quitarla según sea necesario.
            

            this.reportViewer1.RefreshReport();
        }
    }
}




