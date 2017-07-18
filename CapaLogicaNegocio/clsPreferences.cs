using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CapaEnlaceDatos;

namespace CapaLogicaNegocio
{
    public class clsPreferences
    {
        private clsCredencial credenciales = new clsCredencial();
        private bool statusConnection = false;
        public clsPreferences()
        {
        }
        public String getServer()
        {
            return credenciales.server;
        }
        public String getDatabase()
        {
            return credenciales.database;
        }
        public String getUser()
        {
            return credenciales.user;
        }
        public String getPassword()
        {
            return credenciales.password;
        }

        public void setServer(String _server)
        {
            credenciales.server = _server;
        }
        public void setDatabase(String _database)
        {
            credenciales.database = _database;
        }
        public void setUser(String _user)
        {
            credenciales.user = _user;
        }
        public void setPassword(String _pass)
        {
            credenciales.password = _pass;
        }


        public void SaveSettings()
        {
            try
            {
                credenciales.Save();
                clsManejador manejador = new clsManejador();
                manejador.Conectar();
                statusConnection = manejador.State();
            }
            catch (Exception e)
            {
                statusConnection = false;

            }
           
        }

        public bool getConnection()
        {
            return statusConnection;
        }

    }
}
