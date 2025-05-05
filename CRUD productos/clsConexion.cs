using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace CRUD_productos
{
    public class clsConexion
    {
        private readonly string connectionString;

        public clsConexion()
        {
            connectionString = "Host=localhost;Port=5432;Database=contactos_db;Username=postgres;Password=franco123;";
        }

        public NpgsqlConnection ObtenerConexion()
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open(); // Lanza excepción si falla
            return connection;
        }

        public DataTable ObtenerContactos()
        {
            string query = "SELECT * FROM contactos ORDER BY id";
            DataTable dataTable = new DataTable();

            try
            {
                using (NpgsqlConnection connection = ObtenerConexion())
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }

        public void CrearContacto(string nombre, string apellido, int telefono, string correo, string categoria)
        {
            string query = "INSERT INTO contactos (nombre, apellido, telefono, correo, categoria) VALUES (@nombre, @apellido, @telefono, @correo, @categoria)";

            try
            {
                using (NpgsqlConnection connection = ObtenerConexion())
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@categoria", categoria);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Contacto creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al crear el contacto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el contacto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ModificarContacto(int telefono, string nombre, string apellido, string correo, string categoria)
        {
            string query = "UPDATE contactos SET nombre = @nombre, apellido = @apellido, correo = @correo, categoria = @categoria WHERE telefono = @telefono";

            try
            {
                using (NpgsqlConnection connection = ObtenerConexion())
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@categoria", categoria);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Contacto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún contacto con el teléfono especificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el contacto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarContacto(int telefono)
        {
            string query = "DELETE FROM contactos WHERE telefono = @telefono";

            try
            {
                using (NpgsqlConnection connection = ObtenerConexion())
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@telefono", telefono);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Contacto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún contacto con el teléfono especificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el contacto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public DataTable BuscarContactos(string busqueda)
        {
            string query = "SELECT * FROM contactos WHERE nombre ILIKE @busqueda OR apellido ILIKE @busqueda OR telefono ILIKE @busqueda OR correo ILIKE @busqueda OR categoria ILIKE @busqueda";
            DataTable dataTable = new DataTable();

            try
            {
                using (NpgsqlConnection connection = ObtenerConexion())
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@busqueda", $"%{busqueda}%");

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar contactos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }
    }
}
