using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using aadea.userControls;
using System.Windows.Media.Media3D;

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
                string Query = "SELECT Producto.nombre, Frasco.tamaño, Productos_Historial.cantidad\r\nFROM Productos_Historial\r\nJOIN Producto ON Productos_Historial.id_producto = Producto.ID\r\nJOIN Frasco ON Productos_Historial.id_frasco = Frasco.ID\r\nWHERE Productos_Historial.id_historial = @id;";
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

        public List<string> ObtenerMateriales()
        {
            List<string> materiales = new List<string>();
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string query = "SELECT nombre FROM Material";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nombreMaterial = reader["nombre"].ToString();
                    materiales.Add(nombreMaterial);
                }
                return materiales;
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

        public List<string> ObtenerProductos()
        {
            List<string> productos = new List<string>();
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string query = "SELECT nombre FROM producto";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nombreProductos = reader["nombre"].ToString();
                    productos.Add(nombreProductos);
                }
                return productos;
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

        public List<string> ObtenerFrascos()
        {
            List<string> frascos = new List<string>();
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string query = "SELECT tamaño FROM Frasco";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nombreFrasco = reader["Tamaño"].ToString();
                    frascos.Add(nombreFrasco);
                }
                return frascos;
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

        public List<string> unidadesMateriales()
        {
            List<string> unidades = new List<string>();
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string query = "SELECT unidad FROM Material";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string unidad = reader["unidad"].ToString();
                    unidades.Add(unidad);
                }
                return unidades;
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


        public int obtenerIdMaterial(string nombre)
        {
            int id = 0; // Inicializar con un valor predeterminado
            SQLiteDataReader resultado;
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string query = "SELECT ID FROM Material WHERE Nombre = @nombre";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                connection.Open();
                resultado = command.ExecuteReader();
                if (resultado.Read())
                {
                    id = resultado.GetInt32(0);
                }
                resultado.Close();
                return id;
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

        public int obtenerIdProducto(string nombre)
        {
            int id = 0; // Inicializar con un valor predeterminado
            SQLiteDataReader resultado;
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string query = "SELECT ID FROM producto WHERE nombre = @nombre";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                connection.Open();
                resultado = command.ExecuteReader();
                if (resultado.Read())
                {
                    id = resultado.GetInt32(0);
                }
                resultado.Close();
                return id;
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

        public int obtenerIdFrasco(string nombre)
        {
            int id = 0; // Inicializar con un valor predeterminado
            SQLiteDataReader resultado;
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string query = "SELECT ID FROM Frasco WHERE Tamaño = @nombre";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                connection.Open();
                resultado = command.ExecuteReader();
                if (resultado.Read())
                {
                    id = resultado.GetInt32(0);
                }
                resultado.Close();
                return id;
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


        public void InsertarProduccion(int idProduccion, string nombreProduccion, string fechaInicio)
        {
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string query = "INSERT INTO Produccion (ID, Nombre, fecha_inicio) VALUES (@id, @nombre, @fechaInicio)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", idProduccion);
                command.Parameters.AddWithValue("@nombre", nombreProduccion);
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                connection.Open();
                command.ExecuteNonQuery();
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

        public void InsertarMaterialProduccion(int idProduccion, int idMaterial, int cantidad)
        {
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string query = "INSERT INTO Material_produccion (id_produccion, id_material, cantidad) VALUES (@idProduccion, @idMaterial, @cantidad)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@idProduccion", idProduccion);
                command.Parameters.AddWithValue("@idMaterial", idMaterial);
                command.Parameters.AddWithValue("@cantidad", cantidad);
                connection.Open();
                command.ExecuteNonQuery();
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

        public DataTable listarProduccionActual()
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string Query = "SELECT * From Produccion";
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

        public DataTable getMaterialProduccion(int id)
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string Query = "SELECT * From Material_Produccion where @id=id_produccion";
                SQLiteCommand Command = new SQLiteCommand(Query, connection);
                Command.Parameters.AddWithValue("@id", id);
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

        public string getNameMaterial(int id)
        {
            string name = null; // Inicializar con un valor predeterminado
            SQLiteDataReader resultado;
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                string query = "SELECT nombre FROM Material WHERE ID = @id";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                resultado = command.ExecuteReader();
                if (resultado.Read())
                {
                    name = resultado.GetString(0);
                }
                resultado.Close();
                return name;
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

        public void EliminarProduccion(int idProduccion)
        {
            SQLiteConnection connection = null;
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                connection.Open();

                // Eliminar registros de la tabla materiales_produccion
                string deleteMaterialProduccionQuery = "DELETE FROM Material_Produccion WHERE id_produccion = @id";
                SQLiteCommand deleteMaterialProduccionCommand = new SQLiteCommand(deleteMaterialProduccionQuery, connection);
                deleteMaterialProduccionCommand.Parameters.AddWithValue("@id", idProduccion);
                deleteMaterialProduccionCommand.ExecuteNonQuery();

                // Eliminar registro de la tabla produccion
                string deleteProduccionQuery = "DELETE FROM Produccion WHERE ID = @id";
                SQLiteCommand deleteProduccionCommand = new SQLiteCommand(deleteProduccionQuery, connection);
                deleteProduccionCommand.Parameters.AddWithValue("@id", idProduccion);
                deleteProduccionCommand.ExecuteNonQuery();

                // Realizar cualquier otra operación o notificación necesaria después de eliminar la producción

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public void TerminarProduccion(int idProduccion, string fechaTermino, string fechaInicio)
        {
            SQLiteConnection connection = null;
            try
            {
                connection = Conexion.GetConexion().CrearConexion();
                connection.Open();

                // Insertar los datos en la tabla "Historial"
                string insertHistorialQuery = "INSERT INTO Historial (ID, fecha_inicio, fecha_termino) VALUES (@id, @fechaInicio, @fechaTermino)";
                SQLiteCommand insertHistorialCommand = new SQLiteCommand(insertHistorialQuery, connection);
                insertHistorialCommand.Parameters.AddWithValue("@id", idProduccion);
                insertHistorialCommand.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                insertHistorialCommand.Parameters.AddWithValue("@fechaTermino", fechaTermino);
                insertHistorialCommand.ExecuteNonQuery();

                // Obtener los materiales de la producción desde la tabla "Material_Produccion"
                DataTable materialesProduccion = getMaterialProduccion(idProduccion);
                if (materialesProduccion != null)
                {
                    MessageBox.Show("estalleno");
                }
                else { MessageBox.Show("Estavacio"); }

                // Eliminar los registros de la producción de las tablas "Material_Produccion" y "Produccion"
                string deleteMaterialProduccionQuery = "DELETE FROM Material_Produccion WHERE id_produccion = @id";
                SQLiteCommand deleteMaterialProduccionCommand = new SQLiteCommand(deleteMaterialProduccionQuery, connection);
                deleteMaterialProduccionCommand.Parameters.AddWithValue("@id", idProduccion);
                deleteMaterialProduccionCommand.ExecuteNonQuery();

                string deleteProduccionQuery = "DELETE FROM Produccion WHERE ID = @id";
                SQLiteCommand deleteProduccionCommand = new SQLiteCommand(deleteProduccionQuery, connection);
                deleteProduccionCommand.Parameters.AddWithValue("@id", idProduccion);
                deleteProduccionCommand.ExecuteNonQuery();

                // Insertar los materiales y las cantidades correspondientes en la tabla "Detalle_Historial"
                string insertDetalleHistorialQuery = "INSERT INTO Detalle_Historial (id_material, id_historial, cantidad) VALUES (@idMaterial, @idHistorial, @cantidad)";
                foreach (DataRow row in materialesProduccion.Rows)
                {
                    int idMaterial = Convert.ToInt32(row["id_material"]);
                    int cantidad = Convert.ToInt32(row["cantidad"]);
                    SQLiteCommand insertDetalleHistorialCommand = new SQLiteCommand(insertDetalleHistorialQuery, connection);
                    insertDetalleHistorialCommand.Parameters.AddWithValue("@idMaterial", idMaterial);
                    insertDetalleHistorialCommand.Parameters.AddWithValue("@idHistorial", idProduccion);
                    insertDetalleHistorialCommand.Parameters.AddWithValue("@cantidad", cantidad);
                    insertDetalleHistorialCommand.ExecuteNonQuery();
                }

                // Realizar cualquier otra operación o notificación necesaria después de terminar la producción

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public void insertProductoHistorial(int idHistorial, int idProducto, int idFrasco, int Cantidad)
        {
            SQLiteConnection connection = new SQLiteConnection();
            try
            {
                MessageBox.Show("insertando");
                connection = Conexion.GetConexion().CrearConexion();
                string query = "INSERT INTO Productos_Historial (id_historial, id_producto, cantidad,id_frasco) VALUES (@id_historial, @id_producto, @cantidad,@id_frasco)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id_historial", idHistorial);
                command.Parameters.AddWithValue("@id_producto", idProducto);
                command.Parameters.AddWithValue("@cantidad", Cantidad);
                command.Parameters.AddWithValue("@id_frasco", idFrasco);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        public void insertStock(int idProducto, int idFrasco, int cantidad)
        {
            SQLiteConnection connection = Conexion.GetConexion().CrearConexion();
            try
            {
                string query = "SELECT cantidad FROM bodega WHERE id_producto = @id_producto AND id_frasco = @id_frasco";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id_producto", idProducto);
                command.Parameters.AddWithValue("@id_frasco", idFrasco);
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value) // El registro ya existe, realizar actualización
                {
                    int cantidadExistente = Convert.ToInt32(result);
                    int nuevaCantidad = cantidadExistente + cantidad;

                    query = "UPDATE bodega SET cantidad = @nueva_cantidad WHERE id_producto = @id_producto AND id_frasco = @id_frasco";
                    command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@nueva_cantidad", nuevaCantidad);
                    command.ExecuteNonQuery();
                }
                else // El registro no existe, realizar inserción
                {
                    query = "INSERT INTO bodega (id_producto, id_frasco, cantidad) VALUES (@id_producto, @id_frasco, @cantidad)";
                    command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@id_producto", idProducto);
                    command.Parameters.AddWithValue("@id_frasco", idFrasco);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            } 
        }
    }

}
