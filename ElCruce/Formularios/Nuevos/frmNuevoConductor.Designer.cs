namespace ElCruce.Formularios.Nuevos
{
    partial class frmNuevoConductor
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
            txtAcoplado = new TextBox();
            txtChasis = new TextBox();
            txtPatente = new TextBox();
            txtCuil = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnSalir = new Button();
            btnMoficar = new Button();
            cbDuenio = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtAcoplado
            // 
            txtAcoplado.Location = new Point(359, 101);
            txtAcoplado.Name = "txtAcoplado";
            txtAcoplado.Size = new Size(128, 23);
            txtAcoplado.TabIndex = 28;
            // 
            // txtChasis
            // 
            txtChasis.Location = new Point(359, 68);
            txtChasis.Name = "txtChasis";
            txtChasis.Size = new Size(128, 23);
            txtChasis.TabIndex = 27;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(359, 28);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(128, 23);
            txtPatente.TabIndex = 26;
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(81, 101);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(128, 23);
            txtCuil.TabIndex = 25;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(81, 63);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(128, 23);
            txtApellido.TabIndex = 24;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(81, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(128, 23);
            txtNombre.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(287, 104);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 22;
            label7.Text = "Acoplado:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(287, 71);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 21;
            label8.Text = "Chasis:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(287, 31);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 20;
            label9.Text = "Patente:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 104);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 19;
            label10.Text = "CUIL:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 71);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 18;
            label11.Text = "Apellido:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 31);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 17;
            label12.Text = "Nombre:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(287, 198);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMoficar
            // 
            btnMoficar.Location = new Point(145, 198);
            btnMoficar.Name = "btnMoficar";
            btnMoficar.Size = new Size(75, 23);
            btnMoficar.TabIndex = 15;
            btnMoficar.Text = "Guardar";
            btnMoficar.UseVisualStyleBackColor = true;
            btnMoficar.Click += btnMoficar_Click;
            // 
            // cbDuenio
            // 
            cbDuenio.FormattingEnabled = true;
            cbDuenio.Location = new Point(210, 152);
            cbDuenio.Name = "cbDuenio";
            cbDuenio.Size = new Size(121, 23);
            cbDuenio.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 155);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 30;
            label1.Text = "Dueño:";
            // 
            // frmNuevoConductor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 261);
            Controls.Add(label1);
            Controls.Add(cbDuenio);
            Controls.Add(txtAcoplado);
            Controls.Add(txtChasis);
            Controls.Add(txtPatente);
            Controls.Add(txtCuil);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(btnSalir);
            Controls.Add(btnMoficar);
            Name = "frmNuevoConductor";
            Text = "frmNuevoConductor";
            Load += frmNuevoConductor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAcoplado;
        private TextBox txtChasis;
        private TextBox txtPatente;
        private TextBox txtCuil;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnSalir;
        private Button btnMoficar;
        private ComboBox cbDuenio;
        private Label label1;
    }
}