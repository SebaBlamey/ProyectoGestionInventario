using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;

namespace aadea.Logicaq
{
    public class L_Produccion
    {
        public DataTable listProduccion()
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string Query = "SELECT * FROM Produccion";
                SQLiteCommand Command = new SQLiteCommand(Query, connection);
                connection.Open();
                resultado = Command.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
        }
    }
}
