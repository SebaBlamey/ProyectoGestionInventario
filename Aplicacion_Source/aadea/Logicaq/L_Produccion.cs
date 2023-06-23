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
        public DataTable ListHistorial()
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string Query = "SELECT * FROM Historial";
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

        public DataTable listMaterialForHistory(int id)
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string Query = "SELECT Material.nombre, Detalle_Historial.cantidad FROM Detalle_Historial JOIN Material ON Detalle_Historial.id_material = Material.ID WHERE Detalle_Historial.id_historial = 1";
                SQLiteCommand Command = new SQLiteCommand(Query, connection);
                Command.Parameters.AddWithValue("id", id);
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

        public DataTable GetProductHistory(int id)
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string Query = "SELECT Producto.nombre, Frasco.tamaño, Producto_Historial.cantidad\r\nFROM Producto_Historial\r\nJOIN Producto ON Producto_Historial.id_producto = Producto.ID\r\nJOIN Frasco ON Producto_Historial.id_frasco = Frasco.ID\r\nWHERE Producto_Historial.id_historial = @id;";
                SQLiteCommand Command = new SQLiteCommand(Query, connection);
                Command.Parameters.AddWithValue("id", id);
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

        public DataTable ObtenerMateriales()
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string Query = "SELECT nombre FROM Material";
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
