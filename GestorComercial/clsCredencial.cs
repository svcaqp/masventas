using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestorComercial.Properties;

namespace GestorComercial
{
    public class clsCredencial
    {
        public String server = "";
        public String database = "";
        public String user = "";
        public String password = "";


        public clsCredencial()
        {
            this.server = Settings.Default["DBServer"].ToString();
            this.database = Settings.Default["DBNombre"].ToString();
            this.user = Settings.Default["DBUsuario"].ToString();
            this.password = Settings.Default["DBPassword"].ToString();
        }

        public void Save()
        {
            Settings.Default["DBServer"] = this.server;
            Settings.Default["DBNombre"] = this.database;
            Settings.Default["DBUsuario"] = this.user;
            Settings.Default["DBPassword"] = this.password;
            Settings.Default.Save();
        }
    }
}
