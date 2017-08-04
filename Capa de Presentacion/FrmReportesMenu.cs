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
    public partial class FrmReportesMenu : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmReportesMenu()
        {
            InitializeComponent();
        }

        private void btn_reporteventas_Click(object sender, EventArgs e)
        {
            FrmReportesVentas reporte = new FrmReportesVentas();
            reporte.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmReportesKardex reporte = new FrmReportesKardex();
            reporte.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
