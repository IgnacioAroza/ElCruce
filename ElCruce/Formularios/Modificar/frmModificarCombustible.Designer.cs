namespace ElCruce.Formularios.Modificar
{
    partial class frmModificarCombustible
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
            dtpFecha = new DateTimePicker();
            txtValor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCombustible).BeginInit();
            SuspendLayout();
            // 
            // dgvCombustible
            // 
            dgvCombustible.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCombustible.Location = new Point(12, 226);
            dgvCombustible.Name = "dgvCombustible";
            dgvCombustible.RowTemplate.Height = 25;
            dgvCombustible.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCombustible.Size = new Size(341, 170);
            dgvCombustible.TabIndex = 1;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(86, 29);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(221, 23);
            dtpFecha.TabIndex = 2;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(86, 66);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(220, 23);
            txtValor.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 35);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 4;
            label1.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 69);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "Valor en $:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(79, 175);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(92, 27);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Modificar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(205, 175);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(92, 27);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmModificarCombustible
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 415);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtValor);
            Controls.Add(dtpFecha);
            Controls.Add(dgvCombustible);
            Name = "frmModificarCombustible";
            Text = "frmModificarCombustible";
            Load += frmModificarCombustible_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCombustible).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCombustible;
        private DateTimePicker dtpFecha;
        private TextBox txtValor;
        private Label label1;
        private Label label2;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}