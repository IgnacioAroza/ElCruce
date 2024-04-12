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

namespace ElCruce.Formularios.Modificar
{
    public partial class frmModificarConductor : Form
    {
        private int _id;
        private int _truckOwnerId;
        public frmModificarConductor(int idSeleccionado)
        {
            InitializeComponent();
            this._id = idSeleccionado;
            if (idSeleccionado > 0)
            {
                DataTable dt = new DataTable();
                dt = Conductor.BuscarXId(_id);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtNombre.Text = row["Nombre"].ToString();
                    txtApellido.Text = row["Apellido"].ToString();
                    txtCuil.Text = row["CUIL"].ToString();
                    txtPatente.Text = row["Patente"].ToString();
                    txtChasis.Text = row["Chasis"].ToString();
                    txtAcoplado.Text = row["Acoplado"].ToString();
                    _truckOwnerId = Convert.ToInt32(row["truckOwnerId"]);
                }
            }
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

        private void frmModificarConductor_Load(object sender, EventArgs e)
        {
            DataTable dtConductor = Conductor.BuscarTodo();
            dgvChoferes.DataSource = dtConductor;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMoficar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            Conductor conductor = new Conductor(txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtCuil.Text.Trim(), txtPatente.Text.Trim(), txtChasis.Text.Trim(), txtAcoplado.Text.Trim(), _truckOwnerId);

            if (conductor.Modificar())
            {
                MessageBox.Show("Conductor modificador correctamente");
                Close();
            }
            else
            {
                MessageBox.Show("Error al modificar el conductor");
            }
        }
    }
}
