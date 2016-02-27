using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class Modificar_Ruta : Form
    {
        private double ruta;
        public Modificar_Ruta() { }

        public Modificar_Ruta(string id)
        {
            InitializeComponent();
            this.ruta = double.Parse(id);
        }

        private void Modificar_Ruta_Load(object sender, EventArgs e)
        {
            Commons.getInstance().cargarComboBox("Ciudades", "nombre", cmbCiudadOrigen);
            Commons.getInstance().cargarComboBox("Ciudades", "nombre", cmbCiudadDestino);
            Commons.getInstance().cargarComboBox("TiposServicios", "nombre", cmbTipoServicio);

            string query = "SELECT * FROM JUST_DO_IT.Rutas WHERE id=" + this.ruta;
            SqlDataReader reader = Server.getInstance().query(query);
            reader.Read();
            txtCodigoRuta.Text = reader["codigo"].ToString();
            txtPrecioBasePorKg.Text = reader["precio_baseKG"].ToString();
            txtPrecioBasePorPasaje.Text = reader["precio_basePasaje"].ToString();
            string origen = reader["ciu_id_origen"].ToString();
            string destino = reader["ciu_id_destino"].ToString();
            string tipo_servicio = reader["tipo_servicio"].ToString();
            reader.Close();
            this.seleccionarElemento(cmbCiudadOrigen, "NombreCiudad", origen);
            this.seleccionarElemento(cmbCiudadDestino, "NombreCiudad", destino);
            this.seleccionarElemento(cmbTipoServicio, "NombreTipoDeServicio", tipo_servicio);
        }

        private void seleccionarElemento(ComboBox comboBox, string funcion, string id)
        {
            string elemento = Commons.getInstance().getNombreFrom(funcion, int.Parse(id));
            int i;
            for (i = 0; i < comboBox.Items.Count; i++)
            {
                comboBox.SelectedIndex = i;
                if (comboBox.Text == elemento)
                    break;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCodigoRuta.Text.Trim() == "" || txtPrecioBasePorKg.Text.Trim() == "" || txtPrecioBasePorPasaje.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            try
            {
                float kg;
                float pasaje;
                float codigo;

                try
                {
                    kg = float.Parse(txtPrecioBasePorKg.Text);
                    pasaje = float.Parse(txtPrecioBasePorPasaje.Text);
                    codigo = float.Parse(txtCodigoRuta.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar datos validos");
                    return;
                }
                int origen = Commons.getInstance().getIDFrom("IDCiudad", cmbCiudadOrigen.Text);
                int destino = Commons.getInstance().getIDFrom("IDCiudad", cmbCiudadDestino.Text);
                int tipo_servicio = Commons.getInstance().getIDFrom("IDTipoDeServicio", cmbTipoServicio.Text);
                string query = "EXEC JUST_DO_IT.ActualizarRuta " + this.ruta + ", " + codigo + ", " + kg + ", " +
                            pasaje + ", " + origen + ", " + destino + ", " + tipo_servicio;
                Server.getInstance().realizarQuery(query);
                MessageBox.Show("La ruta se actualizo satisfactoriamente");
                new Listado_Rutas().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new Listado_Rutas().Show();
            this.Hide();
        }
    }
}
