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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class Baja_Ruta : Form
    {
        public Baja_Ruta()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbRutas.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar una ruta");
                return;
            }
            try
            {
                string ruta = ((ComboBoxItem)cmbRutas.SelectedItem).Value.ToString();
                string query = "EXEC JUST_DO_IT.BajarRuta " + ruta;
                Server.getInstance().realizarQuery(query);
                MessageBox.Show("La ruta se dio de baja satisfactoriamente");
                new Vistas_Inicio.Inicio_Admin().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Baja_Ruta_Load(object sender, EventArgs e)
        {
            Commons.getInstance().cargarComboBox("Ciudades", "nombre", cmbDestino);
            Commons.getInstance().cargarComboBox("Ciudades", "nombre", cmbOrigen);
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargarDatos();
        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargarDatos();
        }

        private void cargarDatos()
        {
            if (!(cmbDestino.Text == "" || cmbOrigen.Text == ""))
            {
                cmbRutas.Items.Clear();
                int origen = Ciudades.obtenerID(cmbOrigen.Text);
                int destino = Ciudades.obtenerID(cmbDestino.Text);
                List<string> codigos = new List<string>();
                List<int> servicios = new List<int>();
                List<double> ids = new List<double>();
                string query = "SELECT id, codigo, tipo_servicio, eliminada FROM JUST_DO_IT.Rutas WHERE ciu_id_origen=" + origen + " AND ciu_id_destino=" + destino;
                SqlDataReader reader = Server.getInstance().query(query);
                while (reader.Read())
                {
                    string al = reader["eliminada"].ToString();

                    if (reader["eliminada"].ToString() == "False")
                    {
                        codigos.Add(reader["codigo"].ToString());
                        servicios.Add(int.Parse(reader["tipo_servicio"].ToString()));
                        ids.Add(double.Parse(reader["id"].ToString()));
                    }
                }
                reader.Close();
                int i;
                ComboBoxItem item = new ComboBoxItem(cmbRutas);
                for (i = 0; i < codigos.Count; i ++)
                {
                    string servicio = TiposServicios.obtenerNombre(servicios.ElementAt(i));
                    item = new ComboBoxItem();
                    item.Value = ids.ElementAt(i);
                    item.Text = codigos.ElementAt(i) + " - " + servicio;
                    cmbRutas.Items.Add(item);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new Vistas_Inicio.Inicio_Admin().Show();
            this.Hide();
        }
    }
}
