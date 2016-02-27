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

namespace AerolineaFrba.Devolucion
{
    public partial class Devoluciones : Form
    {
        public Devoluciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void cargarCancelaciones()
        {
            dgvCancelaciones.Rows.Clear();
            dgvCancelaciones.Refresh();
            string query = "SELECT * FROM JUST_DO_IT.CancelacionesPendientes";
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                string tipo;
                if (reader["tipo"].ToString() == "False")
                    tipo = "Pasaje";
                else
                    tipo = "Paquete";
                dgvCancelaciones.Rows.Add(tipo, reader["codigo"].ToString(), reader["compra"].ToString());
            }
            reader.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new Baja(this).Show();
        }

        private void Devoluciones_Load(object sender, EventArgs e)
        {
            this.cargarCancelaciones();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvCancelaciones.Rows.Count == 0)
            {
                MessageBox.Show("No hay cancelaciones pendientes");
                return;
            }
            string query = "EXEC JUST_DO_IT.procesarCancelaciones";
            try
            {
                Server.getInstance().realizarQuery(query);
                MessageBox.Show("Las cancelaciones han sido procesadas");
                dgvCancelaciones.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new Vistas_Inicio.Inicio_Admin().Show();
            this.Hide();
        }
    }
}
