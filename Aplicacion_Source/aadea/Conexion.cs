using System;
using System.Collections.Generic;
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
            this.Basedatos = "./database.db";
        }

        public SQLiteConnection CrearConexion() 
        {
            SQLiteConnection Cadena = new SQLiteConnection();
            try 
            { 
                Cadena.ConnectionString = "Data Source="+this.Basedatos;
            }
            catch (Exception ex) 
            {
                Cadena = null;
                throw ex;
            }
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
