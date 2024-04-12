namespace ElCruce.Formularios
{
    partial class frmCombustible
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
            dgvCombustible = new DataGridView();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnSalir = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCombustible).BeginInit();
            SuspendLayout();
            // 
            // dgvCombustible
            // 
            dgvCombustible.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCombustible.Location = new Point(12, 184);
            dgvCombustible.Name = "dgvCombustible";
            dgvCombustible.RowTemplate.Height = 25;
            dgvCombustible.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCombustible.Size = new Size(341, 170);
            dgvCombustible.TabIndex = 0;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(133, 24);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(103, 25);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo Valor";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(133, 55);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(103, 24);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Valor";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(133, 85);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(103, 24);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar Valor";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(133, 370);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 25);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(133, 142);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(103, 24);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // frmCombustible
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 407);
            Controls.Add(btnActualizar);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvCombustible);
            Name = "frmCombustible";
            Text = "frmCombustible";
            Load += frmCombustible_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCombustible).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCombustible;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnSalir;
        private Button btnActualizar;
    }
}