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
    public partial class frmConductores : Form
    {
        public frmConductores()
        {
            InitializeComponent();
        }

        private void LlenarGrilla(DataTable datos)
        {
            dgvConductores.DataSource = null;
            dgvConductores.DataSource = datos;
        }

        private void frmConductores_Load(object sender, EventArgs e)
        {
            DataTable dt = Conductor.BuscarTodo();
            dgvConductores.DataSource = dt;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataTable dt = Conductor.BuscarTodo();
            dgvConductores.DataSource = dt;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoConductor frmNuevo = new frmNuevoConductor();
            frmNuevo.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvConductores.SelectedRows.Count > 0)
            {
                int id;
                id = Convert.ToInt32(dgvConductores.CurrentRow.Cells[0].Value);
                frmModificarConductor frmModificar = new frmModificarConductor(id);
                frmModificar.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un Chofer");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvConductores.SelectedRows.Count > 0)
            {
                int id;
                id = Convert.ToInt32(dgvConductores.CurrentRow.Cells[0].Value);
                DialogResult borra = MessageBox.Show("Seguro que quiere eliminar el valor del Conductor?", "Advertencia", MessageBoxButtons.YesNo);
                if (borra == DialogResult.Yes)
                {
                    Conductor.Eliminar(id);
                    MessageBox.Show("Conductor Eliminado");
                }
                else
                {
                    MessageBox.Show("Selecciones un Conductor");
                }
            }
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Conductor.BuscarXNombre(txtNombre.Text.Trim());
            LlenarGrilla(dt);
            txtNombre.Text = "";
        }

        private void btnBuscarApellido_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Conductor.BuscarXApellido(txtApellido.Text.Trim());
            LlenarGrilla(dt);
            txtApellido.Text = "";
        }
    }
}
