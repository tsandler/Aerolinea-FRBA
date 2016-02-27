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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class Listado_Rutas : Form
    {
        private ObservableCollection<Ruta> rutas;
        public Generacion_Viaje.Alta_Viaje owner { get; set; }
        private bool esAlta;

        private void instanciar()
        {
            rutas = new ObservableCollection<Ruta>();
            this.cargarRutas();
            listadoDeRutas.DataSource = rutas;
            listadoDeRutas.Columns["id"].Visible = false;
        }

        public Listado_Rutas(Generacion_Viaje.Alta_Viaje owner)
        {
            InitializeComponent();
            this.owner = owner;
            this.instanciar();
            this.esAlta = true;
            seleccionarRuta.Text = "Seleccionar ruta";
        }

        public Listado_Rutas()
        {
            InitializeComponent();
            this.instanciar();
            this.esAlta = false;
            seleccionarRuta.Text = "Modificar ruta";
        }

        private void Listado_Rutas_Load(object sender, EventArgs e)
        {

        }

        private void cargarRutas()
        {
            string query = 
                "SELECT rutas.id AS id, rutas.codigo AS codigo, rutas.precio_baseKG, rutas.precio_basePasaje, ciudades1.nombre AS origen, ciudades2.nombre AS destino, servicios.nombre as tipo_servicio " + 
                "FROM JUST_DO_IT.Rutas AS rutas, JUST_DO_IT.Ciudades AS ciudades1, JUST_DO_IT.Ciudades AS ciudades2, JUST_DO_IT.TiposServicios AS servicios " + 
                "WHERE rutas.ciu_id_origen = ciudades1.id AND rutas.ciu_id_destino = ciudades2.id AND rutas.tipo_servicio = servicios.id";
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                var ruta = new Ruta();
                ruta.id = Convert.ToInt32(reader["id"]);
                ruta.codigo = Convert.ToInt32(reader["codigo"]);
                ruta.precio_base_kg = float.Parse(reader["precio_baseKG"].ToString());
                ruta.precio_base_pasaje = float.Parse(reader["precio_basePasaje"].ToString());
                ruta.ciudad_origen = reader["origen"].ToString();
                ruta.ciudad_destino = reader["destino"].ToString();
                ruta.servicio = reader["tipo_servicio"].ToString();

                rutas.Add(ruta);
            }
            reader.Close();
        }

        private void seleccionarRuta_Click(object sender, EventArgs e)
        {
            if (this.esAlta)
                this.procesarAlta();
            else
                this.modificar();
        }

        private void modificar()
        {
            Ruta ruta = (Ruta)listadoDeRutas.CurrentRow.DataBoundItem;
            new Modificar_Ruta(ruta.id.ToString()).Show();
            this.Hide();
        }

        private void procesarAlta()
        {
            Ruta ruta = (Ruta)listadoDeRutas.CurrentRow.DataBoundItem;
            owner.cargarLabelsRuta(ruta);
            this.Close();
        }
        private void listadoDeRutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new Vistas_Inicio.Inicio_Admin().Show();
            this.Hide();
        }
    }
}
