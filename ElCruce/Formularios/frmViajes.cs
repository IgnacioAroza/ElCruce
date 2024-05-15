using ElCruce.Entities;
using ElCruce.Formularios.Modificar;
using ElCruce.Formularios.Nuevos;
using System.Data;

namespace ElCruce.Formularios
{
    public partial class frmViajes : Form
    {
        public frmViajes()
        {
            InitializeComponent();
        }

        private void LlenarGrilla(DataTable datos)
        {
            dgvViajes.DataSource = null;
            dgvViajes.DataSource = datos;
        }

        private void frmViajes_Load(object sender, EventArgs e)
        {
            DataTable dt = Viajes.BuscarTodo();
            dgvViajes.DataSource = dt;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataTable dt = Viajes.BuscarTodo();
            dgvViajes.DataSource = dt;
        }

        private void btnNombreChofer_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Viajes.BuscarXNombreChofer(txtNombreChofer.Text.Trim());
            LlenarGrilla(dt);
            txtNombreChofer.Text = "";
        }

        private void btnApellidoChofer_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Viajes.BuscarXApellidoChofer(txtApellidoChofer.Text.Trim());
            LlenarGrilla(dt);
            txtApellidoChofer.Text = "";
        }

        private void btnNombreDuenio_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Viajes.BuscarXNombreDuenio(txtNombreDuenio.Text.Trim());
            LlenarGrilla(dt);
            txtNombreDuenio.Text = "";
        }

        private void btnApellidoDuenio_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Viajes.BuscarXApellidoDuenio(txtApellidoDuenio.Text.Trim());
            LlenarGrilla(dt);
            txtApellidoDuenio.Text = "";
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

        private void btnFecha_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value;
            DataTable resultado = Viajes.BuscarXFecha(fecha);
            if (resultado != null && resultado.Rows.Count > 0)
            {
                dgvViajes.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("No se encontraron viajes para la fecha buscada");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoViaje frmNuevo = new frmNuevoViaje();
            frmNuevo.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvViajes.SelectedRows.Count > 0)
            {
                int id;
                id = Convert.ToInt32(dgvViajes.CurrentRow.Cells[0].Value);
                frmModificarViaje frmModificar = new frmModificarViaje(id);
                frmModificar.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un Viaje");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvViajes.SelectedRows.Count > 0)
            {
                int id;
                id = Convert.ToInt32(dgvViajes.SelectedRows[0].Cells[0].Value);
                DialogResult borra = MessageBox.Show("Seguro que quiere eliminar el viaje?", "Advertencia", MessageBoxButtons.YesNo);
                if (borra == DialogResult.Yes)
                {
                    Viajes.Eliminar(id);
                    MessageBox.Show("Viaje eliminado");
                }
                else
                {
                    MessageBox.Show("Seleccione un Viaje");
                }
            }
        }

        private void txtNroLiq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
