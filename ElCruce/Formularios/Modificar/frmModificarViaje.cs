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
    public partial class frmModificarViaje : Form
    {
        public int _id;
        public int _truckOwnerId;
        public int _choferId;
        public frmModificarViaje(int idSeleccionado)
        {
            InitializeComponent();
            CargarChofer();
            CargarDuenios();
            this._id = idSeleccionado;
            if (idSeleccionado > 0)
            {
                DataTable dt = new DataTable();
                dt = Viajes.BuscarXId(_id);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    dtpFecha.Value = Convert.ToDateTime(row["Fecha"]);
                    txtOrigen.Text = row["Origen"].ToString();
                    txtDestino.Text = row["Destino"].ToString();
                    txtEfectivo.Text = row["AdelantoEfectivo"].ToString();
                    txtCombustible.Text = row["AdelantoCombustible"].ToString();
                    txtNroLiq.Text = row["NumeroLiquidoProducto"].ToString();
                    txtImporte.Text = row["ImporteLiquidacion"].ToString();
                    txtTarifa.Text = row["Tarifa"].ToString();
                    _choferId = Convert.ToInt32(row["IdChofer"]);
                    _truckOwnerId = Convert.ToInt32(row["IdDueño"]);

                    cbChofer.SelectedValue = _choferId;
                    cbDuenio.SelectedValue = _truckOwnerId;
                }
            }
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

        private void frmModificarViaje_Load(object sender, EventArgs e)
        {
            DataTable dt = Viajes.BuscarTodo();
            dgvViajes.DataSource = dt;
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

            DateTime fecha = dtpFecha.Value.Date;
            int idDueñoSeleccionado = Convert.ToInt32(cbDuenio.SelectedValue);
            int idChoferSeleccionado = Convert.ToInt32(cbChofer.SelectedValue);

            Viajes viaje = new Viajes(fecha, txtOrigen.Text.Trim(), txtDestino.Text.Trim(), Convert.ToDecimal(txtEfectivo.Text.Trim()), Convert.ToDecimal(txtCombustible.Text.Trim()), Convert.ToDecimal(txtNroLiq.Text.Trim()), Convert.ToDecimal(txtImporte.Text.Trim()), Convert.ToDecimal(txtTarifa.Text.Trim()), idChoferSeleccionado, idDueñoSeleccionado);
            viaje.Id = _id;

            if (viaje.Modificar())
            {
                MessageBox.Show("Viaje modificado con exito");
                Close();
            }
            else
            {
                MessageBox.Show("Error al modificar el viaje");
            }
        }
    }
}
