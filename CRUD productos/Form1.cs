using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CRUD_productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           clsConexion clsConexion = new clsConexion();
           clsConexion.Conectar(dgvProductos);
        }

 
    }
}
