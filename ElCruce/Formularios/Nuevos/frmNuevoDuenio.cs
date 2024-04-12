﻿using ElCruce.Entities;
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
    public partial class frmNuevoDuenio : Form
    {
        public frmNuevoDuenio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool correcto = true;
            if(txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El nombre es obligatorio");
                correcto = false;
            }
            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("El apellido es obligatorio");
                correcto = false;
            }
            if (txtCuil.Text.Trim() == "")
            {
                MessageBox.Show("El CUIL es obligatorio");
                correcto = false;
            }

            if (correcto)
            {
                DuenioCamion duenio = new DuenioCamion(txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtCuil.Text.Trim());
                if (duenio.Nuevo())
                {
                    MessageBox.Show("Guardado Correctamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}