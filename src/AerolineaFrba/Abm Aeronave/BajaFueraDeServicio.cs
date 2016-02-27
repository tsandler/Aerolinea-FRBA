using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class BajaFueraDeServicio : Form
    {
        public BajaFueraDeServicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.cbMatricula.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar una matricula");
            }
            else
            {
                if (dtpFechaFueraServicio.Value > dtpFechaReinicioServicio.Value)
                {
                    MessageBox.Show("La fecha de reinicio debe ser posterior a la de baja");
                    return;
                }
                new SeleccionarSiDarDeBajaOCancelarVuelos(cbMatricula.Text, dtpFechaFueraServicio, dtpFechaReinicioServicio).Show();
                this.Close();
            }
        }

        public void darDeBajaAeronave(string matricula, DateTimePicker fechaFueraServicio, DateTimePicker fechaReinicioServicio)
        {
            try
            {
                string query = "EXEC JUST_DO_IT.dar_de_baja_aeronave_por_fuera_de_servicio '" + matricula + "', '" + fechaFueraServicio.Value.ToString("yyyy-MM-dd") + "', '" + fechaReinicioServicio.Value.ToString("yyyy-MM-dd") + "'";
                Server.getInstance().realizarQuery(query);
                MessageBox.Show("La aeronave se dió de baja satisfactoriamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Abm_Aeronave.Baja().Show();
        }

        private void Baja_Load(object sender, EventArgs e)
        {
            Commons.getInstance().cargarComboBoxOrderBy("AeronavesDisponiblesParaBaja()", "matricula", cbMatricula);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbNumeroMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaFueraServicio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
