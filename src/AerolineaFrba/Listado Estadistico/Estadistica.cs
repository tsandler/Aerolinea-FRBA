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

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class Estadistica : Form
    {
        public Estadistica()
        {
            InitializeComponent();
            this.cargarDestinosConPasajesMasComprados();
            this.cargarTopAeronavesFueraDeServicio();
            this.cargarDestinosConAeronavesMasVacias();
            this.clientesConMasPuntos();
            this.destinosConPasajesCancelados();
        }

        private void Estadistica_Load(object sender, EventArgs e)
        {

        }

        private void cargarDestinosConAeronavesMasVacias()
        {
            string query = "SELECT * FROM JUST_DO_IT.DestinosConAeronavesMasVacias()";
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvDestinosConAeronavesMasVacias.Rows.Add(reader["destino"].ToString(), reader["cantidad"].ToString());
            }
            reader.Close();
        }
        private void cargarDestinosConPasajesMasComprados()
        {
            string query = "SELECT * FROM JUST_DO_IT.DestinosConPasajesMasComprados()";
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvDestinosMasPasajesComprados.Rows.Add(reader["ciudad"].ToString(), reader["cantidad"].ToString());
            }
            reader.Close();
        }

        public void cargarTopAeronavesFueraDeServicio()
        {
            string query = "SELECT * FROM JUST_DO_IT.top_aeroanves_fuera_de_servicio()";
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvAeronavesConMayorCantDiasFueraDeServicio.Rows.Add(reader["matricula"].ToString(), reader["cantidad_dias"].ToString());
            }
            reader.Close();
        }

        public void clientesConMasPuntos()
        {
            string query = "SELECT * FROM JUST_DO_IT.usuarios_con_mas_puntaje()";
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvClientesConMasPuntos.Rows.Add(reader["nombre"].ToString(), reader["apellido"].ToString(), reader["millas_totales"].ToString());
            }
            reader.Close();
        }

        public void destinosConPasajesCancelados() {
            string query = "SELECT * FROM JUST_DO_IT.destinos_con_pasajes_cancelados()";
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvDestinosConPasajesCancelados.Rows.Add(reader["nombre_ciudad"].ToString(), reader["pasajes_cancelados"].ToString());
            }
            reader.Close();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void dgvAeronavesConMayorCantDiasFueraDeServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Vistas_Inicio.Inicio_Admin().Show();
        }
    }
}
