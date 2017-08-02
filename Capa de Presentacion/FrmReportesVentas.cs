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
    public partial class FrmReportesVentas : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmReportesVentas()
        {
            InitializeComponent();
        }

        int IdEmpleado = 0;
        int IdCliente = 0;
        string documento = "Factura";
        bool alldocumentos = false;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            

            clsPreferences preferences = new clsPreferences();
            Settings.Default["DemoPracticaConnectionString1"] = preferences.getConnectionString();
            Settings.Default.Save();


            cbox_documentos.SelectedIndex = 0;

            this.listarClientesTableAdapter1.Fill(this.demoPracticaClientes1.ListarClientes);
            // TODO: esta línea de código carga datos en la tabla 'demoPracticaEmpleados.ListarEmpleadosCompleto' Puede moverla o quitarla según sea necesario.
            this.listarEmpleadosCompletoTableAdapter.Fill(this.demoPracticaEmpleados.ListarEmpleadosCompleto);

            IdEmpleado = Convert.ToInt32(cbox_empleado.SelectedValue);
            IdCliente = Convert.ToInt32(cbox_cliente.SelectedValue);


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            if(alldocumentos){
                documento = "All";
            }

            this.ReporteVentasTableAdapter.Fill(this.DemoPracticaVentas.ReporteVentas, IdEmpleado, IdCliente, documento,date_inicial.Value, date_final.Value);
            this.reportViewer1.RefreshReport();
            
        }

        private void cbox_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (check_usuarios.Checked)
            {
                cbox_empleado.Enabled = false;
                IdEmpleado = 0;
            }
            else
            {
                cbox_empleado.Enabled = true;
                IdEmpleado = Convert.ToInt32(cbox_empleado.SelectedValue);
            }
        }

        private void check_documentos_CheckedChanged(object sender, EventArgs e)
        {

            if (check_documentos.Checked)
            {
                alldocumentos = true;
                cbox_documentos.Enabled = false;
            }
            else
            {
                alldocumentos = false;
                cbox_documentos.Enabled = true;
                documento = cbox_documentos.Text;
            }
        }

        private void check_clientes_CheckedChanged(object sender, EventArgs e)
        {

            if (check_clientes.Checked)
            {
                IdCliente = 0;
                cbox_cliente.Enabled = false;
            }
            else
            {
                cbox_cliente.Enabled = true;
                IdCliente = Convert.ToInt32(cbox_cliente.SelectedValue);
            }

        }

        private void cbox_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdEmpleado = Convert.ToInt32(cbox_empleado.SelectedValue);
        }

        private void cbox_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdCliente = Convert.ToInt32(cbox_cliente.SelectedValue);
        }

        private void cbox_documentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                documento = cbox_documentos.Text;
                if (documento == "Nota de venta")
                    documento = "Nota";
                if (documento == "Nota" || documento == "Boleta")
                    cbox_cliente.Enabled = false;
                else
                    cbox_cliente.Enabled = true;
            }
            catch
            {

            }
        }
    }
}




