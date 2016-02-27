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

namespace AerolineaFrba.Compra
{
    public partial class Pasajeros : Form
    {
        private int vuelo_id;
        private float costo_viaje;
        private float costo_encomienda;
        private int cantidad_disponible;

        public Pasajeros() { }
        public Pasajeros(int id, float costo, float costoEncomienda, int cantidadDisponible)
        {
            InitializeComponent();
            this.vuelo_id = id;
            this.costo_viaje = costo;
            this.costo_encomienda = costoEncomienda;
            this.cantidad_disponible = cantidadDisponible;
        }

        public void agregarPasajero(string usuario, int usuario_id, string butaca)
        {
            lstPasajeros.Items.Add(usuario);
            string query = "EXEC JUST_DO_IT.reservarButaca " + usuario_id + ", " + this.vuelo_id + ", " + butaca;
            Server.getInstance().realizarQuery(query);
            this.cantidad_disponible--;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.cantidad_disponible > 0)
                new AgregarPasajero(this.vuelo_id, this).Show();
            else
                MessageBox.Show("No quedan butacas disponibles");
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (lstPasajeros.Items.Count == 0)
                MessageBox.Show("Debe agregar algun pasajero");
            else
            {
                new Pagar(this.vuelo_id, this.costo_viaje, this.costo_encomienda).Show();
                this.Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM JUST_DO_IT.ButacasReservadas WHERE vuelo_id=" + this.vuelo_id;
            Server.getInstance().realizarQuery(query);
            new compraPasaje().Show();
            this.Hide();
        }

        private void Pasajeros_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM JUST_DO_IT.butacasReservadasParaVuelo(" + this.vuelo_id + ")";
            SqlDataReader reader = Server.getInstance().query(query);
            while(reader.Read())
                lstPasajeros.Items.Add(reader["apellido"].ToString() + ", " + reader["nombre"].ToString());
            reader.Close();
        }
    }
}
