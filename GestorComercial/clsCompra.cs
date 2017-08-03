using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestorComercial
{
    public class clsCompra
    {

        private String m_IdProducto;
        private String m_NroDocumento;
        private String m_TipoDocumento;
        private int m_Cantidad;
        private double m_Total;
        private DateTime m_FechaRegistro;


        public clsCompra(String _NroDocumento, String _TipoDocumento, int _Cantidad, double _Total)
        {
            this.m_NroDocumento = _NroDocumento;
            this.m_TipoDocumento = _TipoDocumento;
            this.m_Cantidad = _Cantidad;
            this.m_Total = _Total;
        }

        public clsCompra()
        {
            this.m_Cantidad = 0;
            this.m_IdProducto = "";
            this.m_NroDocumento = "";
            this.m_Total = 0;
            this.m_TipoDocumento = "";
        }
        public String NroDocumento
        {
            get { return m_NroDocumento; }
            set { m_NroDocumento = value; }
        }
        public String TipoDocumento
        {
            get { return m_TipoDocumento; }
            set { m_TipoDocumento = value; }
        }
        public int Cantidad
        {
            get { return m_Cantidad; }
            set { m_Cantidad = value; }
        }
        public double Total
        {
            get { return m_Total; }
            set { m_Total = value; }
        }
        public DateTime FechaRegistro
        {
            get { return m_FechaRegistro; }
            set { m_FechaRegistro = value; }
        }

    }
}
