﻿using Capa_de_Presentacion.Properties;
using GestorComercial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
           
  
            clsPreferences preferences = new clsPreferences();
            Settings.Default["DemoPracticaConnectionString1"] = preferences.getConnectionString();
            Settings.Default.Save();

            this.cajasCerradasTableAdapter.Fill(this.demoPracticaCajasCerradas.CajasCerradas);
            this.listarUsuariosTableAdapter.Fill(this.demoPracticaUsuarios.ListarUsuarios);

            


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
            gbox_licencia.Hide();
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
            gbox_licencia.Hide();
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
            gbox_licencia.Hide();
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
            gbox_licencia.Show();
            lbl_mensaje.Hide();
            gbox_caja.Hide();

            gbox_informacion.Hide();
            gbox_seguridad.Hide();
            gbox_impresora.Hide();
            gbox_usuarios.Hide();
            label1.Hide();

            clsEmpresa empresa = new clsEmpresa();


            if (!empresa.ProductoActivado() || empresa.codeLicencia == 1)
            {
                lbl_licencia_mensaje.Text = "El producto no se encuentra activado";
            }
            else
            {
                txt_licencia.Text = empresa.Licencia;
                lbl_licencia_mensaje.Text = "El producto se encuentra activado";
                txt_licencia.Enabled = false;
                btn_licencia.Enabled = false;
            }


        }

        private void btn_empresa_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Hide();
            gbox_caja.Hide();
           
            gbox_informacion.Show();
            gbox_seguridad.Hide();
            gbox_impresora.Hide();
            gbox_usuarios.Hide();
            gbox_licencia.Hide();
            label1.Hide();

            clsEmpresa empresa = new clsEmpresa();
            txt_nombre_empresa.Text = empresa.NombreEmpresa;
            txt_ruc_empresa.Text = empresa.RucEmpresa;
            txt_direccion_empresa.Text = empresa.DireccionEmpresa;
            txt_ciudad.Text = empresa.Ciudad;
            txt_factura.Text = empresa.FacturaCorrelativo+"";
            txt_boleta.Text = empresa.BoletaCorrelativo +"";
            txt_nota.Text = empresa.notaCorrelativo+"";
            txt_tasa.Text = empresa.TasaIgv + "";

        }

        private void btn_seguridad_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Hide();
            gbox_caja.Hide();
        
            gbox_informacion.Hide();
            gbox_seguridad.Show();
            gbox_impresora.Hide();
            gbox_usuarios.Hide();
            gbox_licencia.Hide();
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
            gbox_licencia.Hide();
            label1.Hide(); ;
        }

        private void gbox_seguridad_Enter(object sender, EventArgs e)
        {

        }

        private void btn_GuardarEmpresa_Click(object sender, EventArgs e)
        {
            clsEmpresa empresa = new clsEmpresa(
                txt_nombre_empresa.Text,txt_ruc_empresa.Text,txt_direccion_empresa.Text,
                txt_ciudad.Text,Convert.ToInt32(txt_factura.Text),Convert.ToInt32(txt_boleta.Text),
                Convert.ToInt32(txt_nota.Text), Convert.ToDouble(txt_tasa.Text));
            MessageBox.Show(empresa.RegistrarEmpresa());

        }

        private void btn_licencia_Click(object sender, EventArgs e)
        {
            clsEmpresa empresa = new clsEmpresa();
            empresa.Licencia = txt_licencia.Text;
            if (empresa.ValidarLicencia())
            {
                MessageBox.Show(empresa.RegistrarLicencia() );
                if (DevComponents.DotNetBar.MessageBoxEx.Show(this, "Debe reiniciar el sistema para efectuar los cambios", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK) {

                    Application.ExitThread();
                    }

            }
            else
                MessageBox.Show("No se pudo registrar el producto");
               
        }

        private void btn_copia_Click(object sender, EventArgs e)
        {
            //con is the connection string
            SqlConnection con = new SqlConnection(new clsPreferences().getConnectionString());
            con.Open();
            string str = "USE DemoPractica;";
            string str1 = "BACKUP DATABASE DemoPractica TO DISK = '" + txt_ruta.Text + "\\backupfile.Bak' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of DemoPractica';";
            SqlCommand cmd1 = new SqlCommand(str, con);
            SqlCommand cmd2 = new SqlCommand(str1, con);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("success");
            con.Close();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
