using app_datos_cliente.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_datos_cliente.datos
{
    class metodos
    {
        static HttpClient client = new HttpClient();

        public metodos()
        {
            client.BaseAddress = new Uri("http://localhost:5000/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // Paises

        public async void GetPaises(DataGridView dataGridView)
        {
            var response = await client.GetStringAsync("paises");
            var data = JsonConvert.DeserializeObject<List<Paises>>(response);
            dataGridView.DataSource = data;
        }

        public async void GetPais(string pais, DataGridView dataGridView)
        {
            var response = await client.GetStringAsync($"paises/{pais}");
            var data = JsonConvert.DeserializeObject<List<Paises>>(response);
            dataGridView.DataSource = data;
        }

        public async void NuevoPais(string codigo, string pais, DataGridView dataGridView)
        {
            var p = new Paises() { Codigo = codigo, Pais = pais };
            var response = await client.PostAsJsonAsync("pais/nuevo", p);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Agregado Correctamente");
                GetPaises(dataGridView);
            }
            else
            {
                MessageBox.Show("No se pudo agregar, intente de nuevo.");
            }
        }

        public async void ModificarPais(string codigo, string pais, DataGridView dataGridView)
        {
            var p = new Paises() { Pais = pais };
            var response = await client.PutAsJsonAsync($"pais/modificar/{codigo}", p);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Modificado Correctamente");
                GetPaises(dataGridView);
            }
            else
            {
                MessageBox.Show("No se pudo modificar, intente de nuevo.");
            }
        }

        public async void EliminarPais(string codigo, DataGridView dataGridView)
        {
            var response = await client.DeleteAsync($"pais/eliminar/{codigo}");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Eliminado Correctamente");
                GetPaises(dataGridView);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar, intente de nuevo");
            }
        }

        // Ciudades

        public async void GetCiudades(DataGridView dataGridView)
        {
            var response = await client.GetStringAsync("ciudades");
            var data = JsonConvert.DeserializeObject<List<Ciudades>>(response);
            dataGridView.DataSource = data;
        }

        public async void GetCiudad(string ciudad, DataGridView dataGridView)
        {
            var response = await client.GetStringAsync($"ciudades/{ciudad}");
            var data = JsonConvert.DeserializeObject<List<Ciudades>>(response);
            dataGridView.DataSource = data;
        }

        public async void NuevaCiudad(string codigoPais, string ciudad, DataGridView dataGridView)
        {
            var c = new Ciudades() { Codigo_Pais = codigoPais, Ciudad = ciudad };
            var response = await client.PostAsJsonAsync("ciudad/nueva", c);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Agregado Correctamente");
                GetCiudades(dataGridView);
            } 
            else
            {
                MessageBox.Show("No se pudo agregar, intente de nuevo.");
            }
        }

        public async void ModificarCiudad(int idCiudad, string codigoPais, string ciudad, DataGridView dataGridView)
        {
            var c = new Ciudades() { Codigo_Pais = codigoPais, Ciudad = ciudad };
            var response = await client.PutAsJsonAsync($"ciudad/modificar/{idCiudad}", c);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Modificado Correctamente");
                GetCiudades(dataGridView);
            } 
            else
            {
                MessageBox.Show("No se pudo modificar, intente de nuevo.");
            }
        }

        public async void EliminarCiudad(int idCiudad, DataGridView dataGridView)
        {
            var response = await client.DeleteAsync($"ciudad/eliminar/{idCiudad}");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Eliminado Correctamente");
                GetCiudades(dataGridView);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar, intente de nuevo");
            }
        }
    }
}
