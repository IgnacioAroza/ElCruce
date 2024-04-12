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
    public partial class frmModificarDuenio : Form
    {
        private int _id;
        public frmModificarDuenio(int idDuenio)
        {
            InitializeComponent();
            this._id = idDuenio;
            if (idDuenio > 0)
            {
                DataTable dt = new DataTable();
                dt = DuenioCamion.BuscarXId(_id);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtNombre.Text = row["Nombre"].ToString();
                    txtApellido.Text = row["Apellido"].ToString();
                    txtCuil.Text = row["CUIT"].ToString();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
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

            return true;
        }

        private void ModificarDuenio_Load(object sender, EventArgs e)
        {
            DataTable dtDuenio = DuenioCamion.BuscarTodo();
            dgvDuenio.DataSource = dtDuenio;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            DuenioCamion duenio = new DuenioCamion(txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtCuil.Text.Trim());
            duenio.Id = _id;

            if (duenio.Modificar())
            {
                MessageBox.Show("Dueño modificado correctamente.");
                Close();
            }
            else
            {
                MessageBox.Show("Error al modificar el Dueño");
            }
        }
    }
}
