using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class AltaCiudad : Form
    {
        public AltaCiudad()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Vistas_Inicio.Inicio_Admin().Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cargarCiudades();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCiudadNueva.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una ciudad");
                return;
            }
            string query = "EXEC JUST_DO_IT.almacenarCiudad ' " + txtCiudadNueva.Text + "'";
            try
            {
                Server.getInstance().realizarQuery(query);
                MessageBox.Show("La ciudad fue agregada");
                txtCiudadNueva.Clear();
                this.cargarCiudades();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCiudadModificada.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }
            int id = Commons.getInstance().getIDFrom("IDCiudad", cmbCiudades.Text);
            string query = "EXEC JUST_DO_IT.ModificarCiudad " + id + ", ' " + txtCiudadModificada.Text + "'";
            try
            {
                Server.getInstance().realizarQuery(query);
                MessageBox.Show("La ciudad fue modificada");
                this.cargarCiudades();
                txtCiudadModificada.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarCiudades()
        {
            cmbCiudades.Items.Clear();
            Commons.getInstance().cargarComboBoxOrderBy("Ciudades", "nombre", cmbCiudades);
            cmbCiudades.SelectedIndex = 0;
        }

    }
}
