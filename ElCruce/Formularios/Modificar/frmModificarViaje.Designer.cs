namespace ElCruce.Formularios.Modificar
{
    partial class frmModificarViaje
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
            dgvViajes = new DataGridView();
            btnSalir = new Button();
            btnMoficar = new Button();
            txtTarifa = new TextBox();
            txtImporte = new TextBox();
            label7 = new Label();
            label8 = new Label();
            dtpFecha = new DateTimePicker();
            cbDuenio = new ComboBox();
            cbChofer = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvViajes).BeginInit();
            SuspendLayout();
            // 
            // txtNroLiq
            // 
            txtNroLiq.Location = new Point(628, 109);
            txtNroLiq.Name = "txtNroLiq";
            txtNroLiq.Size = new Size(128, 23);
            txtNroLiq.TabIndex = 29;
            // 
            // txtCombustible
            // 
            txtCombustible.Location = new Point(582, 76);
            txtCombustible.Name = "txtCombustible";
            txtCombustible.Size = new Size(128, 23);
            txtCombustible.TabIndex = 28;
            // 
            // txtEfectivo
            // 
            txtEfectivo.Location = new Point(582, 36);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(128, 23);
            txtEfectivo.TabIndex = 27;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(267, 109);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(128, 23);
            txtDestino.TabIndex = 26;
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(267, 71);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(128, 23);
            txtOrigen.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 112);
            label6.Name = "label6";
            label6.Size = new Size(149, 15);
            label6.TabIndex = 23;
            label6.Text = "Número Liquido Producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(473, 79);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 22;
            label5.Text = "Adelanto GasOil:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 39);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 21;
            label4.Text = "Adelanto Efectivo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 112);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 20;
            label3.Text = "Destino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 79);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 19;
            label2.Text = "Origen:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 39);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 18;
            label1.Text = "Fecha:";
            // 
            // dgvViajes
            // 
            dgvViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViajes.Location = new Point(12, 256);
            dgvViajes.Name = "dgvViajes";
            dgvViajes.RowTemplate.Height = 25;
            dgvViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvViajes.Size = new Size(1346, 164);
            dgvViajes.TabIndex = 17;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(681, 203);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMoficar
            // 
            btnMoficar.Location = new Point(525, 203);
            btnMoficar.Name = "btnMoficar";
            btnMoficar.Size = new Size(75, 23);
            btnMoficar.TabIndex = 15;
            btnMoficar.Text = "Guardar";
            btnMoficar.UseVisualStyleBackColor = true;
            btnMoficar.Click += btnMoficar_Click;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(843, 66);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(128, 23);
            txtTarifa.TabIndex = 33;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(922, 33);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(128, 23);
            txtImporte.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(799, 69);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 31;
            label7.Text = "Tarifa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(799, 36);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
            label8.TabIndex = 30;
            label8.Text = "Importe Liquidación:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(267, 36);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(128, 23);
            dtpFecha.TabIndex = 34;
            // 
            // cbDuenio
            // 
            cbDuenio.FormattingEnabled = true;
            cbDuenio.Location = new Point(1069, 109);
            cbDuenio.Name = "cbDuenio";
            cbDuenio.Size = new Size(98, 23);
            cbDuenio.TabIndex = 60;
            // 
            // cbChofer
            // 
            cbChofer.FormattingEnabled = true;
            cbChofer.Location = new Point(862, 109);
            cbChofer.Name = "cbChofer";
            cbChofer.Size = new Size(98, 23);
            cbChofer.TabIndex = 59;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(802, 112);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 58;
            label10.Text = "Chofer";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1010, 112);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 57;
            label9.Text = "Dueño";
            // 
            // frmModificarViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 450);
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
            Controls.Add(dgvViajes);
            Controls.Add(btnSalir);
            Controls.Add(btnMoficar);
            Name = "frmModificarViaje";
            Text = "frmModificarViaje";
            Load += frmModificarViaje_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViajes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private DataGridView dgvViajes;
        private Button btnSalir;
        private Button btnMoficar;
        private TextBox txtTarifa;
        private TextBox txtImporte;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpFecha;
        private ComboBox cbDuenio;
        private ComboBox cbChofer;
        private Label label10;
        private Label label9;
    }
}