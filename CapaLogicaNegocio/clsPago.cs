using CapaEnlaceDatos;
using LibPrintTicket;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CapaLogicaNegocio
{
    public class clsPago
    {
        private readonly clsManejador _manejador = new clsManejador();
        public string IdPago { get; set; }
        public string IdEmpleado { get; set; }
        public string Descripcion { get; set; }
        public double Monto { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }


        public double totalPagos = 0;


        public clsPago(string idEmpleado, double monto,string descripcion)
        {
            this.IdEmpleado = idEmpleado;
            this.Monto = monto;
            this.Descripcion = descripcion;
            
        }
        public clsPago(string idEmpleado, string fecha)
        {
            this.IdEmpleado = idEmpleado;
            this.Fecha = fecha;
            

        }

        public string RegistrarPago()
        {
            var mensaje = "";

            var lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@Monto", this.Monto));
                lst.Add(new clsParametro("@IdEmpleado", IdEmpleado));
                lst.Add(new clsParametro("@Descripcion", this.Descripcion));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                _manejador.EjecutarSP("RegistrarPago", ref lst);
                mensaje = lst[3].Valor.ToString();

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
        public Ticket TotalPagosDetalle(Ticket ticket)
        {
            ticket.AddHeaderLine("");
            ticket.AddHeaderLine("");
            ticket.AddHeaderLine("\t\t DETALLE DE PAGOS");

            ticket.AddHeaderLine("===================================");


            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@IdEmpleado", this.IdEmpleado));
            lst.Add(new clsParametro("@FechaAbierto", GetDateString(this.Fecha)));
            DataTable data = _manejador.Listado("TotalPagosDetalle", lst);

            ticket.AddHeaderLine("ID. " + "  Hora " + "  Descripion " + "  Total");
            ticket.AddHeaderLine("");

            double total=0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                ticket.AddHeaderLine(data.Rows[i][0].ToString() + "  " + data.Rows[i][4].ToString().Substring(0, 5) +"  " + data.Rows[i][5].ToString().Substring(0, 12) + "  " + string.Format("{0:N2}", Convert.ToDouble(data.Rows[i][2].ToString())));
                total += Convert.ToDouble(data.Rows[i][2].ToString());
            }

            ticket.AddHeaderLine("");

            ticket.AddHeaderLine("TOTAL PAGOS (s/.)  :  " + string.Format("{0:N2}", total));
            totalPagos = total;
            return ticket;
        }

    }
}
