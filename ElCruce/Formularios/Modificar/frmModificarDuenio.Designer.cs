﻿namespace ElCruce.Formularios.Modificar
{
    partial class frmModificarDuenio
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
            btnSalir = new Button();
            btnGuardar = new Button();
            txtCuil = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvDuenio = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDuenio).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(197, 178);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 27);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(73, 178);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 27);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(129, 103);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(180, 23);
            txtCuil.TabIndex = 15;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(129, 62);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(180, 23);
            txtApellido.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(129, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 23);
            txtNombre.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 103);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 12;
            label3.Text = "CUIL:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 62);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 11;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 25);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 10;
            label1.Text = "Nombre:";
            // 
            // dgvDuenio
            // 
            dgvDuenio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDuenio.Location = new Point(12, 254);
            dgvDuenio.Name = "dgvDuenio";
            dgvDuenio.RowTemplate.Height = 25;
            dgvDuenio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDuenio.Size = new Size(446, 155);
            dgvDuenio.TabIndex = 18;
            // 
            // ModificarDuenio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 450);
            Controls.Add(dgvDuenio);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(txtCuil);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModificarDuenio";
            Text = "ModificarDuenio";
            Load += ModificarDuenio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDuenio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnGuardar;
        private TextBox txtCuil;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvDuenio;
    }
}