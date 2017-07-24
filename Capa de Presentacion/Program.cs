using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio;

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
         public static String ApellidosCliente;

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
    

        //Datos orden de Compra

        public static clsCompra ordenCompra = new clsCompra();



        //Referencias Forms

        public static FrmAlmacen frmAlmacen;
        public static FrmRegistroProductos frmRegistroProductos;
        public static Frmregresar frmregresar;
        public static FrmRegistrarCategoria frmCategoria;
        public static FrmEditarProducto frmEditarProducto;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());      
        }
    }
}
