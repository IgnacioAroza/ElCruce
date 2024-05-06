namespace ElCruce.Formularios
{
    partial class frmViajes
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
            txtApellidoDuenio = new TextBox();
            txtNombreDuenio = new TextBox();
            btnApellidoDuenio = new Button();
            btnNombreDuenio = new Button();
            dgvViajes = new DataGridView();
            btnSalir = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            txtApellidoChofer = new TextBox();
            txtNombreChofer = new TextBox();
            btnApellidoChofer = new Button();
            btnNombreChofer = new Button();
            txtNroLiq = new TextBox();
            btnNroLiq = new Button();
            btnFecha = new Button();
            dtpFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvViajes).BeginInit();
            SuspendLayout();
            // 
            // txtApellidoDuenio
            // 
            txtApellidoDuenio.Location = new Point(962, 100);
            txtApellidoDuenio.Name = "txtApellidoDuenio";
            txtApellidoDuenio.Size = new Size(158, 23);
            txtApellidoDuenio.TabIndex = 19;
            // 
            // txtNombreDuenio
            // 
            txtNombreDuenio.Location = new Point(962, 33);
            txtNombreDuenio.Name = "txtNombreDuenio";
            txtNombreDuenio.Size = new Size(158, 23);
            txtNombreDuenio.TabIndex = 18;
            // 
            // btnApellidoDuenio
            // 
            btnApellidoDuenio.Location = new Point(816, 91);
            btnApellidoDuenio.Name = "btnApellidoDuenio";
            btnApellidoDuenio.Size = new Size(140, 38);
            btnApellidoDuenio.TabIndex = 17;
            btnApellidoDuenio.Text = "Buscar por Apellido del Dueño";
            btnApellidoDuenio.UseVisualStyleBackColor = true;
            btnApellidoDuenio.Click += btnApellidoDuenio_Click;
            // 
            // btnNombreDuenio
            // 
            btnNombreDuenio.Location = new Point(816, 24);
            btnNombreDuenio.Name = "btnNombreDuenio";
            btnNombreDuenio.Size = new Size(140, 38);
            btnNombreDuenio.TabIndex = 16;
            btnNombreDuenio.Text = "Buscar por Nombre del Dueño";
            btnNombreDuenio.UseVisualStyleBackColor = true;
            btnNombreDuenio.Click += btnNombreDuenio_Click;
            // 
            // dgvViajes
            // 
            dgvViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViajes.Location = new Point(12, 266);
            dgvViajes.Name = "dgvViajes";
            dgvViajes.RowHeadersWidth = 51;
            dgvViajes.RowTemplate.Height = 25;
            dgvViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvViajes.Size = new Size(1345, 229);
            dgvViajes.TabIndex = 15;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(630, 501);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(109, 25);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(630, 226);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(109, 25);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(198, 138);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 25);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar Viaje";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(198, 91);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(109, 25);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar Viaje";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(198, 43);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(109, 25);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo Viaje";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtApellidoChofer
            // 
            txtApellidoChofer.Location = new Point(630, 100);
            txtApellidoChofer.Name = "txtApellidoChofer";
            txtApellidoChofer.Size = new Size(158, 23);
            txtApellidoChofer.TabIndex = 23;
            // 
            // txtNombreChofer
            // 
            txtNombreChofer.Location = new Point(630, 36);
            txtNombreChofer.Name = "txtNombreChofer";
            txtNombreChofer.Size = new Size(158, 23);
            txtNombreChofer.TabIndex = 22;
            // 
            // btnApellidoChofer
            // 
            btnApellidoChofer.Location = new Point(487, 91);
            btnApellidoChofer.Name = "btnApellidoChofer";
            btnApellidoChofer.Size = new Size(134, 38);
            btnApellidoChofer.TabIndex = 21;
            btnApellidoChofer.Text = "Buscar por Apellido del Chofer";
            btnApellidoChofer.UseVisualStyleBackColor = true;
            btnApellidoChofer.Click += btnApellidoChofer_Click;
            // 
            // btnNombreChofer
            // 
            btnNombreChofer.Location = new Point(487, 27);
            btnNombreChofer.Name = "btnNombreChofer";
            btnNombreChofer.Size = new Size(134, 38);
            btnNombreChofer.TabIndex = 20;
            btnNombreChofer.Text = "Buscar por Nombre del Chofer";
            btnNombreChofer.UseVisualStyleBackColor = true;
            btnNombreChofer.Click += btnNombreChofer_Click;
            // 
            // txtNroLiq
            // 
            txtNroLiq.Location = new Point(630, 160);
            txtNroLiq.Name = "txtNroLiq";
            txtNroLiq.Size = new Size(161, 23);
            txtNroLiq.TabIndex = 25;
            txtNroLiq.TextChanged += txtNroLiq_TextChanged;
            // 
            // btnNroLiq
            // 
            btnNroLiq.Location = new Point(487, 151);
            btnNroLiq.Name = "btnNroLiq";
            btnNroLiq.Size = new Size(134, 38);
            btnNroLiq.TabIndex = 24;
            btnNroLiq.Text = "Buscar por Nro Liq Prod";
            btnNroLiq.UseVisualStyleBackColor = true;
            btnNroLiq.Click += btnNroLiq_Click;
            // 
            // btnFecha
            // 
            btnFecha.Location = new Point(816, 151);
            btnFecha.Name = "btnFecha";
            btnFecha.Size = new Size(117, 38);
            btnFecha.TabIndex = 26;
            btnFecha.Text = "Buscar por Fecha";
            btnFecha.UseVisualStyleBackColor = true;
            btnFecha.Click += btnFecha_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(962, 158);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(158, 23);
            dtpFecha.TabIndex = 27;
            dtpFecha.Value = new DateTime(2024, 5, 7, 0, 0, 0, 0);
            // 
            // frmViajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 538);
            Controls.Add(dtpFecha);
            Controls.Add(btnFecha);
            Controls.Add(txtNroLiq);
            Controls.Add(btnNroLiq);
            Controls.Add(txtApellidoChofer);
            Controls.Add(txtNombreChofer);
            Controls.Add(btnApellidoChofer);
            Controls.Add(btnNombreChofer);
            Controls.Add(txtApellidoDuenio);
            Controls.Add(txtNombreDuenio);
            Controls.Add(btnApellidoDuenio);
            Controls.Add(btnNombreDuenio);
            Controls.Add(dgvViajes);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Name = "frmViajes";
            Text = "frmViajes";
            Load += frmViajes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViajes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtApellidoDuenio;
        private TextBox txtNombreDuenio;
        private Button btnApellidoDuenio;
        private Button btnNombreDuenio;
        private DataGridView dgvViajes;
        private Button btnSalir;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnNuevo;
        private TextBox txtApellidoChofer;
        private TextBox txtNombreChofer;
        private Button btnApellidoChofer;
        private Button btnNombreChofer;
        private TextBox txtNroLiq;
        private Button btnNroLiq;
        private Button btnFecha;
        private DateTimePicker dtpFecha;
    }
}