using System.Data.SQLite;
using System.Data;

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
                string SQLQuery = "SELECT a.id, a.Trabajador AS Rut, t.Nombre, t.Apellido, a.Dia, a.Llegada, a.Salida, ROUND(a.[Horas trabajadas], 1) AS [Horas trabajadas] " +
                                  "FROM Asistencia a " +
                                  "JOIN Trabajador t ON a.Trabajador = t.Rut";
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                SQLCon.Open();
                resultado = Comando.ExecuteReader();
                tabla.Load(resultado);

                // Eliminar la columna de ID
                tabla.Columns.Remove("id");

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

        public void UpdateAssistance(string rut, DateTime fecha, DateTime horaLlegada, DateTime horaSalida)
        {
            string answer = "";
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "UPDATE Asistencia SET Salida = @horaSalida, [Horas trabajadas] = @horasTrabajadas WHERE Trabajador = @rut AND Dia = @fecha AND Llegada = @horaLlegada";
                SQLCon.Open();
                transaction = SQLCon.BeginTransaction();
                SQLiteCommand comando = new SQLiteCommand(SQLQuery, SQLCon);
                comando.Parameters.AddWithValue("@rut", rut);
                comando.Parameters.AddWithValue("@fecha", fecha.Date);
                comando.Parameters.AddWithValue("@horaLlegada", horaLlegada);
                comando.Parameters.AddWithValue("@horaSalida", horaSalida);
                comando.Parameters.AddWithValue("@horasTrabajadas", (horaSalida - horaLlegada).TotalHours);
                answer = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo completar el proceso de actualización, intente nuevamente";
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


        public void DeleteAssistance(string rut, DateTime fecha, DateTime horaLlegada)
        {
            string answer = "";
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "DELETE FROM Asistencia WHERE Trabajador = @rut AND Dia = @fecha AND Llegada = @horaLlegada";
                SQLCon.Open();
                transaction = SQLCon.BeginTransaction();
                SQLiteCommand comando = new SQLiteCommand(SQLQuery, SQLCon);
                comando.Parameters.AddWithValue("@rut", rut);
                comando.Parameters.AddWithValue("@fecha", fecha.Date);
                comando.Parameters.AddWithValue("@horaLlegada", horaLlegada);
                answer = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo completar el proceso de eliminación, intente nuevamente";
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


        public bool checkRepeat(string rut, DateTime fecha, DateTime horaLlegada, DateTime horaSalida)
        {
            bool existeDuplicado = false;

            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "SELECT COUNT(*) FROM Asistencia WHERE Trabajador = @rut AND Dia = @fecha AND (Llegada = @horaLlegada OR Salida = @horaSalida)";

                SQLCon.Open();
                SQLiteCommand comando = new SQLiteCommand(SQLQuery, SQLCon);
                comando.Parameters.AddWithValue("@rut", rut);
                comando.Parameters.AddWithValue("@fecha", fecha.Date);
                comando.Parameters.AddWithValue("@horaLlegada", horaLlegada);
                comando.Parameters.AddWithValue("@horaSalida", horaSalida);

                int count = Convert.ToInt32(comando.ExecuteScalar());
                if (count > 0)
                {
                    existeDuplicado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open)
                    SQLCon.Close();
            }

            return existeDuplicado;
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
        public DataTable listNTrabajador()
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "SELECT Rut FROM Trabajador";
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

        public DataTable ListAsistFilterT(string rut)
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "SELECT a.id, a.Trabajador AS Rut, t.Nombre, t.Apellido, a.Dia, a.Llegada, a.Salida, " +
                                  "ROUND(a.[Horas trabajadas], 1) AS [Horas trabajadas]\r\n" +
                                  "FROM Asistencia a\r\nJOIN Trabajador t ON a.Trabajador = t.Rut\r\n" +
                                  "WHERE a.Trabajador = @rut\r\n";
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                Comando.Parameters.AddWithValue("@rut", rut); // Parámetro para filtrar por rut
                SQLCon.Open();
                resultado = Comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }


        public DataTable ListAsistFilterM(string mesSeleccionado)
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "SELECT a.id, a.Trabajador AS Rut, t.Nombre, t.Apellido, a.Dia, a.Llegada, a.Salida, " +
                                  "ROUND(a.[Horas trabajadas], 1) AS [Horas trabajadas]\r\n" +
                                  "FROM Asistencia a\r\nJOIN Trabajador t ON a.Trabajador = t.Rut\r\n" +
                                  "WHERE strftime('%m', a.Dia) = '" + mesSeleccionado + "'\r\n" +
                                  "ORDER BY a.Dia ASC;\r\n";
                SQLiteCommand Comando = new SQLiteCommand(SQLQuery, SQLCon);
                SQLCon.Open();
                resultado = Comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }

        public void InsertAssistance(string rut, DateTime fecha, DateTime horaLlegada)
        {
            string answer = "";
            SQLiteTransaction transaction = null;
            SQLiteConnection SQLCon = new SQLiteConnection();
            try
            {
                SQLCon = Conexion.GetConexion().CrearConexion();
                string SQLQuery = "INSERT INTO Asistencia (Trabajador, Dia, Llegada) " +
                                  "VALUES (@rut, @fecha, @horaLlegada)";
                SQLCon.Open();
                transaction = SQLCon.BeginTransaction();
                SQLiteCommand comando = new SQLiteCommand(SQLQuery, SQLCon);
                comando.Parameters.AddWithValue("@rut", rut);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@horaLlegada", horaLlegada);
                //comando.Parameters.AddWithValue("@horaSalida", horaSalida);
                //comando.Parameters.AddWithValue("@horasTrabajadas", horasTrabajadas);
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


        public DataTable ObtenerAsistenciaPorFecha(DateTime fecha)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SQLiteConnection connection = Conexion.GetConexion().CrearConexion())
                {
                    connection.Open();

                    string SQLQuery = @"SELECT a.Trabajador, a.Dia, a.Llegada, a.Salida, a.[Horas trabajadas]
                                FROM Asistencia a
                                JOIN Trabajador t ON a.Trabajador = t.Rut
                                WHERE a.Dia = @fecha";

                    using (SQLiteCommand command = new SQLiteCommand(SQLQuery, connection))
                    {
                        command.Parameters.AddWithValue("@fecha", fecha);

                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }







    }
}
