using Capa_de_Presentacion.Properties;
using GestorComercial;
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
    public partial class FrmAdministracion : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmAdministracion()
        {
            InitializeComponent();
            lbl_mensaje.Show(); 
        }

        private void FrmAdministracion_Load(object sender, EventArgs e)
        {
  
            // TODO: esta línea de código carga datos en la tabla 'demoPracticaCajasCerradas.CajasCerradas' Puede moverla o quitarla según sea necesario.
            this.cajasCerradasTableAdapter.Fill(this.demoPracticaCajasCerradas.CajasCerradas);
            // TODO: esta línea de código carga datos en la tabla 'demoPracticaCajasCerradas1.CajasCerradas' Puede moverla o quitarla según sea necesario.
        
            

            clsPreferences preferences = new clsPreferences();
            Settings.Default["DemoPracticaConnectionString1"] = preferences.getConnectionString();
            Settings.Default.Save();

            this.cajasCerradasTableAdapter.Fill(this.demoPracticaCajasCerradas.CajasCerradas);

            


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show(this, "¿Está Seguro que Desea Reaperturar esta Caja? ", "Sistema de Ventas.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                clsCaja caja = new clsCaja();
                caja.IdCaja = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                DevComponents.DotNetBar.MessageBoxEx.Show(this, caja.ReaperturarCaja(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.cajasCerradasTableAdapter.Fill(this.demoPracticaCajasCerradas.CajasCerradas);
            }
        }

        private void btn_caja_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Hide();
            gbox_caja.Show();
           
            gbox_informacion.Hide();
            gbox_seguridad.Hide();
            gbox_impresora.Hide();
            gbox_usuarios.Hide();
            label1.Show(); ;
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Hide();
            gbox_caja.Hide();
           
            gbox_informacion.Hide();
            gbox_seguridad.Hide();
            gbox_impresora.Hide();
            gbox_usuarios.Show();
            label1.Show(); ;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                MessageBox.Show("Eliminar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Hide();                
            gbox_caja.Hide();
        
            gbox_informacion.Show();
            gbox_seguridad.Hide();
            gbox_impresora.Hide();
            gbox_usuarios.Hide();
            label1.Hide();                 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_igv_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_empresa_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Hide();
            gbox_caja.Hide();
           
            gbox_informacion.Show();
            gbox_seguridad.Hide();
            gbox_impresora.Hide();
            gbox_usuarios.Hide();
            label1.Hide(); ;
        }

        private void btn_seguridad_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Hide();
            gbox_caja.Hide();
        
            gbox_informacion.Hide();
            gbox_seguridad.Show();
            gbox_impresora.Hide();
            gbox_usuarios.Hide();
            label1.Hide(); ;
        }

        private void btn_impresora_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Hide();
            gbox_caja.Hide();
            
            gbox_informacion.Hide();
            gbox_seguridad.Hide();
            gbox_impresora.Show();
            gbox_usuarios.Hide();
            label1.Hide(); ;
        }

        private void gbox_seguridad_Enter(object sender, EventArgs e)
        {

        }
    }
}
