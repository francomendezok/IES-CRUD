using System;
using System.Data;
using System.Windows.Forms;

namespace CRUD_productos
{
    public partial class frmContactos : Form
    {
        private clsConexion conexion;

        public frmContactos()
        {
            InitializeComponent();
            conexion = new clsConexion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarTabla();
        }

        private void RefrescarTabla()
        {
            DataTable contactos = conexion.ObtenerContactos();
            if (contactos != null)
            {
                dgvContactos.DataSource = contactos; // cargo la dgv // 
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int telefono = Convert.ToInt32(numEliminar.Value);

            if (telefono != 0)
            {
                conexion.EliminarContacto(telefono);
                RefrescarTabla();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un contacto para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int telefono = Convert.ToInt32(numTelefono.Value);
            string correo = txtCorreo.Text;
            string categoria = txtCategoria.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || telefono == 0|| string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(categoria))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conexion.CrearContacto(nombre, apellido, telefono, correo, categoria);
            RefrescarTabla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int telefono = Convert.ToInt32(numTelefono.Value);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreo.Text;
            string categoria = txtCategoria.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(categoria))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conexion.ModificarContacto(telefono, nombre, apellido, correo, categoria);
            RefrescarTabla();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            DataTable resultados = conexion.BuscarContactos(busqueda);
            if (resultados != null)
            {
                dgvContactos.DataSource = resultados;
            }
        }
    }
}
