using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aadea
{
    internal class Conexion
    {
        private string Basedatos;
        private static Conexion Con = null;


       
        private Conexion()
        {

        }

        public SQLiteConnection CrearConexion()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            SQLiteConnection Cadena = new SQLiteConnection(connectionString);
            return Cadena;
        }

        public static Conexion GetConexion()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
