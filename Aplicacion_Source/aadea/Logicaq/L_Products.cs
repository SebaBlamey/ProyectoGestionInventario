﻿using System;
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
                string SQLQuery = "INSERT INTO producto(nombre, imagen, descripcion) VALUES (@nombre, @img, @desc)";
                SQLCon.Open();
                transaction = SQLCon.BeginTransaction();
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@nombre", nomb);
                Comando.Parameters.AddWithValue("@img", im);
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
        public void DeleteProduct(int id)
        {
            string answer = "";
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "DELETE FROM producto WHERE ID = @id";
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

        public byte[] ObtenerImagenProducto(int productoID)
        {
            byte[] imagenBytes = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "SELECT imagen FROM producto WHERE ID = @id";
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@id", productoID);
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

        public void update(int id, string nombre, string desc)
        {
            string answer = "";
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "UPDATE producto\r\nSET nombre = @nuevoNombre, descripcion = @nuevaDescripcion\r\nWHERE ID = @idProducto;";
                SQLCon.Open();
                transaction = SQLCon.BeginTransaction();
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@idProducto", id);
                Comando.Parameters.AddWithValue("@nuevoNombre", nombre);
                Comando.Parameters.AddWithValue("@nuevaDescripcion", desc);
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

        public void updateWI(int id, string nombre, string desc, byte[]im)
        {
            string answer = "";
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "UPDATE producto\r\nSET nombre = @nuevoNombre, descripcion = @nuevaDescripcion, imagen = @nuevaImagen\r\nWHERE ID = @idProducto;";
                SQLCon.Open();
                transaction = SQLCon.BeginTransaction();
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@idProducto", id);
                Comando.Parameters.AddWithValue("@nuevoNombre", nombre);
                Comando.Parameters.AddWithValue("@nuevaDescripcion", desc);
                Comando.Parameters.AddWithValue("@nuevaImagen", im);
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
