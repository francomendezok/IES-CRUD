namespace CRUD_productos
{
    partial class frmContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContactos));
            dgvContactos = new DataGridView();
            Productos = new Label();
            label1 = new Label();
            numTelefono = new NumericUpDown();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblCategorias = new Label();
            txtCategoria = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numEliminar = new NumericUpDown();
            label4 = new Label();
            btnEliminar = new Button();
            btnCrear = new Button();
            btnModificar = new Button();
            btnBuscar = new Button();
            label5 = new Label();
            txtBuscar = new TextBox();
            label6 = new Label();
            txtCorreo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTelefono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEliminar).BeginInit();
            SuspendLayout();
            // 
            // dgvContactos
            // 
            dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactos.Location = new Point(74, 244);
            dgvContactos.Name = "dgvContactos";
            dgvContactos.Size = new Size(641, 150);
            dgvContactos.TabIndex = 0;
            // 
            // Productos
            // 
            Productos.AutoSize = true;
            Productos.Location = new Point(74, 216);
            Productos.Name = "Productos";
            Productos.Size = new Size(61, 15);
            Productos.TabIndex = 2;
            Productos.Text = "Contactos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 86);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Telefono";
            // 
            // numTelefono
            // 
            numTelefono.Location = new Point(76, 104);
            numTelefono.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            numTelefono.Name = "numTelefono";
            numTelefono.Size = new Size(120, 23);
            numTelefono.TabIndex = 4;
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
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(361, 86);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(361, 104);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 11;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(74, 150);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(58, 15);
            lblCategorias.TabIndex = 14;
            lblCategorias.Text = "Categoria";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(74, 168);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 9);
            label2.Name = "label2";
            label2.Size = new Size(283, 32);
            label2.TabIndex = 15;
            label2.Text = "Crear/Modificar Contacto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(494, 43);
            label3.Name = "label3";
            label3.Size = new Size(202, 32);
            label3.TabIndex = 16;
            label3.Text = "Eliminar Contacto";
            // 
            // numEliminar
            // 
            numEliminar.Location = new Point(494, 105);
            numEliminar.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            numEliminar.Name = "numEliminar";
            numEliminar.Size = new Size(120, 23);
            numEliminar.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 87);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 17;
            label4.Text = "Numero de Telefono";
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
            btnCrear.Location = new Point(74, 53);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 20;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(227, 53);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(640, 216);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(522, 198);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 23;
            label5.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(522, 216);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 150);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 26;
            label6.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(202, 168);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 25;
            // 
            // frmContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(btnBuscar);
            Controls.Add(label5);
            Controls.Add(txtBuscar);
            Controls.Add(btnModificar);
            Controls.Add(btnCrear);
            Controls.Add(btnEliminar);
            Controls.Add(numEliminar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCategorias);
            Controls.Add(txtCategoria);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(numTelefono);
            Controls.Add(label1);
            Controls.Add(Productos);
            Controls.Add(dgvContactos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmContactos";
            Text = "Contactos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTelefono).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEliminar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContactos;
        private Label Productos;
        private Label label1;
        private NumericUpDown numTelefono;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblCategorias;
        private TextBox txtCategoria;
        private Label label2;
        private Label label3;
        private NumericUpDown numEliminar;
        private Label label4;
        private Button btnEliminar;
        private Button btnCrear;
        private Button btnModificar;
        private Button btnBuscar;
        private Label label5;
        private TextBox txtBuscar;
        private Label label6;
        private TextBox txtCorreo;
    }
}
