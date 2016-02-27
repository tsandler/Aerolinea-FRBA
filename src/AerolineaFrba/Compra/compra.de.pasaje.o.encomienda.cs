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
    public partial class compraPasaje : Form
    {
        public compraPasaje()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Commons.getInstance().cargarComboBox("ciudades", "nombre", cmbOrigen);
            Commons.getInstance().cargarComboBox("ciudades", "nombre", cmbDestino);
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.actualizarTabla();
        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.actualizarTabla();
        }

        private void dtpFechaSalidaVuelo_ValueChanged(object sender, EventArgs e)
        {
            this.actualizarTabla();
        }

        private void dtpFechaLlegadaVuelo_ValueChanged(object sender, EventArgs e)
        {
            this.actualizarTabla();
        }

        private void actualizarTabla()
        {
            dgvViajesDisponibles.Rows.Clear();
            dgvViajesDisponibles.Refresh();
            if (cmbOrigen.Text == "" || cmbDestino.Text == "")
            {
            }
            else
            {
                int origen = Ciudades.obtenerID(cmbOrigen.Text);
                int destino = Ciudades.obtenerID(cmbDestino.Text);
                string query = "SELECT * FROM JUST_DO_IT.vuelosDisponibles(" + origen + ", " + destino + ", '" +
                    dtpFechaSalidaVuelo.Value.ToString("yyyy-MM-dd") + "')";
                SqlDataReader reader = Server.getInstance().query(query);
                while (reader.Read())
                {
                    dgvViajesDisponibles.Rows.Add(reader["vuelo"].ToString(), reader["cantidad"].ToString(),
                            reader["kgsDisponibles"].ToString(), reader["salida"].ToString(), reader["llegada"].ToString(),
                            reader["tipoServicio"].ToString(), 
                            reader["costoViaje"].ToString(), reader["costoEncomienda"].ToString());
                }
                reader.Close();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = Commons.getInstance().getSelectedRow(dgvViajesDisponibles);
            if (row == null)
            {
                MessageBox.Show("Debe seleccionar algun vuelo");
                return;
            }
            if (int.Parse(row.Cells[1].Value.ToString()) == 0)
            {
                MessageBox.Show("No quedan butacas disponibles");
            }
            else
            {
                int vuelo_id = int.Parse(row.Cells[0].Value.ToString());
                float costoViaje = float.Parse(row.Cells[6].Value.ToString());
                float costoEncomienda = float.Parse(row.Cells[7].Value.ToString());
                int cantidadDisponible = int.Parse(row.Cells[1].Value.ToString());
                new Pasajeros(vuelo_id, costoViaje, costoEncomienda, cantidadDisponible).Show();
                this.Hide();
            }
        }

        private void dgvViajesDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEncomienda_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = Commons.getInstance().getSelectedRow(dgvViajesDisponibles);
            if (row == null)
            {
                MessageBox.Show("Debe seleccionar algun vuelo");
                return;
            }
            if (float.Parse(row.Cells[2].Value.ToString()) == 0)
            {
                MessageBox.Show("No quedan KGs disponibles para encomiendas");
            }
            else
            {
                int vuelo_id = int.Parse(row.Cells[0].Value.ToString());
                float costoEncomienda = float.Parse(row.Cells[7].Value.ToString());
                new Pagar(vuelo_id, costoEncomienda).Show();
                this.Hide();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new Vistas_Inicio.Inicio_Admin().Show();
            this.Hide();
        }

    }
}
