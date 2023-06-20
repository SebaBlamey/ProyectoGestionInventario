using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using System.Windows.Documents;

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
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "INSERT INTO Trabajador(Rut, Nombre, Apellido, Direccion, Telefono) VALUES (@rut, @nombre, @apellido, @direccion, @numero)";
                SQLCon.Open();
                transaction = SQLCon.BeginTransaction();
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@rut", rut);
                Comando.Parameters.AddWithValue("@nombre", nombre);
                Comando.Parameters.AddWithValue("@apellido", apellido);
                Comando.Parameters.AddWithValue("@direccion", direccion);
                Comando.Parameters.AddWithValue("@numero", numero);
                answer = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo completar el proceso de registro, intente nuevamente";
                transaction.Commit();

            }
            catch (Exception ex)
            {
                answer = ex.Message;
            }
            finally 
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }

        public void EditEmployee(string rut, string nombre, string apellido, string direccion, string numero)
        {
            string answer = "";
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "UPDATE Trabajador \n" +
                                  "SET Nombre = @nombre, Apellido = @apellido, Direccion = @direccion, Telefono = @numero \n" +
                                  "WHERE RUT = @rut ;";
                SQLCon.Open();
                transaction = SQLCon.BeginTransaction();
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@rut", rut);
                Comando.Parameters.AddWithValue("@nombre", nombre);
                Comando.Parameters.AddWithValue("@apellido", apellido);
                Comando.Parameters.AddWithValue("@direccion", direccion);
                Comando.Parameters.AddWithValue("@numero", numero);
                answer = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo completar el proceso de registro, intente nuevamente";
                transaction.Commit();

            }
            catch (Exception ex)
            {
                answer = ex.Message;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }

        public void EliminarTrabajador(string rut)
        {
            string answer = "";
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "DELETE FROM Trabajador WHERE Rut = @rut";
                SQLCon.Open();
                transaction = SQLCon.BeginTransaction();
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@rut", rut);
                answer = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo completar el proceso de eliminacion, intente nuevamente";
                transaction.Commit();
            }
            catch (Exception ex)
            {
                answer = ex.Message;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }
    }
}
