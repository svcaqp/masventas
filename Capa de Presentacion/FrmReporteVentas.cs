using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Capa_de_Presentacion.Properties;
using CapaLogicaNegocio;

namespace Capa_de_Presentacion
{
    public partial class FrmReporteVentas : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmReporteVentas()
        {
            InitializeComponent();

        }

        private void FrmReporteVentas_Load(object sender, EventArgs e)
        {

            clsPreferences preferences = new clsPreferences();
            Settings.Default["DemoPracticaConnectionString1"] = preferences.getConnectionString();
            Settings.Default.Save();
            // TODO: esta línea de código carga datos en la tabla 'demoPracticaDataSet.Venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.demoPracticaDataSet.Venta);

        }
    }
}
