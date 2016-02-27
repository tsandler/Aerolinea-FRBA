using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class Listado_Aeronaves : Form
    {
        private ObservableCollection<Aeronave> aeronaves;
        public Generacion_Viaje.Alta_Viaje owner { get; set; }
        public DateTime fecha_salida { get; set; }
        public DateTime fecha_estimada_llegada { get; set; }
        public bool vistaModificar { get; set; }

        public Listado_Aeronaves(Generacion_Viaje.Alta_Viaje owner, DateTime fecha_salida, DateTime fecha_estimada_llegada)
        {
            InitializeComponent();
            this.owner = owner;
            this.fecha_salida = fecha_salida;
            this.fecha_estimada_llegada = fecha_estimada_llegada;
            aeronaves = new ObservableCollection<Aeronave>();
            this.cargarAeronaves();
            this.listadoAeronaves.DataSource = aeronaves;
            listadoAeronaves.Columns["id"].Visible = false;
        }

        public Listado_Aeronaves(bool vistaModificar)
        {
            InitializeComponent();
            this.vistaModificar = vistaModificar;
            aeronaves = new ObservableCollection<Aeronave>();
            this.cargarAeronavesAModificar();
            this.listadoAeronaves.DataSource = aeronaves;
            listadoAeronaves.Columns["id"].Visible = false;

        }
        private void Listado_Aeronaves_Load(object sender, EventArgs e)
        {

        }

        private void cargarAeronaves()
        {
            string query = 
                "SELECT aeronaves.id, matricula, modelo, kgs_disponibles, butacas_totales, fabricante , servicios.nombre AS tipo_servicio " +
                "FROM JUST_DO_IT.aeronavesDisponiblesParaVuelos('" + fecha_salida.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + fecha_estimada_llegada.ToString("yyyy-MM-dd hh:mm:ss") + "') AS aeronaves, JUST_DO_IT.TiposServicios AS servicios " +
                "WHERE aeronaves.tipo_servicio = servicios.id " +
                "AND aeronaves.baja_fuera_servicio = 0 AND aeronaves.baja_vida_util = 0 " +
                "ORDER BY matricula";
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                var aeronave = new Aeronave();
                aeronave.id = Convert.ToInt32(reader["id"]);
                aeronave.matricula = reader["matricula"].ToString();
                aeronave.modelo = reader["modelo"].ToString();
                aeronave.kgs_disponibles = float.Parse(reader["kgs_disponibles"].ToString());
                aeronave.butacas_totales = Convert.ToInt32(reader["butacas_totales"]);
                aeronave.fabricante = reader["fabricante"].ToString();
                aeronave.servicio = reader["tipo_servicio"].ToString();

                aeronaves.Add(aeronave);
                
            }
            reader.Close();
        }

        private void seleccionarAeronave_Click(object sender, EventArgs e)
        {
            Aeronave aeronave = (Aeronave)listadoAeronaves.CurrentRow.DataBoundItem;
            if (vistaModificar ==  true)
            {
                new Abm_Aeronave.Modificar(aeronave.matricula, aeronave.id).Show();
                this.Hide();
            }
            else
            {
                owner.cargarLabelsAeronave(aeronave);
                this.Close();
            }
            
        }

        public void cargarAeronavesAModificar()
        {
            string query = "SELECT aeronaves.id, matricula, modelo, kgs_disponibles, butacas_totales, fabricante , servicios.nombre AS tipo_servicio FROM JUST_DO_IT.Aeronaves aeronaves JOIN JUST_DO_IT.TiposServicios servicios ON aeronaves.tipo_servicio = servicios.id WHERE baja_vida_util = 0";
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

                aeronaves.Add(aeronave);
            }
            reader.Close();
        }

        private void listadoAeronaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
            new Vistas_Inicio.Inicio_Admin().Show();
        }
    }
}
