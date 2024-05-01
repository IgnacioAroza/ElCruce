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
            cbDuenio.DataSource = dtDuenios;
            cbDuenio.DisplayMember = "Name";
            cbDuenio.ValueMember = "Id";
        }
        private void CargarChofer()
        {
            DataTable dtDuenios = Conductor.BuscarTodo();
            cbChofer.DataSource = dtDuenios;
            cbChofer.DisplayMember = "Name";
            cbChofer.ValueMember = "Id";
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

            decimal valorCombustible = ObtenerValorLitroCombustible();

            decimal nuevoImporteLiquidacion = CalcularNuevoImporteLiquidacion(valorCombustible, Convert.ToDecimal(txtCombustible.Text.Trim()), Convert.ToDecimal(txtEfectivo.Text.Trim()), Convert.ToDecimal(txtImporte.Text.Trim()));

            Viajes nuevoViaje = new Viajes(dtpFecha.Value, txtOrigen.Text.Trim(), txtDestino.Text.Trim(), Convert.ToDecimal(txtEfectivo.Text.Trim()), Convert.ToDecimal(txtCombustible.Text.Trim()), Convert.ToDecimal(txtNroLiq.Text.Trim()), nuevoImporteLiquidacion, Convert.ToDecimal(txtTarifa.Text.Trim()), idChoferSeleccionado, idDuenioSeleccionado);

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
        private decimal ObtenerValorLitroCombustible()
        {
            decimal valorCombustible = GasOil.obtenerValorLitro();
            return valorCombustible;
        }
        private decimal CalcularNuevoImporteLiquidacion(decimal valorCombustible, decimal adelantoCombustible, decimal adelantoEfectivo, decimal importe)
        {
            decimal totalCombustible = valorCombustible * adelantoCombustible;

            decimal nuevoImporte = importe - (totalCombustible + adelantoEfectivo);
            return nuevoImporte;
        }
    }
}
