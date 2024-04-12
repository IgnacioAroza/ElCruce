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

namespace ElCruce.Formularios
{
    public partial class frmCombustible : Form
    {
        public frmCombustible()
        {
            InitializeComponent();
        }

        private void frmCombustible_Load(object sender, EventArgs e)
        {
            DataTable dtCombustible = GasOil.BuscarTodo();
            dgvCombustible.DataSource = dtCombustible;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCombustible.SelectedRows.Count > 0)
            {
                int id;
                id = Convert.ToInt32(dgvCombustible.CurrentRow.Cells[0].Value);

                DialogResult Borra = MessageBox.Show("Seguro que quiere eliminar el valor del combustible?", "Advertencia", MessageBoxButtons.YesNo);
                if (Borra == DialogResult.Yes)
                {
                    GasOil.Eliminar(id);
                }
                else
                {
                    MessageBox.Show("Seleecione un valor");
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoCombustible frmNuevoCombustible = new frmNuevoCombustible();
            frmNuevoCombustible.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCombustible.SelectedRows.Count > 0)
            {
                int id;
                id = Convert.ToInt32(dgvCombustible.CurrentRow.Cells[0].Value);
                frmModificarCombustible frmModificar = new frmModificarCombustible(id);
                frmModificar.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un valor");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataTable dtCombustible = GasOil.BuscarTodo();
            dgvCombustible.DataSource = dtCombustible;
        }
    }
}
