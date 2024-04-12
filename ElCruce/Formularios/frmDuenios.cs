using ElCruce.Entities;
using ElCruce.Formularios.Modificar;
using ElCruce.Formularios.Nuevos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElCruce
{
    public partial class frmDuenios : Form
    {
        public frmDuenios()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDuenios_Load(object sender, EventArgs e)
        {
            DataTable dtDuenio = DuenioCamion.BuscarTodo();
            dgvDuenio.DataSource = dtDuenio;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDuenio.SelectedRows.Count > 0)
            {
                int id;
                id = Convert.ToInt32(dgvDuenio.CurrentRow.Cells[0].Value);

                DialogResult borra = MessageBox.Show("Seguro que quiere eliminar el valor del Dueño?", "Advertencia", MessageBoxButtons.YesNo);
                if (borra == DialogResult.Yes)
                {
                    DuenioCamion.Eliminar(id);
                    MessageBox.Show("Dueño eliminado");
                }
                else
                {
                    MessageBox.Show("Seleccione un valor");
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoDuenio frmNuevoDuenio = new frmNuevoDuenio();
            frmNuevoDuenio.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDuenio.SelectedRows.Count > 0)
            {
                int id;
                id = Convert.ToInt32(dgvDuenio.CurrentRow.Cells[0].Value);
                frmModificarDuenio frmModificar = new frmModificarDuenio(id);
                frmModificar.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un dueño");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataTable dtDuenio = DuenioCamion.BuscarTodo();
            dgvDuenio.DataSource = dtDuenio;
        }
    }
}
