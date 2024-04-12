namespace ElCruce.Formularios
{
    partial class frmConductores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNuevo = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            dgvConductores = new DataGridView();
            btnBuscarNombre = new Button();
            btnBuscarApellido = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvConductores).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(48, 25);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(109, 25);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo Chofer";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(48, 73);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(109, 25);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar Chofer";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(48, 120);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 25);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Chofer";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(353, 185);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(109, 25);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(353, 413);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(109, 25);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvConductores
            // 
            dgvConductores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConductores.Location = new Point(12, 225);
            dgvConductores.Name = "dgvConductores";
            dgvConductores.RowTemplate.Height = 25;
            dgvConductores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConductores.Size = new Size(776, 163);
            dgvConductores.TabIndex = 5;
            // 
            // btnBuscarNombre
            // 
            btnBuscarNombre.Location = new Point(437, 35);
            btnBuscarNombre.Name = "btnBuscarNombre";
            btnBuscarNombre.Size = new Size(128, 27);
            btnBuscarNombre.TabIndex = 6;
            btnBuscarNombre.Text = "Buscar por Nombre";
            btnBuscarNombre.UseVisualStyleBackColor = true;
            btnBuscarNombre.Click += btnBuscarNombre_Click;
            // 
            // btnBuscarApellido
            // 
            btnBuscarApellido.Location = new Point(437, 102);
            btnBuscarApellido.Name = "btnBuscarApellido";
            btnBuscarApellido.Size = new Size(128, 25);
            btnBuscarApellido.TabIndex = 7;
            btnBuscarApellido.Text = "Buscar por Apellido";
            btnBuscarApellido.UseVisualStyleBackColor = true;
            btnBuscarApellido.Click += btnBuscarApellido_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(583, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(583, 102);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(158, 23);
            txtApellido.TabIndex = 9;
            // 
            // frmConductores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnBuscarApellido);
            Controls.Add(btnBuscarNombre);
            Controls.Add(dgvConductores);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Name = "frmConductores";
            Text = "frmConductores";
            Load += frmConductores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConductores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnSalir;
        private DataGridView dgvConductores;
        private Button btnBuscarNombre;
        private Button btnBuscarApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
    }
}