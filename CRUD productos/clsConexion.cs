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
        OleDbConnection connection;
        OleDbCommand cmd;

        public void Conectar(DataGridView tabla)
        {
            try
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\CRUD productos\\CRUD productos\\bin\\crud.accdb;";
                
                connection = new OleDbConnection(connectionString);
                connection.Open();
                MessageBox.Show("Conexión exitosa.");
                CargarDatos(connection, tabla);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void CargarDatos(OleDbConnection connection, DataGridView tabla)
        {
            string query = "SELECT * FROM productos";

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
        
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            tabla.DataSource = dt;
        }
    }

}
