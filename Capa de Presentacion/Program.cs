using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorComercial;

namespace Capa_de_Presentacion
{
    public static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.      
        /// </summary>
         public static int Evento;

        //Datos del Cliente
         public static int IdCliente;
         public static String DocumentoIdentidad;
         public static String NombreCliente;
         public static String Direccion;

        //Datos del Producto
         public static int IdProducto;
         public static String Descripcion;
         public static String Marca;
         public static Int32 Stock;
         public static Decimal PrecioVenta;
         public static String Unidad;

        //Datos del Empleado
         public static int IdCargo;
         public static String EstadoCivil="";
         public static int IdEmpleado;

        //Variables de Sesion
        public static int IdEmpleadoLogueado;
        public static String NombreEmpleadoLogueado;
        public static String IdCargoEmpleadoLogueado;

        // Datos de la caja 
        public static String IdCaja;
        public static double SaldoAbierto;
        public static double TotalVentas = 0;

        //Datos orden de Compra

        public static clsCompra ordenCompra = new clsCompra();
        public static String nombreProduct;
        public static String marcaProduct;



        //Referencias Forms

        public static FrmAlmacen frmAlmacen;
        public static FrmOrdenCompra frmOrdenCompra;
        public static FrmEditarProducto frmEditarProducto;

        public static FrmCaja frmCaja;
        public static FrmAbrirCaja frmAbrirCaja;
        public static FrmListadoClientes frmClientes;
        public static FrmListadoEmpleados frmEmpleados;
        public static FrmReportesMenu frmReportes;
        public static FrmAdministracion frmAdministracion;

        public static FrmDocumentos frmDocumentos;
        public static FrmTutorial frmTutorial;
    
        public static FrmReportesKardex frmReportesKardex;
        public static FrmReportesVentas frmReportesVentas;
        public static FrmReportesAnulaciones frmReportesAnulaciones;
        public static FrmReportesVencimiento frmReportesVencimiento;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());      
        }
    }
}
