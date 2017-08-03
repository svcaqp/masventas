using GestorComercial;
using LibPrintTicket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capa_de_Presentacion
{
    public partial class FrmCaja : DevComponents.DotNetBar.Metro.MetroForm
    {

        clsCaja caja = new clsCaja(Program.IdEmpleadoLogueado + "");
        public FrmCaja()
        {
            InitializeComponent();
        }

        public static string GetDateString(string date)
        {
            DateTime theDate;
            if (DateTime.TryParseExact(date, "dd/MM/yyyy H:mm:ss",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out theDate))
            {
                // the string was successfully parsed into theDate
                return theDate.ToString("yyyy'-'MM'-'dd");
            }
            else
            {
                // the parsing failed, return some sensible default value
                return "Couldn't read the date";
            }
        }
        private void FrmCaja_Load(object sender, EventArgs e)
        {
            lbl_usuario.Text = "Usuario : " + Program.NombreEmpleadoLogueado;
            clsCaja caja = new clsCaja(Program.IdEmpleadoLogueado + "");

            if (caja.BuscarCajaDia())
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(this, "Ya registro una caja para el dia de hoy \n Solicite al administrador una Reapertura", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

            if (caja.IdCaja != null)
            {
                
                btn_AbrirCaja.Hide();
                btn_CerrarCaja.Show();
                gbox_egresos.Enabled = true;
                lbl_SaldoCaja.Show();
                lbl_fecha.Text = "Fecha: " + GetDateString(caja.FechaAbierto);
                lbl_hora.Text = "Hora de Apertura: "+ caja.HoraAbierto;
                lbl_SaldoCaja.Text = "Saldo en Caja: s/." + string.Format("{0:N2}", (Program.SaldoAbierto + caja.TotalVendido() - caja.TotalPagos()));
            }

        }

        private void btn_AbrirCaja_Click(object sender, EventArgs e)
        {
           
            Program.frmAbrirCaja = new FrmAbrirCaja();
            Program.frmAbrirCaja.Show();
        }

        private void btn_CerrarCaja_Click(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show(this, "¿Está Seguro que Desea Cerrar la Caja? ", "Sistema de Ventas.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {


                caja.CerrarCaja();
                Ticket ticket = new Ticket();
            
                ticket.FontSize = 8;
                ticket.AddHeaderLine("CIERRE DE CAJA");
                ticket.AddHeaderLine("Usuario: " + Program.NombreEmpleadoLogueado);
                ticket.AddHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
                ticket = caja.TotalVendidoDetalle(ticket);
                clsPago pagos = new clsPago(caja.IdEmpleado,caja.FechaAbierto);
                ticket = pagos.TotalPagosDetalle(ticket);

                ticket.AddHeaderLine("");
                ticket.AddHeaderLine("ARQUEO DE CAJA");
                ticket.AddHeaderLine("===================================");

                ticket.AddHeaderLine("");
                ticket.AddHeaderLine("Caja inicial        : " + caja.SaldoAbierto);
                ticket.AddHeaderLine("Ventas (s/.)        : " + string.Format("{0:N2}", caja.totalVentas));
                ticket.AddHeaderLine("Egresos (s/.)       : " + string.Format("{0:N2}",pagos.totalPagos));
                ticket.AddHeaderLine("                  =================");
                ticket.AddHeaderLine("TOTAL EN CAJA (s/.) : " + string.Format("{0:N2}", caja.SaldoCerrado));

                ticket.AddHeaderLine("");
                ticket.AddHeaderLine("===================================");

                ticket.AddHeaderLine("Fin");



        
                
                Imprimir(ticket);
                Program.IdCaja = null;
                Program.SaldoAbierto = 0;
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_descripcion.Text.Trim() != "")
            {
                if (txt_monto.Text.Trim() != "")
                {
                    clsPago pago = new clsPago(caja.IdEmpleado, Convert.ToDouble(txt_monto.Text, new CultureInfo("en-US")), txt_descripcion.Text);

                    DevComponents.DotNetBar.MessageBoxEx.Show(this, pago.RegistrarPago(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_monto.Clear();
                    txt_descripcion.Clear();
                }
                else
                {
                    txt_monto.Focus();
                    DevComponents.DotNetBar.MessageBoxEx.Show(this, "El Monto es requerido", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
            else 
            {
                txt_descripcion.Focus();
                DevComponents.DotNetBar.MessageBoxEx.Show(this, "El Monto es requerido", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        
         }



        private void Imprimir(Ticket ticket)
        {

            if (ticket.PrinterExists("POS-80C"))
                ticket.PrintTicket("POS-80C"); //Nombre de la impresora de tickets
            else
                DevComponents.DotNetBar.MessageBoxEx.Show(this, "Impresora no configurada, no realizará impresion", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        
        }

        private void FrmCaja_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { Program.frmAbrirCaja.Close(); }
            catch { }
        }
    }
}
