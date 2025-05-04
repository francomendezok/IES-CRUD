using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CRUD_productos
{
    public partial class frmPrincipal : Form
    {
        private clsConexion conexion;
        public frmPrincipal()
        {
            InitializeComponent();
            conexion = new clsConexion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.Conectar(dgvProductos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (numEliminar.Value != 0)
            {
                conexion.EliminarProducto(Convert.ToInt32(numEliminar.Value));

                // limpio la tabla // 
                conexion.RefrescarTabla();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(numCodigo.Value);
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            int precio = Convert.ToInt32(numPrecio.Value);
            int stock = Convert.ToInt32(numStock.Value);
            string categoria = txtCategoria.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(categoria))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // chequeo que el codigo no este en la db //

            if (!conexion.ChequearDisponibilidadCodigo(codigo))
            {
                MessageBox.Show("El código ya existe. Por favor, elija otro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conexion.CrearProducto(codigo, nombre, descripcion, precio, stock, categoria);
        }

        private void btnModificar_Click(object sender, EventArgs e) // btn modificar // 
        {
            int codigo = Convert.ToInt32(numCodigo.Value);
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            int precio = Convert.ToInt32(numPrecio.Value);
            int stock = Convert.ToInt32(numStock.Value);
            string categoria = txtCategoria.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(categoria))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // chequeo que el codigo este en la db //

            if (conexion.ChequearDisponibilidadCodigo(codigo))
            {
                MessageBox.Show("El producto no esta en la base de datos. Elija un producto de la base de datos para modificarlo. Recuerda que no puedes modificar su codigo de referencia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else conexion.ModificarProducto(codigo, nombre, descripcion, precio, stock, categoria);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            
            conexion.Buscar(busqueda);
            
        }
    }
}
