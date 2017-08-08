using LibPrintTicket;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;

namespace GestorComercial
{
    // ReSharper disable once InconsistentNaming
    public class clsCaja
    {
        private readonly clsManejador _manejador = new clsManejador();
        public string IdCaja { get; set; }
        public string IdEmpleado { get; set; }
        public double SaldoAbierto { get; set; }
        public string FechaAbierto { get; set; }
        public string HoraAbierto { get; set; }

        public double SaldoCerrado { get; set; }
        public string FechaCerrado { get; set; }
        public string HoraCerrado { get; set; }

        public double totalVentas = 0;

        public clsCaja(string idEmpleado, double saldo)
        {
            this.IdEmpleado = idEmpleado;
            this.SaldoAbierto = saldo;
            IdCaja = "";

        }

        public clsCaja(string idEmpleado)
        {
            this.IdCaja = null;
            this.IdEmpleado = idEmpleado;
            CargarCaja();

        }

        public clsCaja()
        {
            // TODO: Complete member initialization
        }

        public string RegistrarCaja()
        {
            var mensaje = "";

            clsEmpresa empresa = new clsEmpresa();

            if (!empresa.ProductoActivado())
            {
                mensaje = "Error de activación : \n Pongase en contacto con SERVICORP \n Tel : 958852192";
                return mensaje;
            }


            

            var lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@SaldoAbierto", SaldoAbierto));
                lst.Add(new clsParametro("@IdEmpleado", IdEmpleado));
                lst.Add(new clsParametro("@Codigo", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                _manejador.EjecutarSP("RegistrarCaja", ref lst);
                mensaje = lst[3].Valor.ToString();
                this.IdCaja = lst[2].Valor.ToString();

            }
            catch (Exception ex)
            {
                mensaje = "Error al regsitrar la caja";
                Console.Write("Error: " + ex.Message);
            }

            return mensaje;
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

        public double TotalVendido()
        {
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@IdEmpleado", this.IdEmpleado));
            lst.Add(new clsParametro("@FechaAbierto", GetDateString(this.FechaAbierto)));
            DataTable data = _manejador.Listado("TotalVendido", lst);
            if (data.Rows.Count == 1 && Convert.ToInt32(data.Rows[0][1]) > 0)
            {
                return Convert.ToDouble(data.Rows[0][0].ToString());
            }
            return 0;

        }

        public double TotalPagos()
        {
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@IdEmpleado", this.IdEmpleado));
            lst.Add(new clsParametro("@FechaAbierto", GetDateString(this.FechaAbierto)));
            DataTable data = _manejador.Listado("TotalPagos", lst);
            if (data.Rows.Count == 1 && Convert.ToInt32(data.Rows[0][1]) > 0)
            {
                return Convert.ToDouble(data.Rows[0][0].ToString());
            }
            return 0;

        }

        public bool BuscarCajaDia()
        {
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@IdEmpleado", this.IdEmpleado));
            DataTable data = _manejador.Listado("BuscarCajaDia", lst);
            if (Convert.ToInt32(data.Rows[0][0]) > 0)
            {
                return true;
            }
            return false;

        }


        public Ticket TotalVendidoDetalle(Ticket ticket)
        {
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@IdEmpleado", this.IdEmpleado));
            lst.Add(new clsParametro("@FechaAbierto", GetDateString(this.FechaAbierto)));
            DataTable data = _manejador.Listado("TotalVendidoDetalle", lst);



            ticket.AddHeaderLine("");
            ticket.AddHeaderLine("RESUMEN DE VENTAS");
            ticket.AddHeaderLine("===================================");



            double total = 0;
            double totalBoleta = 0;
            double totalFactura = 0;
            double totalNota = 0;

            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    if (data.Rows[i][5].ToString() == "Boleta")
                    {
                        totalBoleta += Convert.ToDouble(data.Rows[0][7].ToString());
                    }
                    if (data.Rows[i][5].ToString() == "Factura")
                    {
                        totalFactura += Convert.ToDouble(data.Rows[0][7].ToString());
                    }
                    if (data.Rows[i][5].ToString() == "Nota")
                    {
                        totalNota += Convert.ToDouble(data.Rows[0][7].ToString());
                    }
                    total += Convert.ToDouble(data.Rows[i][7].ToString());
                }




            }
            ticket.AddHeaderLine("");
            ticket.AddHeaderLine("Total Boleta S/.        : " + string.Format("{0:N2}", totalBoleta));
            ticket.AddHeaderLine("Total Factura S/.       : " + string.Format("{0:N2}", totalFactura));
            ticket.AddHeaderLine("Total Nota de Venta S/. : " + string.Format("{0:N2}", totalNota));

            ticket.AddHeaderLine("");

            ticket.AddHeaderLine("TOTAL VENTAS (s/.)  :  " + string.Format("{0:N2}", total));

            ticket.AddHeaderLine("");
            ticket.AddHeaderLine("");
            ticket.AddHeaderLine("\t\t DETALLE DE VENTAS");

            ticket.AddHeaderLine("===================================");

            ticket.AddHeaderLine("Docum. " + " Nro.Doc " + "  Total");
            ticket.AddHeaderLine("");

            for (int i = 0; i < data.Rows.Count; i++)
            {
                ticket.AddHeaderLine(data.Rows[i][5].ToString() + "  " + data.Rows[i][4].ToString() + "  " + string.Format("{0:N2}", Convert.ToDouble(data.Rows[i][7].ToString())));
            }
            totalVentas = total;
            return ticket;

        }

        private void CargarCaja()
        {
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@IdEmpleado", this.IdEmpleado));
            DataTable data = _manejador.Listado("CargarCaja", lst);
            if (data.Rows.Count == 1)
            {
                this.IdCaja = data.Rows[0][0].ToString();
                this.IdEmpleado = data.Rows[0][1].ToString();
                this.SaldoAbierto = Convert.ToDouble(data.Rows[0][2].ToString());

                this.FechaAbierto = data.Rows[0][3].ToString();
                this.HoraAbierto = data.Rows[0][4].ToString();
                if (data.Rows[0][5].ToString() != "")
                {
                    this.SaldoCerrado = Convert.ToDouble(data.Rows[0][5].ToString());
                    this.FechaCerrado = data.Rows[0][6].ToString();
                    this.HoraCerrado = data.Rows[0][7].ToString();
                }

            }

        }

        public string CerrarCaja()
        {
            var mensaje = "";
            this.SaldoCerrado = this.SaldoAbierto + TotalVendido() - TotalPagos();
            var lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@IdCaja", this.IdCaja));
                lst.Add(new clsParametro("@SaldoCerrado", this.SaldoCerrado));


                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                _manejador.EjecutarSP("CerrarCaja", ref lst);
                mensaje = lst[2].Valor.ToString();


            }
            catch (Exception ex)
            {
                mensaje = "Error al registrar la caja";
                Console.Write("Error: " + ex.Message);
            }

            return mensaje;
        }

        public string ReaperturarCaja()
        {
            var mensaje = "";

            var lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@IdCaja", this.IdCaja));

                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                _manejador.EjecutarSP("ReaperturarCaja", ref lst);
                mensaje = lst[1].Valor.ToString();


            }
            catch (Exception ex)
            {
                mensaje = "Error al Reaperturar la caja";
                Console.Write("Error: " + ex.Message);
            }

            return mensaje;
        }


    }
}
