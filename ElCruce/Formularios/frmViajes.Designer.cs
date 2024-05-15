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
            txtApellidoDuenio.Location = new Point(962, 113);
            txtApellidoDuenio.Name = "txtApellidoDuenio";
            txtApellidoDuenio.Size = new Size(158, 25);
            txtApellidoDuenio.TabIndex = 19;
            // 
            // txtNombreDuenio
            // 
            txtNombreDuenio.Location = new Point(962, 37);
            txtNombreDuenio.Name = "txtNombreDuenio";
            txtNombreDuenio.Size = new Size(158, 25);
            txtNombreDuenio.TabIndex = 18;
            // 
            // btnApellidoDuenio
            // 
            btnApellidoDuenio.Location = new Point(816, 103);
            btnApellidoDuenio.Name = "btnApellidoDuenio";
            btnApellidoDuenio.Size = new Size(140, 43);
            btnApellidoDuenio.TabIndex = 17;
            btnApellidoDuenio.Text = "Buscar por Apellido del Dueño";
            btnApellidoDuenio.UseVisualStyleBackColor = true;
            btnApellidoDuenio.Click += btnApellidoDuenio_Click;
            // 
            // btnNombreDuenio
            // 
            btnNombreDuenio.Location = new Point(816, 27);
            btnNombreDuenio.Name = "btnNombreDuenio";
            btnNombreDuenio.Size = new Size(140, 43);
            btnNombreDuenio.TabIndex = 16;
            btnNombreDuenio.Text = "Buscar por Nombre del Dueño";
            btnNombreDuenio.UseVisualStyleBackColor = true;
            btnNombreDuenio.Click += btnNombreDuenio_Click;
            // 
            // dgvViajes
            // 
            dgvViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViajes.Location = new Point(12, 301);
            dgvViajes.Name = "dgvViajes";
            dgvViajes.RowHeadersWidth = 51;
            dgvViajes.RowTemplate.Height = 25;
            dgvViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvViajes.Size = new Size(1345, 260);
            dgvViajes.TabIndex = 15;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(630, 568);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(109, 28);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(630, 256);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(109, 28);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(198, 156);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 28);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar Viaje";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(198, 103);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(109, 28);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar Viaje";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(198, 49);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(109, 28);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo Viaje";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtApellidoChofer
            // 
            txtApellidoChofer.Location = new Point(630, 113);
            txtApellidoChofer.Name = "txtApellidoChofer";
            txtApellidoChofer.Size = new Size(158, 25);
            txtApellidoChofer.TabIndex = 23;
            // 
            // txtNombreChofer
            // 
            txtNombreChofer.Location = new Point(630, 41);
            txtNombreChofer.Name = "txtNombreChofer";
            txtNombreChofer.Size = new Size(158, 25);
            txtNombreChofer.TabIndex = 22;
            // 
            // btnApellidoChofer
            // 
            btnApellidoChofer.Location = new Point(487, 103);
            btnApellidoChofer.Name = "btnApellidoChofer";
            btnApellidoChofer.Size = new Size(134, 43);
            btnApellidoChofer.TabIndex = 21;
            btnApellidoChofer.Text = "Buscar por Apellido del Chofer";
            btnApellidoChofer.UseVisualStyleBackColor = true;
            btnApellidoChofer.Click += btnApellidoChofer_Click;
            // 
            // btnNombreChofer
            // 
            btnNombreChofer.Location = new Point(487, 31);
            btnNombreChofer.Name = "btnNombreChofer";
            btnNombreChofer.Size = new Size(134, 43);
            btnNombreChofer.TabIndex = 20;
            btnNombreChofer.Text = "Buscar por Nombre del Chofer";
            btnNombreChofer.UseVisualStyleBackColor = true;
            btnNombreChofer.Click += btnNombreChofer_Click;
            // 
            // txtNroLiq
            // 
            txtNroLiq.Location = new Point(630, 181);
            txtNroLiq.Name = "txtNroLiq";
            txtNroLiq.Size = new Size(161, 25);
            txtNroLiq.TabIndex = 25;
            txtNroLiq.TextChanged += txtNroLiq_TextChanged;
            // 
            // btnNroLiq
            // 
            btnNroLiq.Location = new Point(487, 171);
            btnNroLiq.Name = "btnNroLiq";
            btnNroLiq.Size = new Size(134, 43);
            btnNroLiq.TabIndex = 24;
            btnNroLiq.Text = "Buscar por Nro Liq Prod";
            btnNroLiq.UseVisualStyleBackColor = true;
            btnNroLiq.Click += btnNroLiq_Click;
            // 
            // btnFecha
            // 
            btnFecha.Location = new Point(816, 171);
            btnFecha.Name = "btnFecha";
            btnFecha.Size = new Size(117, 43);
            btnFecha.TabIndex = 26;
            btnFecha.Text = "Buscar por Fecha";
            btnFecha.UseVisualStyleBackColor = true;
            btnFecha.Click += btnFecha_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(962, 179);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(158, 25);
            dtpFecha.TabIndex = 27;
            dtpFecha.Value = new DateTime(2024, 5, 7, 0, 0, 0, 0);
            // 
            // frmViajes
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 610);
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
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmViajes";
            Text = "Viajes";
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