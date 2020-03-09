using app_datos_cliente.models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_datos_cliente
{
    public partial class Form1 : Form
    {
        datos.metodos m = new datos.metodos();

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m.GetPaises(dgvPaises);
            m.GetCiudades(dgvCiudades);
        }

        private void btnGuardarPais_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text.Length <= 2)
            {
                m.NuevoPais(txtCodigo.Text, txtPais.Text, dgvPaises);
                txtCodigo.Clear();
                txtPais.Clear();
            } 
            else
            {
                MessageBox.Show("El codigo debe tener 2 dígitos.");
            }
        }

        private void btnEditarPais_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text.Length <= 2)
            {
                m.ModificarPais(txtCodigo.Text, txtPais.Text, dgvPaises);
                txtCodigo.Clear();
                txtPais.Clear();
                txtCodigo.Enabled = true;
                btnGuardarPais.Enabled = true;
                btnEditarPais.Enabled = false;
                btnEliminarPais.Enabled = false;
            }
            else
            {
                MessageBox.Show("El codigo debe tener 2 dígitos.");
            }
        }

        private void btnEliminarPais_Click(object sender, EventArgs e)
        {
            m.EliminarPais(txtCodigo.Text, dgvPaises);
            txtCodigo.Clear();
            txtPais.Clear();
            txtCodigo.Enabled = true;
            btnGuardarPais.Enabled = true;
            btnEditarPais.Enabled = false;
            btnEliminarPais.Enabled = false;
        }

        private void btnGuardarCiudad_Click(object sender, EventArgs e)
        {
            if (txtCodigoPais.Text.Length <= 2)
            {
                m.NuevaCiudad(txtCodigoPais.Text, txtCiudad.Text, dgvCiudades);
                txtCodigoPais.Clear();
                txtCiudad.Clear();
            }
            else
            {
                MessageBox.Show("El codigo debe tener 2 dígitos.");
            }
        }

        private void btnEditarCiudad_Click(object sender, EventArgs e)
        {
            if (txtCodigoPais.Text.Length <= 2)
            {
                m.ModificarCiudad(int.Parse(txtIdCiudad.Text), txtCodigoPais.Text, txtCiudad.Text, dgvCiudades);
                txtCodigoPais.Clear();
                txtCiudad.Clear();
                txtCodigoPais.Enabled = true;
                btnGuardarCiudad.Enabled = true;
                btnEditarCiudad.Enabled = false;
                btnEliminarCiudad.Enabled = false;
            }
            else
            {
                MessageBox.Show("El codigo debe tener 2 dígitos.");
            }
        }

        private void btnEliminarCiudad_Click(object sender, EventArgs e)
        {
            m.EliminarCiudad(int.Parse(txtIdCiudad.Text), dgvCiudades);
            txtCodigoPais.Clear();
            txtCiudad.Clear();
            txtCodigoPais.Enabled = true;
            btnGuardarCiudad.Enabled = true;
            btnEditarCiudad.Enabled = false;
            btnEliminarCiudad.Enabled = false;
        }

        private void dgvPaises_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodigo.Text = dgvPaises.CurrentRow.Cells[0].Value.ToString();
                txtPais.Text = dgvPaises.CurrentRow.Cells[1].Value.ToString();
                txtCodigo.Enabled = false;
                btnGuardarPais.Enabled = false;
                btnEditarPais.Enabled = true;
                btnEliminarPais.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvCiudades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdCiudad.Text = dgvCiudades.CurrentRow.Cells[0].Value.ToString();
                txtCodigoPais.Text = dgvCiudades.CurrentRow.Cells[1].Value.ToString();
                txtCiudad.Text = dgvCiudades.CurrentRow.Cells[2].Value.ToString();
                btnGuardarCiudad.Enabled = false;
                btnEditarCiudad.Enabled = true;
                btnEliminarCiudad.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCancelarPais_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtCodigo.Enabled = true;
            txtPais.Clear();
            btnGuardarPais.Enabled = true;
            btnEditarPais.Enabled = false;
            btnEliminarPais.Enabled = false;
        }

        private void btnCancelarCiudad_Click(object sender, EventArgs e)
        {
            txtIdCiudad.Clear();
            txtCodigoPais.Clear();
            txtCiudad.Clear();
            btnGuardarCiudad.Enabled = true;
            btnEditarCiudad.Enabled = false;
            btnEliminarCiudad.Enabled = false;
        }

        private void btnBuscarPais_Click(object sender, EventArgs e)
        {
            m.GetPais(txtBuscarPais.Text, dgvPaises);
        }

        private void btnRecargarPais_Click(object sender, EventArgs e)
        {
            m.GetPaises(dgvPaises);
            txtBuscarPais.Clear();
        }

        private void btnBuscarCiudad_Click(object sender, EventArgs e)
        {
            m.GetCiudad(txtBuscarCiudad.Text, dgvCiudades);
        }

        private void btnRecargarCiudad_Click(object sender, EventArgs e)
        {
            m.GetCiudades(dgvCiudades);
            txtBuscarCiudad.Clear();
        }
    }
}
