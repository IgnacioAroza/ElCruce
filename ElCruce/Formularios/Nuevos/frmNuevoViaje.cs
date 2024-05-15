using ElCruce.Entities;
using System.Data;

namespace ElCruce.Formularios.Nuevos
{
    public partial class frmNuevoViaje : Form
    {
        public frmNuevoViaje()
        {
            InitializeComponent();
            CargarChofer();
            CargarDuenios();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CargarDuenios()
        {
            DataTable dtDuenios = DuenioCamion.BuscarTodo();
            dtDuenios.Columns.Add("NombreCompleto", typeof(string), "Nombre + ', ' + Apellido");
            cbDuenio.DisplayMember = "NombreCompleto";
            cbDuenio.ValueMember = "ID";
            cbDuenio.DataSource = dtDuenios;
        }
        private void CargarChofer()
        {
            DataTable dtDuenios = Conductor.BuscarTodo();
            dtDuenios.Columns.Add("NombreCompleto", typeof(string), "Nombre + ', ' + Apellido");
            cbChofer.DisplayMember = "NombreCompleto";
            cbChofer.ValueMember = "ID";
            cbChofer.DataSource = dtDuenios;
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtOrigen.Text))
            {
                MessageBox.Show("El origen es obligatorio");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDestino.Text))
            {
                MessageBox.Show("El destino es obligatorio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNroLiq.Text))
            {
                MessageBox.Show("El Número de liquido producto es obligatorio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtImporte.Text))
            {
                MessageBox.Show("El importe de luquidación es obligatorio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTarifa.Text))
            {
                MessageBox.Show("La tarifa es obligatoria");
                return false;
            }

            return true;
        }

        private void btnMoficar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            int idDuenioSeleccionado = Convert.ToInt32(cbDuenio.SelectedValue);
            int idChoferSeleccionado = Convert.ToInt32(cbChofer.SelectedValue);

            DateTime fecha = dtpFecha.Value.Date;

            Viajes nuevoViaje = new Viajes(fecha, txtOrigen.Text.Trim(), txtDestino.Text.Trim(), Convert.ToDecimal(txtEfectivo.Text.Trim()), Convert.ToDecimal(txtCombustible.Text.Trim()), Convert.ToInt32(txtNroLiq.Text.Trim()), Convert.ToDecimal(txtImporte.Text.Trim()), Convert.ToDecimal(txtTarifa.Text.Trim()), idChoferSeleccionado, idDuenioSeleccionado);

            if (nuevoViaje.Nuevo())
            {
                MessageBox.Show("Viaje creado correctamente");
                Close();
            }
            else
            {
                MessageBox.Show("Error al guardar el viaje");
            }
        }
    }
}
