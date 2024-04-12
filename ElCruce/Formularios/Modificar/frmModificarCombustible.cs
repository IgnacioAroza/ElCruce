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
    public partial class frmModificarCombustible : Form
    {
        private int idCombustible;
        public frmModificarCombustible(int IdCombustible)
        {
            InitializeComponent();
            this.idCombustible = IdCombustible;
            if(IdCombustible > 0)
            {
                DataTable dt = new DataTable();
                dt = GasOil.BuscarXId(idCombustible);
                if(dt.Rows.Count > 0 )
                {
                    DataRow row = dt.Rows[0];
                    dtpFecha.Value = Convert.ToDateTime(row["Fecha"]);
                    txtValor.Text = row["Precio"].ToString();
                }
            }
        }

        private void frmModificarCombustible_Load(object sender, EventArgs e)
        {
            DataTable dtCombustible = GasOil.BuscarTodo();
            dgvCombustible.DataSource = dtCombustible;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!ValidarDatos())
            {
                return;
            }

            DateTime fecha = dtpFecha.Value;
            decimal valor = decimal.Parse(txtValor.Text);

            GasOil combustible = new GasOil(fecha, valor);
            combustible.Id = idCombustible;

            if (combustible.Modificar())
            {
                MessageBox.Show("Valor modificado correctamente.");
                Close();
            }
            else
            {
                MessageBox.Show("Error al modificar el valor");
            }
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("El valor del combustible es obligatorio");
                return false;
            }

            if (dtpFecha.Value == null)
            {
                MessageBox.Show("La fecha es obligatoria");
                return false;
            }

            return true;
        }
    }
}
