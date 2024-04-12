namespace ElCruce.Formularios.Nuevos
{
    partial class frmNuevoCombustible
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
            txtValor = new TextBox();
            dtpFecha = new DateTimePicker();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 33);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 62);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor en $:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(77, 59);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(183, 23);
            txtValor.TabIndex = 2;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(76, 27);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(216, 23);
            dtpFecha.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(32, 130);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(70, 25);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(144, 130);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(70, 26);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmNuevoCombustible
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 191);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFecha);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNuevoCombustible";
            Text = "frmNuevoCombustible";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtValor;
        private DateTimePicker dtpFecha;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}