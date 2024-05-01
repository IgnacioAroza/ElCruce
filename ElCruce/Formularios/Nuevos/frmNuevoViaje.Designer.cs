namespace ElCruce.Formularios.Nuevos
{
    partial class frmNuevoViaje
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
            dtpFecha = new DateTimePicker();
            txtTarifa = new TextBox();
            txtImporte = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtNroLiq = new TextBox();
            txtCombustible = new TextBox();
            txtEfectivo = new TextBox();
            txtDestino = new TextBox();
            txtOrigen = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSalir = new Button();
            btnMoficar = new Button();
            label9 = new Label();
            label10 = new Label();
            cbChofer = new ComboBox();
            cbDuenio = new ComboBox();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(101, 33);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(182, 23);
            dtpFecha.TabIndex = 52;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(677, 63);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(128, 23);
            txtTarifa.TabIndex = 51;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(756, 30);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(128, 23);
            txtImporte.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(633, 66);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 49;
            label7.Text = "Tarifa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(633, 33);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
            label8.TabIndex = 48;
            label8.Text = "Importe Liquidación:";
            // 
            // txtNroLiq
            // 
            txtNroLiq.Location = new Point(462, 106);
            txtNroLiq.Name = "txtNroLiq";
            txtNroLiq.Size = new Size(128, 23);
            txtNroLiq.TabIndex = 47;
            // 
            // txtCombustible
            // 
            txtCombustible.Location = new Point(416, 73);
            txtCombustible.Name = "txtCombustible";
            txtCombustible.Size = new Size(128, 23);
            txtCombustible.TabIndex = 46;
            // 
            // txtEfectivo
            // 
            txtEfectivo.Location = new Point(416, 33);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(128, 23);
            txtEfectivo.TabIndex = 45;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(101, 106);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(128, 23);
            txtDestino.TabIndex = 44;
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(101, 68);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(128, 23);
            txtOrigen.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(307, 109);
            label6.Name = "label6";
            label6.Size = new Size(149, 15);
            label6.TabIndex = 42;
            label6.Text = "Número Liquido Producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 76);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 41;
            label5.Text = "Adelanto GasOil:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 36);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 40;
            label4.Text = "Adelanto Efectivo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 109);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 39;
            label3.Text = "Destino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 76);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 38;
            label2.Text = "Origen:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 36);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 37;
            label1.Text = "Fecha:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(515, 245);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 36;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMoficar
            // 
            btnMoficar.Location = new Point(358, 245);
            btnMoficar.Name = "btnMoficar";
            btnMoficar.Size = new Size(75, 23);
            btnMoficar.TabIndex = 35;
            btnMoficar.Text = "Guardar";
            btnMoficar.UseVisualStyleBackColor = true;
            btnMoficar.Click += btnMoficar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(515, 163);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 53;
            label9.Text = "IDDueño";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(307, 163);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 54;
            label10.Text = "IDChofer";
            // 
            // cbChofer
            // 
            cbChofer.FormattingEnabled = true;
            cbChofer.Location = new Point(367, 160);
            cbChofer.Name = "cbChofer";
            cbChofer.Size = new Size(98, 23);
            cbChofer.TabIndex = 55;
            // 
            // cbDuenio
            // 
            cbDuenio.FormattingEnabled = true;
            cbDuenio.Location = new Point(574, 160);
            cbDuenio.Name = "cbDuenio";
            cbDuenio.Size = new Size(98, 23);
            cbDuenio.TabIndex = 56;
            // 
            // frmNuevoViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 314);
            Controls.Add(cbDuenio);
            Controls.Add(cbChofer);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dtpFecha);
            Controls.Add(txtTarifa);
            Controls.Add(txtImporte);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtNroLiq);
            Controls.Add(txtCombustible);
            Controls.Add(txtEfectivo);
            Controls.Add(txtDestino);
            Controls.Add(txtOrigen);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnMoficar);
            Name = "frmNuevoViaje";
            Text = "frmNuevoViaje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private TextBox txtTarifa;
        private TextBox txtImporte;
        private Label label7;
        private Label label8;
        private TextBox txtNroLiq;
        private TextBox txtCombustible;
        private TextBox txtEfectivo;
        private TextBox txtDestino;
        private TextBox txtOrigen;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSalir;
        private Button btnMoficar;
        private Label label9;
        private Label label10;
        private ComboBox cbChofer;
        private ComboBox cbDuenio;
    }
}