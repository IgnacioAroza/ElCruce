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
            valorCombustibleToolStripMenuItem = new ToolStripMenuItem();
            dgvViajes = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViajes).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dueñosCamionToolStripMenuItem, choferesToolStripMenuItem, viajesToolStripMenuItem, valorCombustibleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1265, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dueñosCamionToolStripMenuItem
            // 
            dueñosCamionToolStripMenuItem.Name = "dueñosCamionToolStripMenuItem";
            dueñosCamionToolStripMenuItem.Size = new Size(104, 20);
            dueñosCamionToolStripMenuItem.Text = "Dueños Camion";
            dueñosCamionToolStripMenuItem.Click += dueñosCamionToolStripMenuItem_Click;
            // 
            // choferesToolStripMenuItem
            // 
            choferesToolStripMenuItem.Name = "choferesToolStripMenuItem";
            choferesToolStripMenuItem.Size = new Size(66, 20);
            choferesToolStripMenuItem.Text = "Choferes";
            choferesToolStripMenuItem.Click += choferesToolStripMenuItem_Click;
            // 
            // viajesToolStripMenuItem
            // 
            viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            viajesToolStripMenuItem.Size = new Size(49, 20);
            viajesToolStripMenuItem.Text = "Viajes";
            viajesToolStripMenuItem.Click += viajesToolStripMenuItem_Click;
            // 
            // valorCombustibleToolStripMenuItem
            // 
            valorCombustibleToolStripMenuItem.Name = "valorCombustibleToolStripMenuItem";
            valorCombustibleToolStripMenuItem.Size = new Size(116, 20);
            valorCombustibleToolStripMenuItem.Text = "Valor Combustible";
            valorCombustibleToolStripMenuItem.Click += valorCombustibleToolStripMenuItem_Click;
            // 
            // dgvViajes
            // 
            dgvViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViajes.Location = new Point(12, 116);
            dgvViajes.Name = "dgvViajes";
            dgvViajes.RowTemplate.Height = 25;
            dgvViajes.Size = new Size(1241, 225);
            dgvViajes.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 372);
            Controls.Add(dgvViajes);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
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
        private ToolStripMenuItem valorCombustibleToolStripMenuItem;
        private DataGridView dgvViajes;
    }
}