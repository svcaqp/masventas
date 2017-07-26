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
    public partial class Frmregresar : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Frmregresar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.frmAlmacen.Close();
            Program.frmRegistroProductos.Close();
            Program.frmregresar.Close();
            Program.frmCategoria.Close();
            try
            {
                Program.frmEditarProducto.Close();
            }
            catch { }
            
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
