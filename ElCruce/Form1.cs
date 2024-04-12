using ElCruce.Entities;
using ElCruce.Formularios;
using System.Data;

namespace ElCruce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtViajes = Viajes.BuscarTodo();
            dgvViajes.DataSource = dtViajes;
        }

        private void dueñosCamionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDuenios frmDuenios = new frmDuenios();
            frmDuenios.Show();
        }

        private void choferesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConductores frmConductores = new frmConductores();
            frmConductores.Show();
        }

        private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViajes frmViajes = new frmViajes();
            frmViajes.Show();
        }

        private void valorCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCombustible frmCombustible = new frmCombustible();
            frmCombustible.Show();
        }
    }
}