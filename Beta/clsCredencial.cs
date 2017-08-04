using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Beta
{
    public class clsCredencial
    {
        public String server = "";
        public String database = "";
        public String user = "";
        public String password = "";


        public clsCredencial()
        {
            this.server = @"SERVER-PC\SERVER";
            this.database = "DemoPractica";
            this.user = "PRUEBA";
            this.password = "prueba";
        }

        public void Save()
        {
            
        }
    }
}
