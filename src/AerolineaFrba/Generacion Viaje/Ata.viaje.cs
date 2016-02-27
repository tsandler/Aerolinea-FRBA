using AerolineaFrba.Abm_Aeronave;
using AerolineaFrba.Abm_Ruta;
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

namespace AerolineaFrba.Generacion_Viaje
{
    public partial class Alta_Viaje : Form
    {
        public Ruta ruta_seleccionada{ get; set; }
        public Aeronave aeronave_seleccionada { get; set; }

        public Alta_Viaje()
        {
            InitializeComponent();
        }

        private void btnSeleccionarRuta_Click(object sender, EventArgs e)
        {
            if (this.fechasValidas())
            {
                var ListadoView = new Abm_Ruta.Listado_Rutas(this);
                ListadoView.Show();
            }
            else
            {
                MessageBox.Show("La Fecha de Salida debe ser previa a la Fecha de Llegada Estimada y deben tener de diferencia como máximo un día.");
            }
            
        }

        public void cargarLabelsRuta(Ruta ruta)
        {
            ruta_seleccionada = ruta;
            lblCiudadOrigen.Text = ruta_seleccionada.ciudad_origen;
            lblCiudadDestino.Text = ruta_seleccionada.ciudad_destino;
        }

        public void cargarLabelsAeronave(Aeronave aeronave)
        {
            aeronave_seleccionada = aeronave;
            lblTipoServicioAeronave.Text = aeronave_seleccionada.servicio;
            lblKgDisponiblesEncomiendasAeronave.Text = aeronave_seleccionada.kgs_disponibles.ToString();
            lblCantButacasAeronave.Text = aeronave_seleccionada.butacas_totales.ToString();
            lblModeloAeronave.Text = aeronave_seleccionada.modelo;
            lblMatriculaAeronave.Text = aeronave_seleccionada.matricula;
            lblFabricanteAeronave.Text = aeronave_seleccionada.fabricante;
        }

        private void btnSeleccionarAeronave_Click(object sender, EventArgs e)
        {
            if (this.fechasValidas())
            {
                var ListadoView = new Abm_Aeronave.Listado_Aeronaves(this, dtpFechaSalidaVuelo.Value, dtpFechaLlegadaEstimadaVuelo.Value);
                ListadoView.Show();
            }
            else
            {
                MessageBox.Show("La Fecha de Salida debe ser previa a la Fecha de Llegada Estimada y deben tener de diferencia como máximo un día.");
            }   
        }

        public bool fechasValidas()
        {
            return (dtpFechaSalidaVuelo.Value < dtpFechaLlegadaEstimadaVuelo.Value && (dtpFechaLlegadaEstimadaVuelo.Value - dtpFechaSalidaVuelo.Value).TotalDays <= 1);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ruta_seleccionada != null && aeronave_seleccionada != null)
            {
                if (this.verificarVueloUnico())
                {
                    string query = "EXEC JUST_DO_IT.almacenarVuelo '" + dtpFechaSalidaVuelo.Value.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + dtpFechaLlegadaEstimadaVuelo.Value.ToString("yyyy-MM-dd hh:mm:ss") + "', " + ruta_seleccionada.id + ", " + aeronave_seleccionada.id +
                                ", " + aeronave_seleccionada.butacas_totales + ", '" + ruta_seleccionada.servicio + "', '" + aeronave_seleccionada.servicio + "', " + aeronave_seleccionada.kgs_disponibles;
                    try
                    {
                        Server.getInstance().realizarQuery(query);
                        MessageBox.Show("El vuelo se agrego satisfactoriamente");
                        this.Close();
                        new Vistas_Inicio.Inicio_Admin().Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Debe crear un nuevo vuelo. El mismo ya existe.");
                }
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar una ruta y una aeronave");
            }
                
        }

        public bool verificarVueloUnico()
        {
            string query = "SELECT * FROM JUST_DO_IT.Vuelos WHERE aeronave_id = " + aeronave_seleccionada.id + " AND ruta_id = " + ruta_seleccionada.id + " AND cantidadDisponible = " + aeronave_seleccionada.butacas_totales +
                " AND KGsDisponibles = " + aeronave_seleccionada.kgs_disponibles + " AND fecha_salida = '" + dtpFechaSalidaVuelo.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' AND " +
                "fecha_llegada_estimada = '" + dtpFechaLlegadaEstimadaVuelo.Value.ToString("yyyy-MM-dd hh:mm:ss") + "'";
            SqlDataReader reader = Server.getInstance().query(query);
            reader.Read();
            if (reader.HasRows)
            {
                reader.Close();
                return false;
            }
            else
            {
                reader.Close();
                return true;
            }
         
        }

        private void dtpFechaSalidaVuelo_ValueChanged(object sender, EventArgs e)
        {
            this.emptyForm();
        }

        public void emptyForm()
        {
            lblCantButacasAeronave.Text = "";
            lblCiudadDestino.Text = "";
            lblCiudadOrigen.Text = "";
            lblFabricanteAeronave.Text = "";
            lblKgDisponiblesEncomiendasAeronave.Text = "";
            lblMatriculaAeronave.Text = "";
            lblModeloAeronave.Text = "";
            lblTipoServicioAeronave.Text = "";
            ruta_seleccionada = null;
            aeronave_seleccionada = null;
        }

        private void dtpFechaLlegadaEstimadaVuelo_ValueChanged(object sender, EventArgs e)
        {
            this.emptyForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Vistas_Inicio.Inicio_Admin().Show();
        }
    }
}
