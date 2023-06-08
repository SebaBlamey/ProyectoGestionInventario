using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aadea.Logicaq
{
    public class L_Products
    {
        public DataTable listProducts()
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "SELECT ID,nombre,descripcion from producto";
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
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }

        public void InsertProductWI(string nomb, string des, byte[] im)
        {
            string answer = "%";
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "INSERT INTO producto(nombre,imagen,descripcion) VALUES('@nombre','@desc',@img)";
                SQLCon.Open();
                transaction=SQLCon.BeginTransaction();
                SQLiteCommand Comando = new SQLiteCommand( SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@nombre", nomb);
                Comando.Parameters.AddWithValue("@img", im);
                Comando.Parameters.AddWithValue("@desc", des);
                answer = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo completar el proceso de registro, intente nuevamente";
                transaction.Commit();
                //return answer;

            }
            catch (Exception ex)
            {
                answer = ex.Message;
            }
            finally
            {
                if(SQLCon.State==ConnectionState.Open)SQLCon.Close();
            }
        }
        public void InsertProduct(string nom, string des)
        {
            string answer = "";
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "INSERT INTO producto(nombre, descripcion) VALUES (@nombre, @desc)";
                SQLCon.Open();
                transaction = SQLCon.BeginTransaction();
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@nombre", nom);
                Comando.Parameters.AddWithValue("@desc", des);
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
        public void DeleteProduct()
        { }
    
    }
}
