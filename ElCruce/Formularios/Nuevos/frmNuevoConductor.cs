using ElCruce.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElCruce.Formularios.Nuevos
{
    public partial class frmNuevoConductor : Form
    {
        public frmNuevoConductor()
        {
            InitializeComponent();
            CargarDueños();
        }

        private void btnMoficar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            int idDueñoSeleccionado = Convert.ToInt32(cbDuenio.SelectedValue);

            Conductor nuevoConductor = new Conductor(txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtCuil.Text.Trim(), txtPatente.Text.Trim(), txtChasis.Text.Trim(), txtAcoplado.Text.Trim(), idDueñoSeleccionado);

            if (nuevoConductor.Nuevo())
            {
                MessageBox.Show("Conductor guardado correctamente.");
                Close();
            }
            else
            {
                MessageBox.Show("Error al guardar el conductor.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarDueños()
        {
            DataTable dtDuenios = DuenioCamion.BuscarTodo();
            dtDuenios.Columns.Add("NombreCompleto", typeof(string), "Nombre + ', ' + Apellido");
            cbDuenio.DisplayMember = "NombreCompleto";
            cbDuenio.ValueMember = "ID";
            cbDuenio.DataSource = dtDuenios;
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCuil.Text))
            {
                MessageBox.Show("El CUIL es obligatorio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPatente.Text))
            {
                MessageBox.Show("La patente es obligatoria");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtChasis.Text))
            {
                MessageBox.Show("El chasis es obligatorio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAcoplado.Text))
            {
                MessageBox.Show("El acoplado es obligatorio");
                return false;
            }

            return true;
        }
    }
}
