using CapaEnlaceDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CapaLogicaNegocio
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

        public string RegistrarCaja()
        {
            var mensaje = "";

            var lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@SaldoAbierto", SaldoAbierto));
                lst.Add(new clsParametro("@IdEmpleado", IdEmpleado));
                lst.Add(new clsParametro("@Codigo", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                _manejador.EjecutarSP("RegistrarCaja", ref lst);
                mensaje = lst[3].Valor.ToString();
                this.IdCaja =lst[2].Valor.ToString();

            }
            catch (Exception ex)
            {
                mensaje = "Error al regsitrar la caja";
                Console.Write("Error: " + ex.Message);
            }
            
            return mensaje;
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

        
    }
}
