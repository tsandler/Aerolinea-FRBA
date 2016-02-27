using AerolineaFrba.Abm_Aeronave;
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

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class Registro : Form
    {
        public Aeronave aeronave_seleccionada { get; set; }

        public Registro()
        {
            InitializeComponent();
            Commons.getInstance().cargarComboBox("Aeronaves", "matricula", matriculasComboBox);
            Commons.getInstance().cargarComboBox("Ciudades", "nombre", origenComboBox);
            Commons.getInstance().cargarComboBox("Ciudades", "nombre", destinoComboBox);
        }

        private void btnBuscarAeronave_Click(object sender, EventArgs e)
        {
            var matricula = this.matriculasComboBox.SelectedItem;

            string query = "SELECT aeronaves.id, matricula, modelo, kgs_disponibles, butacas_totales, fabricante , servicios.nombre AS tipo_servicio " +
                            "FROM JUST_DO_IT.Aeronaves AS aeronaves, JUST_DO_IT.TiposServicios AS servicios WHERE matricula = '" + matricula + "'" +
                            "AND aeronaves.tipo_servicio = servicios.id ";

            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                var aeronave = new Aeronave();
                aeronave.id = Convert.ToInt32(reader["id"]);
                aeronave.matricula = reader["matricula"].ToString();
                aeronave.modelo = reader["modelo"].ToString();
                aeronave.kgs_disponibles = Convert.ToInt32(reader["kgs_disponibles"]);
                aeronave.butacas_totales = Convert.ToInt32(reader["butacas_totales"]);
                aeronave.fabricante = reader["fabricante"].ToString();
                aeronave.servicio = reader["tipo_servicio"].ToString();

                aeronave_seleccionada = aeronave;

            }
            reader.Close();
            this.llenarLabels();
        }
        
        public void llenarLabels()
        {
            lblCantButacasAeronave.Text = aeronave_seleccionada.butacas_totales.ToString();
            lblFabricanteAeronave.Text = aeronave_seleccionada.fabricante;
            lblKgEncomiendasAeronave.Text = aeronave_seleccionada.kgs_disponibles.ToString();
            lblMatriculaAeronave.Text = aeronave_seleccionada.matricula;
            lblModeloAeronave.Text = aeronave_seleccionada.modelo;
            lblTipoServicioAeronave.Text = aeronave_seleccionada.servicio;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.camposValidos())
            {
                string query = "SELECT JUST_DO_IT.buscar_vuelo(" + aeronave_seleccionada.id + ", '" + this.origenComboBox.SelectedItem.ToString() + "', '" +
                            this.destinoComboBox.SelectedItem.ToString() + "', '" + dtpFechaYHoraSalida.Value.ToString("yyy-MM-dd") + "') as vuelo_id";
                SqlDataReader reader = Server.getInstance().query(query);
                reader.Read();
                var vuelo_id = reader["vuelo_id"].ToString();
                reader.Close();
                if (vuelo_id == "")
                    MessageBox.Show("La aeronave seleccionada no posee un vuelo con los campos ingresados o el vuelo ya registro la llegada.");
                else
                {
                    try
                    {
                        Server.getInstance().realizarQuery("EXEC JUST_DO_IT.registrar_llegada " + vuelo_id + ", '" + dtpFechaYHoraLlegada.Value.ToString("yyy-MM-dd HH:mm:ss") + "'");
                        MessageBox.Show("Se ha registrado satisfactoriamente la llegada de la aeronave");
                        this.Close();
                        new Vistas_Inicio.Inicio_Admin().Show();
                    }
                    catch
                    {
                        MessageBox.Show("No se ha podido registrar la llegada de la aeronave.");
                    }
                }
            }
            else
                MessageBox.Show("Debe completar todos los datos. La fecha de llegada debe ser posterior a la fecha de salida");
         
        }

        public bool camposValidos()
        {
            return this.aeronave_seleccionada != null && this.origenComboBox.SelectedItem != null && this.destinoComboBox.SelectedItem != null && dtpFechaYHoraSalida.Value < dtpFechaYHoraLlegada.Value;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Vistas_Inicio.Inicio_Admin().Show();
        }
    }
}
