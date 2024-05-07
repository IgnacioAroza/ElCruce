namespace ElCruce.Formularios.Nuevos
{
    partial class frmNuevoDuenio
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCuil = new TextBox();
            btnGuardar = new Button();
            btnSalir = new Button();
            txtCBU = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 29);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 66);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 107);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "CUIT:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(123, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(123, 66);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(180, 23);
            txtApellido.TabIndex = 4;
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(123, 107);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(180, 23);
            txtCuil.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(65, 216);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 27);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(189, 216);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 27);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtCBU
            // 
            txtCBU.Location = new Point(123, 147);
            txtCBU.Name = "txtCBU";
            txtCBU.Size = new Size(180, 23);
            txtCBU.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 147);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 10;
            label4.Text = "CBU/Alias:";
            // 
            // frmNuevoDuenio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 269);
            Controls.Add(txtCBU);
            Controls.Add(label4);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(txtCuil);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNuevoDuenio";
            Text = "NuevoDuenio";
            Load += frmNuevoDuenio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCuil;
        private Button btnGuardar;
        private Button btnSalir;
        private TextBox txtCBU;
        private Label label4;
    }
}