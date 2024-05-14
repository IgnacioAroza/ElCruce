namespace ElCruce
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            dueñosCamionToolStripMenuItem = new ToolStripMenuItem();
            choferesToolStripMenuItem = new ToolStripMenuItem();
            viajesToolStripMenuItem = new ToolStripMenuItem();
            dgvViajes = new DataGridView();
            txtNroLiq = new TextBox();
            btnNroLiq = new Button();
            btnBuscarTodo = new Button();
            btnExportar = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViajes).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dueñosCamionToolStripMenuItem, choferesToolStripMenuItem, viajesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1400, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dueñosCamionToolStripMenuItem
            // 
            dueñosCamionToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dueñosCamionToolStripMenuItem.Name = "dueñosCamionToolStripMenuItem";
            dueñosCamionToolStripMenuItem.Size = new Size(143, 25);
            dueñosCamionToolStripMenuItem.Text = "Dueños Camion";
            dueñosCamionToolStripMenuItem.Click += dueñosCamionToolStripMenuItem_Click;
            // 
            // choferesToolStripMenuItem
            // 
            choferesToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            choferesToolStripMenuItem.Name = "choferesToolStripMenuItem";
            choferesToolStripMenuItem.Size = new Size(89, 25);
            choferesToolStripMenuItem.Text = "Choferes";
            choferesToolStripMenuItem.Click += choferesToolStripMenuItem_Click;
            // 
            // viajesToolStripMenuItem
            // 
            viajesToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            viajesToolStripMenuItem.Size = new Size(68, 25);
            viajesToolStripMenuItem.Text = "Viajes";
            viajesToolStripMenuItem.Click += viajesToolStripMenuItem_Click;
            // 
            // dgvViajes
            // 
            dgvViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViajes.Dock = DockStyle.Bottom;
            dgvViajes.Location = new Point(0, -218);
            dgvViajes.Name = "dgvViajes";
            dgvViajes.RowHeadersWidth = 51;
            dgvViajes.RowTemplate.Height = 25;
            dgvViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvViajes.Size = new Size(1400, 700);
            dgvViajes.TabIndex = 1;
            // 
            // txtNroLiq
            // 
            txtNroLiq.Location = new Point(949, 72);
            txtNroLiq.Name = "txtNroLiq";
            txtNroLiq.Size = new Size(156, 23);
            txtNroLiq.TabIndex = 27;
            // 
            // btnNroLiq
            // 
            btnNroLiq.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNroLiq.Location = new Point(748, 63);
            btnNroLiq.Name = "btnNroLiq";
            btnNroLiq.Size = new Size(195, 38);
            btnNroLiq.TabIndex = 26;
            btnNroLiq.Text = "Buscar por Nro Liq Prod";
            btnNroLiq.UseVisualStyleBackColor = true;
            btnNroLiq.Click += btnNroLiq_Click;
            // 
            // btnBuscarTodo
            // 
            btnBuscarTodo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarTodo.Location = new Point(312, 62);
            btnBuscarTodo.Name = "btnBuscarTodo";
            btnBuscarTodo.Size = new Size(105, 39);
            btnBuscarTodo.TabIndex = 28;
            btnBuscarTodo.Text = "Buscar Todo";
            btnBuscarTodo.UseVisualStyleBackColor = true;
            btnBuscarTodo.Click += btnBuscarTodo_Click;
            // 
            // btnExportar
            // 
            btnExportar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExportar.Location = new Point(475, 63);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(124, 38);
            btnExportar.TabIndex = 29;
            btnExportar.Text = "Exportar PDF";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 482);
            Controls.Add(btnExportar);
            Controls.Add(btnBuscarTodo);
            Controls.Add(txtNroLiq);
            Controls.Add(btnNroLiq);
            Controls.Add(dgvViajes);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViajes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dueñosCamionToolStripMenuItem;
        private ToolStripMenuItem choferesToolStripMenuItem;
        private ToolStripMenuItem viajesToolStripMenuItem;
        private DataGridView dgvViajes;
        private TextBox txtNroLiq;
        private Button btnNroLiq;
        private Button btnBuscarTodo;
        private Button btnExportar;
    }
}