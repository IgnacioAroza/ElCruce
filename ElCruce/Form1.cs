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

        private void due˝osCamionToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void btnNroLiq_Click(object sender, EventArgs e)
        {
            decimal valorBuscado;
            if (!decimal.TryParse(txtNroLiq.Text, out valorBuscado))
            {
                MessageBox.Show("Por favor, ingrese un valor valido");
                return;
            }

            DataTable resultado = Viajes.BuscarXLiquidoProducto(valorBuscado);
            if (resultado != null && resultado.Rows.Count > 0)
            {
                dgvViajes.DataSource = resultado;
                txtNroLiq.Text = "";
            }
            else
            {
                MessageBox.Show("No se encontraron viajes para el valor de Liquido Producto buscado");
            }
        }

        private void btnBuscarTodo_Click(object sender, EventArgs e)
        {
            DataTable dt = Viajes.BuscarTodo();
            dgvViajes.DataSource = dt;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvViajes.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvViajes.SelectedRows[0];
                DataRow filaDatos = ((DataRowView)filaSeleccionada.DataBoundItem).Row;
                //Llamar al metodo para exportar
                ExportarPDF.ExportarViaje(filaDatos);
                MessageBox.Show("Exportado Correctamente");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila antes de exportar");
            }
        }
    }
}