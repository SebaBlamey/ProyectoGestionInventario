using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms.VisualStyles;

namespace aadea.Logicaq
{
    public class L_Materials
    {
        public DataTable listMaterials()
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string Query = "SELECT * FROM Material";
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
                if (connection.State == ConnectionState.Open)  { connection.Close(); }
            }
        }

        public void InsertMaterialWI(string nomb, int stock, byte[] im,string unidad)
        {
            string answer = "%";
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "INSERT INTO Material(nombre, imagen, stock,unidad) VALUES (@nombre, @img, @stock,@unidad)";
                SQLCon.Open();
                transaction = SQLCon.BeginTransaction();
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@nombre", nomb);
                Comando.Parameters.AddWithValue("@img", im);
                Comando.Parameters.AddWithValue("@stock", stock);
                Comando.Parameters.AddWithValue("@unidad", unidad);
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

        public void InsertMaterial(string nom, int stock,string unidad)
        {
            string answer = "";
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "INSERT INTO Material(nombre, stock,unidad) VALUES (@nombre, @stock,@unidad)";
                SQLCon.Open();
                transaction = SQLCon.BeginTransaction();
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@nombre", nom);
                Comando.Parameters.AddWithValue("@stock", stock);
                Comando.Parameters.AddWithValue("@unidad", unidad);
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
        public void DeleteMaterial(int id)
        {
            string answer = "";
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "DELETE FROM Material WHERE ID = @id";
                SQLCon.Open();
                transaction = SQLCon.BeginTransaction();
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@ID", id);
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

        public byte[] ObtenerImagenMaterial(int productoID)
        {
            byte[] imagenBytes = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "SELECT imagen FROM Material WHERE ID = @id";
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@ID", productoID);
                SQLCon.Open();
                object result = Comando.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    imagenBytes = (byte[])result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
            return imagenBytes;
        }

    }
}
