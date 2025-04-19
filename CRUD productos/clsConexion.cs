using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Security;
using System.Data;
using System.Windows.Forms;

namespace CRUD_productos
{
    internal class clsConexion
    {
        private OleDbConnection connection;
        private DataGridView tabla;

        public void Conectar(DataGridView tabla)
        {
            try
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\franc\\Desktop\\Facultad\\Laboratorio 3\\CRUD productos\\CRUD productos\\bin\\crud.accdb\"";
                
                connection = new OleDbConnection(connectionString);
                connection.Open();
                MessageBox.Show("Conexión exitosa.");

                this.tabla = tabla; // asigno la tabla a la variable de clase //
                CargarDatos();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void CargarDatos()
        {
            if (connection == null || tabla == null) return;
  
            string query = "SELECT * FROM productos ORDER BY codigo";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
        
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            tabla.DataSource = dt;
        }

        public void RefrescarTabla()
        {
            CargarDatos();
        }

        public void EliminarProducto(int productId)
        {
            try
            {
                string query = "DELETE FROM productos WHERE codigo = @Id";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", productId); // para evitar inyecciones SQL // 

                    int rowsAffected = cmd.ExecuteNonQuery(); // ejecuto la query y veo a cuantas rows afecto //

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto con el ID especificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ChequearDisponibilidadCodigo(int codigo)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM productos WHERE codigo = @Id"; // count
                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", codigo);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("El código ya existe. Por favor, elija otro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    return true; // si no existe el codigo, lo devuelvo como true //
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el código: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void CrearProducto(int codigo, string nombre, string descripcion, int precio, int stock, string categoria)
        {
            try
            {
                string query = "INSERT INTO productos (codigo, nombre, descripcion, precio, stock, categoria) VALUES (@Id, @nombre, @descripcion, @precio, @stock, @categoria)";
                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefrescarTabla(); // refresco la tabla para mostrar el nuevo producto //
                    }
                    else
                    {
                        MessageBox.Show("Error al crear el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }

}
