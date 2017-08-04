using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GestorComercial
{
    public class clsDocumento
    {

        private readonly clsManejador _manejador = new clsManejador();
        string IdDocumento;
        string TipoDocumento;

        public clsDocumento(string idDocumento, string tipoDocumento)
        {
            IdDocumento = idDocumento;
            TipoDocumento = tipoDocumento;
        }
        public string AnularDocumento()
        {
            var mensaje = "";

            var lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@IdDocumento", this.IdDocumento));
                lst.Add(new clsParametro("@TipoDocumento", TipoDocumento));

                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                _manejador.EjecutarSP("AnularDocumento", ref lst);
                mensaje = lst[2].Valor.ToString();

            }
            catch (Exception ex)
            {
                mensaje = "Error al Eliminar el documento";
                Console.Write("Error: " + ex.Message);
            }

            return mensaje;
        }

    }
}
