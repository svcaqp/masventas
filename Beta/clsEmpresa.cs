using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Beta
{
    public class clsEmpresa
    {

        private readonly clsManejador _manejador = new clsManejador();
        public string NombreEmpresa;
        public string RucEmpresa;
        public string DireccionEmpresa;
        public string Ciudad;
        public int FacturaCorrelativo;
        public int BoletaCorrelativo;
        public int notaCorrelativo;
        public double TasaIgv;
        public string Licencia;


        public clsEmpresa(string nombreEmpresa,
                          string rucEmpresa,
                          string direccionEmpresa,
                          string ciudad,
                          int facturaCorre,
                          int boletaCorre,
                          int notaCorre,
                          double tasaIgv
                          )
        {
            NombreEmpresa = nombreEmpresa;
            RucEmpresa = rucEmpresa;
            DireccionEmpresa = direccionEmpresa;
            Ciudad = ciudad;
            FacturaCorrelativo = facturaCorre;
            BoletaCorrelativo = boletaCorre;
            notaCorrelativo = notaCorre;
            TasaIgv = tasaIgv;
        }

        public clsEmpresa()
        {

            DataTable data = _manejador.Listado("DatosEmpresa", null);
            if (data.Rows.Count > 0)
            {
                this.NombreEmpresa = data.Rows[0][0].ToString();
                this.RucEmpresa = data.Rows[0][1].ToString();
                this.DireccionEmpresa = data.Rows[0][2].ToString();
                this.Ciudad = data.Rows[0][3].ToString();
                this.FacturaCorrelativo = Convert.ToInt32(data.Rows[0][4].ToString());
                this.BoletaCorrelativo = Convert.ToInt32(data.Rows[0][5].ToString());
                this.notaCorrelativo = Convert.ToInt32(data.Rows[0][6].ToString());
                this.TasaIgv = Convert.ToDouble(data.Rows[0][7].ToString());
                this.Licencia = data.Rows[0][8].ToString();
            }

        }
        public string RegistrarEmpresa()
        {
            var mensaje = "";

            var lst = new List<clsParametro>();
            try
            {

                lst.Add(new clsParametro("@NombreEmpresa", NombreEmpresa));
                lst.Add(new clsParametro("@DireccionEmpresa", RucEmpresa));
                lst.Add(new clsParametro("@RucEmpresa", RucEmpresa));
                lst.Add(new clsParametro("@Ciudad", Ciudad));
                lst.Add(new clsParametro("@FacturaCorre", FacturaCorrelativo));
                lst.Add(new clsParametro("@BoletaCorre", BoletaCorrelativo));
                lst.Add(new clsParametro("@NotaCorre", notaCorrelativo));
                lst.Add(new clsParametro("@TasaIgv", TasaIgv));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                _manejador.EjecutarSP("RegistrarEmpresa", ref lst);
                mensaje = lst[8].Valor.ToString();

            }
            catch (Exception ex)
            {
                mensaje = "Error al registrar los datos de la empresa";
                Console.Write("Error: " + ex.Message);
            }

            return mensaje;
        }

        public string RegistrarLicencia()
        {
            var mensaje = "";

            var lst = new List<clsParametro>();
            try
            {

                lst.Add(new clsParametro("@Licencia", Licencia));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                _manejador.EjecutarSP("RegistrarLicencia", ref lst);
                mensaje = lst[1].Valor.ToString();

            }
            catch (Exception ex)
            {
                mensaje = "Error al registrar La Licencia";
                Console.Write("Error: " + ex.Message);
            }

            return mensaje;
        }

        

        public string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
 
        public string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
        private void GenerarLicencia()
        {
            string clientName = System.Windows.Forms.SystemInformation.ComputerName;
            this.Licencia = Encriptar(clientName);
        }

        public bool ValidarLicencia()
        {

            string clientCode = DesEncriptar(Licencia+"=");
            string clientName = System.Windows.Forms.SystemInformation.ComputerName;
            return (clientCode == clientName);
        }

       

        public bool ProductoActivado()
        {
            clsPrueba prueba = new clsPrueba();
            prueba.VersionPrueba();
            if (prueba.statusCode != 1)
            {
                return ValidarLicencia();
            }

            return true;
        }

        public void setPrueba()
        {
            clsPrueba prueba = new clsPrueba();
            prueba.SetPrueba();
        }
        
    }
}
