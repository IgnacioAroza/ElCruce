namespace ElCruce
{
    partial class frmDuenios
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
            dgvDuenio = new DataGridView();
            btnNuevo = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDuenio).BeginInit();
            SuspendLayout();
            // 
            // dgvDuenio
            // 
            dgvDuenio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDuenio.Location = new Point(12, 226);
            dgvDuenio.Name = "dgvDuenio";
            dgvDuenio.RowTemplate.Height = 25;
            dgvDuenio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDuenio.Size = new Size(451, 143);
            dgvDuenio.TabIndex = 0;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(178, 26);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(107, 26);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo Dueño";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(178, 76);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(107, 26);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modicar Dueño";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(178, 123);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(107, 26);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar Dueño";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(189, 387);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 26);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(178, 172);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(107, 26);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // frmDuenios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 445);
            Controls.Add(btnActualizar);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvDuenio);
            Name = "frmDuenios";
            Text = "frmDuenios";
            Load += frmDuenios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDuenio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDuenio;
        private Button btnNuevo;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnSalir;
        private Button btnActualizar;
    }
}