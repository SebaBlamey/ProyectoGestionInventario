using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;

namespace aadea
{
    public class L_Trabajadores
    {
        public DataTable Listado_Trabajadores()
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection SQLCon = new SQLiteConnection();
            try 
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "select * from Trabajador";
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                SQLCon.Open();
                resultado = Comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
               if(SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }

        public void InsertarTrabajador(string rut, string nombre, string apellido, string direccion, string numero)
        {
            string answer = "";
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();

                string SQLQuery = "";

            }
            catch (Exception ex)
            {

            }
            finally 
            {

            }
        }

        public void EliminarTrabajador()
        { }
    }
}
