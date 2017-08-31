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
    public partial class FrmReportesAnulaciones : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmReportesAnulaciones()
        {
            InitializeComponent();
        }

        int IdProducto = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
 
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
                
            clsPreferences preferences = new clsPreferences();
            Settings.Default["DemoPracticaConnectionString1"] = preferences.getConnectionString();
            Settings.Default.Save();

        

        


            
        }

        private void button2_Click(object sender, EventArgs e)
        {


            
            this.ReporteAnulacionesTableAdapter.Fill(this.DemoPracticaAnulaciones.ReporteAnulaciones, date_inicial.Value, date_final.Value);

           // ReportParameter[] parameters = new ReportParameter[4];
            //parameters[0] = new ReportParameter("DiaInicio", date_final.Value.ToString().Substring(0,10));
            //parameters[1] = new ReportParameter("DiaFin", date_final.Value.ToString().Substring(0, 10));


            //this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    

        
    }
}




