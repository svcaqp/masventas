using GestorComercial.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GestorComercial
{
    class clsPrueba
    {
        public int statusCode = 0;
        public string message;
        public void VersionPrueba()
        {
            try
            {
                DateTime localDate = DateTime.Now;
                if (Settings.Default.FechaHoy.DayOfYear == 1)
                {
                    Settings.Default.FechaHoy = localDate;
                    Settings.Default.Save();
                }
                int diasPrueba = localDate.DayOfYear - Settings.Default.FechaHoy.DayOfYear;

                if (diasPrueba < 0 || diasPrueba > 15)
                {
                    message = "Su versión de prueba ha terminado";
                    statusCode = 3;
                    return;
                }



                int diasRestantes = (15 - diasPrueba);

                if (diasRestantes < 0)
                {
                    message = "Su versión de prueba ha terminado";
                    statusCode = 2;
                }
                else
                {
                    message = "Días de prueba restantes : " + diasRestantes;
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
