namespace ElCruce.Formularios.Modificar
{
    partial class frmModificarConductor
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
            btnMoficar = new Button();
            btnSalir = new Button();
            dgvChoferes = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCuil = new TextBox();
            txtPatente = new TextBox();
            txtChasis = new TextBox();
            txtAcoplado = new TextBox();
            label7 = new Label();
            cbDuenio = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvChoferes).BeginInit();
            SuspendLayout();
            // 
            // btnMoficar
            // 
            btnMoficar.Location = new Point(226, 220);
            btnMoficar.Name = "btnMoficar";
            btnMoficar.Size = new Size(75, 26);
            btnMoficar.TabIndex = 0;
            btnMoficar.Text = "Guardar";
            btnMoficar.UseVisualStyleBackColor = true;
            btnMoficar.Click += btnMoficar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(382, 220);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 26);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvChoferes
            // 
            dgvChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChoferes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChoferes.Location = new Point(12, 284);
            dgvChoferes.Name = "dgvChoferes";
            dgvChoferes.RowTemplate.Height = 25;
            dgvChoferes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChoferes.Size = new Size(719, 186);
            dgvChoferes.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 36);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 82);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 4;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 119);
            label3.Name = "label3";
            label3.Size = new Size(37, 17);
            label3.TabIndex = 5;
            label3.Text = "CUIL:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 36);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 6;
            label4.Text = "Patente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(326, 82);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 7;
            label5.Text = "Chasis:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(326, 119);
            label6.Name = "label6";
            label6.Size = new Size(67, 17);
            label6.TabIndex = 8;
            label6.Text = "Acoplado:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(120, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(128, 25);
            txtNombre.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(120, 73);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(128, 25);
            txtApellido.TabIndex = 10;
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(120, 116);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(128, 25);
            txtCuil.TabIndex = 11;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(398, 33);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(128, 25);
            txtPatente.TabIndex = 12;
            // 
            // txtChasis
            // 
            txtChasis.Location = new Point(398, 78);
            txtChasis.Name = "txtChasis";
            txtChasis.Size = new Size(128, 25);
            txtChasis.TabIndex = 13;
            // 
            // txtAcoplado
            // 
            txtAcoplado.Location = new Point(398, 116);
            txtAcoplado.Name = "txtAcoplado";
            txtAcoplado.Size = new Size(128, 25);
            txtAcoplado.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 172);
            label7.Name = "label7";
            label7.Size = new Size(49, 17);
            label7.TabIndex = 32;
            label7.Text = "Dueño:";
            // 
            // cbDuenio
            // 
            cbDuenio.FormattingEnabled = true;
            cbDuenio.Location = new Point(120, 169);
            cbDuenio.Name = "cbDuenio";
            cbDuenio.Size = new Size(128, 25);
            cbDuenio.TabIndex = 31;
            // 
            // frmModificarConductor
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 510);
            Controls.Add(label7);
            Controls.Add(cbDuenio);
            Controls.Add(txtAcoplado);
            Controls.Add(txtChasis);
            Controls.Add(txtPatente);
            Controls.Add(txtCuil);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvChoferes);
            Controls.Add(btnSalir);
            Controls.Add(btnMoficar);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmModificarConductor";
            Text = "Modificar Conductor";
            Load += frmModificarConductor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChoferes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMoficar;
        private Button btnSalir;
        private DataGridView dgvChoferes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCuil;
        private TextBox txtPatente;
        private TextBox txtChasis;
        private TextBox txtAcoplado;
        private Label label7;
        private ComboBox cbDuenio;
    }
}