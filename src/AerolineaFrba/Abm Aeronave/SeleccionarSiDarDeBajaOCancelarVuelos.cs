using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace AerolineaFrba.Abm_Aeronave
{

    public partial class SeleccionarSiDarDeBajaOCancelarVuelos : Form
    {
        public string matricula;
        DateTimePicker fechaFueraServicio;
        DateTimePicker fechaReinicioServicio;
        Boolean finVidaUtil;

        public SeleccionarSiDarDeBajaOCancelarVuelos()
        {
            
        }

        public SeleccionarSiDarDeBajaOCancelarVuelos(string unaMatricula)
        {
            InitializeComponent();
            matricula = unaMatricula;
            finVidaUtil = true;
        }

        public SeleccionarSiDarDeBajaOCancelarVuelos(string unaMatricula, DateTimePicker fechaFueraServicio, DateTimePicker fechaReinicioServicio)
        {
            InitializeComponent();
            matricula = unaMatricula;
            this.fechaFueraServicio = fechaFueraServicio;
            this.fechaReinicioServicio = fechaReinicioServicio;
            finVidaUtil = false;
        }

        private void SeleccionarSiDarDeBajaOCancelarVuelos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                if (finVidaUtil)
                {
                    query = "EXEC JUST_DO_IT.cancelar_vuelos_y_dar_de_baja_aeronave '" + matricula + "', 1, null, null";
                }
                else 
                {
                    query = "EXEC JUST_DO_IT.cancelar_vuelos_y_dar_de_baja_aeronave '" + matricula + "', 0, '" + fechaFueraServicio.Value.ToString("yyyy-MM-dd") + "', '" + fechaReinicioServicio.Value.ToString("yyyy-MM-dd") + "'";
                }
                
                Server.getInstance().realizarQuery(query);

                MessageBox.Show("Las aeronaves se han dado de baja y sus respectivos vuelos se han cancelado");
                new Vistas_Inicio.Inicio_Admin().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new Abm_Aeronave.Baja().Show();
        }

        private void btnReemplazarAeronave_Click(object sender, EventArgs e)
        {
            if (finVidaUtil)
            {
                new ReemplazoAeronave(matricula, this).Show();
            }
            else 
            {
                new ReemplazoAeronave(matricula, this.fechaFueraServicio, this.fechaReinicioServicio, this).Show();
            }
        }
    }
}
