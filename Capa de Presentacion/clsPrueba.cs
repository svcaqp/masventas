using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Capa_de_Presentacion.Properties;

namespace Capa_de_Presentacion
{
    class clsPrueba
    {
        public int statusCode =0;
        public string message;
        public void VersionPrueba()
        {
            try
            {
                DateTime localDate = DateTime.Now;

                int diasPrueba = localDate.DayOfYear - Settings.Default.FechaHoy.DayOfYear;
                if (diasPrueba == 0)
                {

                    Settings.Default.FechaHoy = localDate;
                    Settings.Default.Save();
                }
                else
                {
                    if (diasPrueba < 0 || diasPrueba > 15)
                    {
                        message = "Su version de prueba a terminado";
                        statusCode = 3;
                        return;
                    }

                }

                int diasRestantes = (15 - diasPrueba);

                if (diasRestantes < 0)
                {
                    message = "Su version de prueba a terminado";
                    statusCode = 2;
                }
                else
                {
                    message = "Dias de prueba restantes : " + diasRestantes;
                    statusCode = 1;
                }


            }

            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread Abort Exception");
            }
            finally
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }
    }
}
