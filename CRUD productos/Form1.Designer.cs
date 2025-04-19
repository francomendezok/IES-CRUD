namespace CRUD_productos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            Productos = new Label();
            label1 = new Label();
            numCodigo = new NumericUpDown();
            numPrecio = new NumericUpDown();
            lblPrecio = new Label();
            numStock = new NumericUpDown();
            lblStock = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblCategorias = new Label();
            txtCategoria = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numEliminar = new NumericUpDown();
            label4 = new Label();
            btnEliminar = new Button();
            btnCrear = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCodigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEliminar).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(74, 244);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(641, 150);
            dgvProductos.TabIndex = 0;
            // 
            // Productos
            // 
            Productos.AutoSize = true;
            Productos.Location = new Point(74, 216);
            Productos.Name = "Productos";
            Productos.Size = new Size(61, 15);
            Productos.TabIndex = 2;
            Productos.Text = "Productos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 86);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Codigo";
            // 
            // numCodigo
            // 
            numCodigo.Location = new Point(76, 104);
            numCodigo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numCodigo.Name = "numCodigo";
            numCodigo.Size = new Size(120, 23);
            numCodigo.TabIndex = 4;
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(76, 166);
            numPrecio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(120, 23);
            numPrecio.TabIndex = 6;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(76, 148);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // numStock
            // 
            numStock.Location = new Point(227, 166);
            numStock.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 23);
            numStock.TabIndex = 8;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(227, 148);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 7;
            lblStock.Text = "Stock";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(227, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 9;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(227, 85);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(361, 86);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 12;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(361, 104);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 11;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(361, 148);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(58, 15);
            lblCategorias.TabIndex = 14;
            lblCategorias.Text = "Categoria";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(361, 166);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 9);
            label2.Name = "label2";
            label2.Size = new Size(283, 32);
            label2.TabIndex = 15;
            label2.Text = "Crear/Modificar Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(494, 43);
            label3.Name = "label3";
            label3.Size = new Size(202, 32);
            label3.TabIndex = 16;
            label3.Text = "Eliminar Producto";
            // 
            // numEliminar
            // 
            numEliminar.Location = new Point(494, 105);
            numEliminar.Name = "numEliminar";
            numEliminar.Size = new Size(120, 23);
            numEliminar.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 87);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 17;
            label4.Text = "Codigo";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(640, 105);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(76, 53);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 20;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(188, 52);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnCrear);
            Controls.Add(btnEliminar);
            Controls.Add(numEliminar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCategorias);
            Controls.Add(txtCategoria);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(numStock);
            Controls.Add(lblStock);
            Controls.Add(numPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(numCodigo);
            Controls.Add(label1);
            Controls.Add(Productos);
            Controls.Add(dgvProductos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCodigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEliminar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label Productos;
        private Label label1;
        private NumericUpDown numCodigo;
        private NumericUpDown numPrecio;
        private Label lblPrecio;
        private NumericUpDown numStock;
        private Label lblStock;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblCategorias;
        private TextBox txtCategoria;
        private Label label2;
        private Label label3;
        private NumericUpDown numEliminar;
        private Label label4;
        private Button btnEliminar;
        private Button btnCrear;
        private Button btnModificar;
    }
}
