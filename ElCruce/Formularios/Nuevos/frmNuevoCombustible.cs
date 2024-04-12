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
    public partial class frmNuevoCombustible : Form
    {
        public frmNuevoCombustible()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool Correcto = true;
            DateTime fecha = new DateTime();
            decimal valor = 0;
            if (txtValor.Text.Trim() == "")
            {
                MessageBox.Show("El valor del combustible es obligatorio");
                Correcto = false;
            }
            else
            {
                if (!decimal.TryParse(txtValor.Text, out valor))
                {
                    MessageBox.Show("El valor es incorrecto");
                    Correcto = false;
                }
            }
            if (dtpFecha.Value == null)
            {
                MessageBox.Show("La fecha es obligatoria");
                Correcto = false;
            }
            else
            {
                if (!DateTime.TryParse(dtpFecha.Text.Trim(), out fecha))
                {
                    MessageBox.Show("La fecha no es valida");
                    Correcto = false;
                }
            }

            if (Correcto)
            {
                GasOil combustible = new GasOil(fecha, valor);
                if (combustible.Nuevo())
                {
                    MessageBox.Show("Valor guardado correctamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
