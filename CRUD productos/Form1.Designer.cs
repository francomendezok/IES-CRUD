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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            lblPrecio = new Label();
            numericUpDown3 = new NumericUpDown();
            lblStock = new Label();
            textBox1 = new TextBox();
            lblNombre = new Label();
            lblDescripcion = new Label();
            textBox2 = new TextBox();
            lblCategorias = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numericUpDown4 = new NumericUpDown();
            label4 = new Label();
            btnEliminar = new Button();
            btnCrear = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(76, 104);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(76, 166);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 6;
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
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(227, 166);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 8;
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
            // textBox1
            // 
            textBox1.Location = new Point(227, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
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
            // textBox2
            // 
            textBox2.Location = new Point(361, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(361, 148);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(63, 15);
            lblCategorias.TabIndex = 14;
            lblCategorias.Text = "Categorias";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(361, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 13;
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
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(494, 105);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(120, 23);
            numericUpDown4.TabIndex = 18;
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
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(76, 53);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 20;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(188, 52);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnCrear);
            Controls.Add(btnEliminar);
            Controls.Add(numericUpDown4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCategorias);
            Controls.Add(textBox3);
            Controls.Add(lblDescripcion);
            Controls.Add(textBox2);
            Controls.Add(lblNombre);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown3);
            Controls.Add(lblStock);
            Controls.Add(numericUpDown2);
            Controls.Add(lblPrecio);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(Productos);
            Controls.Add(dgvProductos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label Productos;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label lblPrecio;
        private NumericUpDown numericUpDown3;
        private Label lblStock;
        private TextBox textBox1;
        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox textBox2;
        private Label lblCategorias;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown4;
        private Label label4;
        private Button btnEliminar;
        private Button btnCrear;
        private Button button1;
    }
}
