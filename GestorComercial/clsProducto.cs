using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace GestorComercial
{
    public class clsProducto
    {
        private clsManejador M = new clsManejador();

        private Int32 m_IdP;
        private Int32 m_IdCategoria;
        private String m_Producto;
        private String m_Marca;
        private Int32 m_Stock;
        private Decimal m_PrecioCompra;
        private Decimal m_PrecioVenta;
        private DateTime m_FechaVencimiento;
        private String m_Unidad;


        public Int32 IdP
        {
            get { return m_IdP; }
            set { m_IdP = value; }
        }

        public Int32 IdCategoria
        {
            get { return m_IdCategoria; }
            set { m_IdCategoria = value; }
        }

        public String Producto
        {
            get { return m_Producto; }
            set { m_Producto = value; }
        }

        public String Marca
        {
            get { return m_Marca; }
            set { m_Marca = value; }
        }

        public Int32 Stock
        {
            get { return m_Stock; }
            set { m_Stock = value; }
        }

        public Decimal PrecioCompra
        {
            get { return m_PrecioCompra; }
            set { m_PrecioCompra = value; }
        }

        public Decimal PrecioVenta
        {
            get { return m_PrecioVenta; }
            set { m_PrecioVenta = value; }
        }

        public DateTime FechaVencimiento
        {
            get { return m_FechaVencimiento; }
            set { m_FechaVencimiento = value; }
        }

        public String Unidad
        {
            get { return m_Unidad; }
            set { m_Unidad = value; }
        }
        public DataTable Listar()
        {
            return M.Listado("ListadoProductos", null);
        }

        public DataTable BusquedaProductos(String objDatos)
        {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@Datos", objDatos));
                dt = M.Listado("FiltrarDatosProducto", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public String RegistrarProductos(clsCompra ordenCompra)
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";

            clsEmpresa empresa = new clsEmpresa();

            if (!empresa.ProductoActivado())
            {
                Mensaje = "Error de activación : \n Pongase en contacto al \n Tel : 957407217";
                return Mensaje;
            }



            try
            {
                lst.Add(new clsParametro("@IdCategoria", m_IdCategoria));
                lst.Add(new clsParametro("@Nombre", m_Producto));
                lst.Add(new clsParametro("@Marca", m_Marca));
                lst.Add(new clsParametro("@Stock", m_Stock));
                lst.Add(new clsParametro("@PrecioCompra", m_PrecioCompra));
                lst.Add(new clsParametro("@PrecioVenta", m_PrecioVenta));
                lst.Add(new clsParametro("@Unidad", m_Unidad));
                lst.Add(new clsParametro("@FechaVencimiento", m_FechaVencimiento));
                lst.Add(new clsParametro("@NroDocumento", ordenCompra.NroDocumento));
                lst.Add(new clsParametro("@TipoDocumento", ordenCompra.TipoDocumento));
                lst.Add(new clsParametro("@Total", ordenCompra.Total));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarProducto", ref lst);
                Mensaje = lst[11].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String EliminarProducto()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";

            try
            {
                lst.Add(new clsParametro("@IdProducto", m_IdP));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("EliminarProducto", ref lst);
                Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarProductos(clsCompra ordenCompra)
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";

            try
            {
                lst.Add(new clsParametro("@IdProducto", m_IdP));
                lst.Add(new clsParametro("@IdCategoria", m_IdCategoria));
                lst.Add(new clsParametro("@Nombre", m_Producto));
                lst.Add(new clsParametro("@Marca", m_Marca));
                lst.Add(new clsParametro("@Stock", m_Stock));
                lst.Add(new clsParametro("@PrecioCompra", m_PrecioCompra));
                lst.Add(new clsParametro("@PrecioVenta", m_PrecioVenta));
                lst.Add(new clsParametro("@Unidad", m_Unidad));
                lst.Add(new clsParametro("@FechaVencimiento", m_FechaVencimiento));
                lst.Add(new clsParametro("@NroDocumento", ordenCompra.NroDocumento));
                lst.Add(new clsParametro("@TipoDocumento", ordenCompra.TipoDocumento));
                lst.Add(new clsParametro("@Total", ordenCompra.Total));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("ActualizarProducto", ref lst);
                Mensaje = lst[12].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
    }
}