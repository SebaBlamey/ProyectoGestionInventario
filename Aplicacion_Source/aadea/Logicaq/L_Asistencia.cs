using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using aadea.Vistas;

namespace aadea.Logicaq
{
    internal class L_Asistencia
    {
        public DataTable listAsist()
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "SELECT a.Trabajador AS Rut, t.Nombre, t.Apellido, a.Dia, a.Llegada, a.Salida, a.[Horas trabajadas] " +
                                  "FROM Asistencia a " +
                                  "JOIN Trabajador t ON a.Trabajador = t.Rut";
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




        public DataTable listTrabajadoresAsist()
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "SELECT Rut, Nombre, Apellido FROM Trabajador";
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

        public void InsertAssistance(string rut, DateTime fecha, DateTime horaLlegada, DateTime horaSalida, float horasTrabajadas)
        {
            string answer = "";
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "INSERT INTO Asistencia (Trabajador, Dia, Llegada, Salida, [Horas trabajadas]) " +
                                  "VALUES (@rut, @fecha, @horaLlegada, @horaSalida, @horasTrabajadas)";
                SQLCon.Open();
                transaction = SQLCon.BeginTransaction();
                SQLiteCommand comando = new SQLiteCommand(SQLQuery, SQLCon);
                comando.Parameters.AddWithValue("@rut", rut);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@horaLlegada", horaLlegada);
                comando.Parameters.AddWithValue("@horaSalida", horaSalida);
                comando.Parameters.AddWithValue("@horasTrabajadas", horasTrabajadas);
                answer = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo completar el proceso de registro, intente nuevamente";
                transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                answer = ex.Message;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open)
                    SQLCon.Close();
            }
        }




    }
}
