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
            dgvDuenio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDuenio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDuenio.Location = new Point(12, 167);
            dgvDuenio.Name = "dgvDuenio";
            dgvDuenio.RowTemplate.Height = 25;
            dgvDuenio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDuenio.Size = new Size(550, 162);
            dgvDuenio.TabIndex = 0;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(126, 32);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(107, 29);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo Dueño";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(126, 88);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(107, 29);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modicar Dueño";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(326, 32);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(107, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar Dueño";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(242, 358);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(326, 87);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(107, 29);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // frmDuenios
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 422);
            Controls.Add(btnActualizar);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvDuenio);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmDuenios";
            Text = "Dueños";
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