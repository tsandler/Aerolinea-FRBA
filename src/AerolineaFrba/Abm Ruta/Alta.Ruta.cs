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
    public partial class Alta_Ruta : Form
    {
        public Alta_Ruta()
        {
            InitializeComponent();
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            Commons.getInstance().cargarComboBox("TiposServicios", "nombre", cmbTipoServicio);
            Commons.getInstance().cargarComboBox("Ciudades", "nombre", cmbOrigen);
            Commons.getInstance().cargarComboBox("Ciudades", "nombre", cmbDestino);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() != "" && txtPrecioBasePorKg.Text.Trim() != "" && txtPrecioBasePorPasaje.Text.Trim() != ""
                && cmbDestino.Text.Trim() != "" && cmbOrigen.Text.Trim() != "" && cmbTipoServicio.Text.Trim() != "")
            {
                string query;
                try
                {
                    int codigo = int.Parse(txtCodigo.Text);
                    float kgs = float.Parse(txtPrecioBasePorKg.Text);
                    float pasaje = float.Parse(txtPrecioBasePorPasaje.Text);
                    int destino = Ciudades.obtenerID(cmbDestino.Text);
                    int origen = Ciudades.obtenerID(cmbOrigen.Text);
                    int servicio = TiposServicios.obtenerID(cmbTipoServicio.Text);
                    query = "EXEC JUST_DO_IT.almacenarRuta " + codigo + ", " + kgs + ", " + pasaje + ", " + origen + ", " +
                    destino + ", " + servicio;
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar datos validos");
                    return;
                }

                try
                {
                    Server.getInstance().realizarQuery(query);
                    MessageBox.Show("La ruta se agrego satisfactoriamente");
                    new Vistas_Inicio.Inicio_Admin().Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            new Vistas_Inicio.Inicio_Admin().Show();
            this.Hide();
        }
    }
}
