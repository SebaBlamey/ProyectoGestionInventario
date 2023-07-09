using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aadea.Logicaq
{
    public class L_inventario
    {

        public DataTable listProducts()
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                //string SQLQuery = "SELECT p.ID, p.nombre, p.imagen FROM producto p INNER JOIN bodega b ON p.ID = b.ID_producto";
                string SQLQuery = "SELECT p.ID, p.nombre, p.imagen FROM producto p WHERE p.ID IN (SELECT ID_Producto FROM bodega)";
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

        public DataTable listProductsNotInInventory()
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "SELECT ID, nombre FROM producto WHERE ID NOT IN (SELECT ID_Producto FROM Bodega)";
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

        public DataTable listSizes() 
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "SELECT * FROM Frasco";
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
        public void addToInventory(string idProd, string idSize, int stock)
        {
            string answer = "";
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "INSERT INTO Bodega(ID_Producto, ID_Frasco, Stock) VALUES (@prod, @size, @stock)";
                SQLCon.Open();
                transaction = SQLCon.BeginTransaction();
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@prod", idProd);
                Comando.Parameters.AddWithValue("@size", idSize);
                Comando.Parameters.AddWithValue("@stock", stock);               
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

        public void delFromInventory(string id) 
        {
            string answer = "";
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "DELETE FROM Bodega WHERE ID_Producto = @id";
                SQLCon.Open();
                transaction = SQLCon.BeginTransaction();
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@id", id);
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

        public void addSize(int size)
        {
            int count;
            string answer = "";
            //SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "SELECT COUNT(*) FROM Frasco WHERE tamaño = @valor";
                SQLCon.Open();
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@valor", size);
                count = (int)Comando.ExecuteScalar();               
                if (count == 0)
                {
                    
                }
                else
                {
                    
                }

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
