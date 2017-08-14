using GestorComercial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Capa_de_Presentacion
{
    public partial class FrmTutorial : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmTutorial()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "ManualInstalacion.docx");
            Process.Start(pdfPath);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "Manual_VendeMas.pdf");
           Process.Start(pdfPath);
        }
    }
}
