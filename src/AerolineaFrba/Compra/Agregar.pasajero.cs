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
    public partial class AgregarPasajero : Form, ClienteParaPasaje
    {
        private bool clienteNuevo;
        private int vuelo_id;
        private int usuario_id;
        private Pasajeros form_pasajeros;
        public AgregarPasajero() {}

        public AgregarPasajero(int id, Pasajeros pasajeros)
        {
            InitializeComponent();
            this.vuelo_id = id;
            this.form_pasajeros = pasajeros;
            this.clienteNuevo = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarPasajero_Load(object sender, EventArgs e)
        {
            SqlDataReader respuesta;
            Server server = Server.getInstance();
            string queryCombo = "SELECT id, numero, tipo FROM JUST_DO_IT.butacasLibres(" + this.vuelo_id + ") ORDER BY numero";
            respuesta = server.query(queryCombo);
            ComboBoxItem item;
            item = new ComboBoxItem(cmbButacas);
            while (respuesta.Read())
            {
                item = new ComboBoxItem();
                item.Value = respuesta["id"].ToString();
                item.Text = respuesta["numero"].ToString() + " - " + respuesta["tipo"].ToString();
                cmbButacas.Items.Add (item);
            }
            respuesta.Close();
        }

        public void cargarCliente(int id, string dni, string nombre, string apellido, string direccion, string telefono, string mail, string fecha)
        {
            this.clienteNuevo = false;
            this.usuario_id = id;

            this.txtDNI.Text = dni;
            this.txtDNI.Enabled = false;
            this.txtNombrePasajero.Text = nombre;
            this.txtNombrePasajero.Enabled = false;
            this.txtApellidoPasajero.Text = apellido;
            this.txtApellidoPasajero.Enabled = false;
            this.txtDireccionPasajero.Text = direccion;
            this.txtTelefonoPasajero.Text = telefono;
            this.txtMailPasajero.Text = mail;
            this.dtpFechaNacimientoPasajero.Text = fecha;
            this.dtpFechaNacimientoPasajero.Enabled = false;
        }

        private void btnSoyCliente_Click(object sender, EventArgs e)
        {
            new SoyCliente(this).Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (cmbButacas.Text == "")
            {
                MessageBox.Show("Debe seleccionar una butaca");
                return;
            }
            if (this.txtDNI.Text == "" || txtNombrePasajero.Text == "" || txtApellidoPasajero.Text == "" ||
                this.txtMailPasajero.Text == "" || this.txtDireccionPasajero.Text == "" || this.txtTelefonoPasajero.Text == "")
                MessageBox.Show("Debe completar todos los campos");
            else
            {
                try
                {
                    try
                    {
                        int.Parse(this.txtDNI.Text);
                        int.Parse(this.txtTelefonoPasajero.Text);
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("El DNI y el telefono deben ser numericos");
                        return;
                    }

                    if (!this.clienteNuevo)
                    {
                        string query = "EXEC JUST_DO_IT.actualizarCliente " + this.usuario_id + ", '" + this.txtMailPasajero.Text + "', '"
                                        + this.txtDireccionPasajero.Text + "', " + this.txtTelefonoPasajero.Text;
                        Server.getInstance().realizarQuery(query);
                    }
                    else
                    {
                        string query = "EXEC JUST_DO_IT.almacenarCliente " + this.txtDNI.Text + ", '" + this.txtNombrePasajero.Text + "', '" +
                                this.txtApellidoPasajero.Text + "', '" + this.txtMailPasajero.Text + "', '" + this.txtDireccionPasajero.Text + "', " +
                                this.txtTelefonoPasajero.Text + ", '" + dtpFechaNacimientoPasajero.Value.ToString("yyyy-MM-dd") + "'";
                        Server.getInstance().realizarQuery(query);
                        query = "SELECT JUST_DO_IT.obtenerIDUsuario (" + txtDNI.Text + ", '" +
                                txtApellidoPasajero.Text + "', '" + txtNombrePasajero.Text + "') AS id";
                        SqlDataReader reader = Server.getInstance().query(query);
                        reader.Read();
                        this.usuario_id = int.Parse(reader["id"].ToString());
                        reader.Close();
                    }
                    this.form_pasajeros.agregarPasajero(txtApellidoPasajero.Text + ", " + txtNombrePasajero.Text,
                                                    this.usuario_id,
                                                    ((ComboBoxItem)cmbButacas.SelectedItem).Value.ToString());
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
    }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
