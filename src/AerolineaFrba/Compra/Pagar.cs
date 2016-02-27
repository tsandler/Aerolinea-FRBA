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
    public partial class Pagar : Form, ClienteParaPasaje
    {
        private int vuelo_id;
        private float costo_viaje;
        private float costo_encomienda;
        private int usuario_id;
        private string numero;
        private string codigo;
        private string vencimiento;
        private string cuotas;
        private string tipo;
        private bool efectivo;
        private bool soyCliente;
        private bool cargoPago;
        private int esEncomienda;

        public Pagar()
        {
        }

        public void inicializar(int vuelo_id, float costo_encomienda)
        {
            InitializeComponent();
            this.vuelo_id = vuelo_id;
            this.costo_encomienda = costo_encomienda;
            this.soyCliente = false;
            this.cargoPago = false;
            this.efectivo = false;

            lblKGs.Text = lblKGs.Text + " ($" + this.costo_encomienda + " por KG)";
            this.numero = "NULL";
            this.codigo = "NULL";
            this.vencimiento = "NULL";
            this.cuotas = "1";
            this.tipo = "NULL";
            this.esEncomienda = 0;
        }

        public Pagar(int vuelo_id, float costo_encomienda)
        {
            this.inicializar(vuelo_id, costo_encomienda);
            lblCosto.Text = "$" + this.costo_encomienda + " por KG";
            this.esEncomienda = 1;
            this.costo_viaje = 0;
        }

        public Pagar(int vuelo_id, float costo_viaje, float costo_encomienda)
        {
            this.costo_viaje = costo_viaje;
            this.inicializar(vuelo_id, costo_encomienda);
            lblCosto.Text = this.costo_viaje.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSoyCliente_Click(object sender, EventArgs e)
        {
            new SoyCliente(this).Show();
        }

        public void cargarCliente(int id, string dni, string nombre, string apellido, string direccion, string telefono, string mail, string fecha)
        {
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

            this.soyCliente = true;
        }

        private void btnPagaConTarjeta_Click(object sender, EventArgs e)
        {
            new pagoTarjeta(this).Show();
        }

        internal void cargarDatosTarjeta(string numero, string codigo, string vencimiento, string cuotas, string tipo)
        {
            this.numero = numero;
            this.codigo = codigo;
            this.vencimiento = vencimiento;
            this.cuotas = cuotas;
            this.tipo = tipo;
            this.cargoPago = true;
            this.btnPagaEnEfectivo.Enabled = false;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (!this.cargoPago)
            {
                MessageBox.Show("Debe elegir un medio de pago");
                return;
            }
            if (this.esEncomienda == 1)
            {
                if (this.txtKGs.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar la cantidad a enviar");
                    return;
                }
            }
            try
            {
                string query;
                SqlDataReader reader;
                if (this.txtDNI.Text == "" || txtNombrePasajero.Text == "" || txtApellidoPasajero.Text == "" ||
                this.txtMailPasajero.Text == "" || this.txtDireccionPasajero.Text == "" || this.txtTelefonoPasajero.Text == "")
                    MessageBox.Show("Debe completar todos los campos");
                else
                {
                    float KGsAEnviar;
                    if (txtKGs.Text.Trim() == "")
                    {
                        KGsAEnviar = 0;
                    }
                    else
                    {
                        try
                        {
                            KGsAEnviar = float.Parse(txtKGs.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("La cantidad de KGs a enviar no es valida");
                            return;
                        }
                    }
                    try
                    {
                        int.Parse(this.txtDNI.Text);
                        int.Parse(this.txtTelefonoPasajero.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El DNI y el telefono deben ser numericos");
                        return;
                    }
                    if (this.soyCliente)
                    {
                        query = "EXEC JUST_DO_IT.actualizarUsuario " + this.usuario_id + ", '" + this.txtMailPasajero.Text + "', '"
                                        + this.txtDireccionPasajero.Text + "', " + this.txtTelefonoPasajero.Text;
                        Server.getInstance().realizarQuery(query);
                    }
                    else
                    {
                        query = "EXEC JUST_DO_IT.almacenarCliente " + this.txtDNI.Text + ", '" + this.txtNombrePasajero.Text + "', '" +
                                this.txtApellidoPasajero.Text + "', '" + this.txtMailPasajero.Text + "', '" + this.txtDireccionPasajero.Text + "', " +
                                this.txtTelefonoPasajero.Text + ", '" + dtpFechaNacimientoPasajero.Value.ToString("yyyy-MM-dd") + "'";
                        Server.getInstance().realizarQuery(query);
                        query = "SELECT JUST_DO_IT.obtenerIDUsuario (" + txtDNI.Text + ", '" +
                                txtApellidoPasajero.Text + "', '" + txtNombrePasajero.Text + "') AS id";
                        reader = Server.getInstance().query(query);
                        reader.Read();
                        this.usuario_id = int.Parse(reader["id"].ToString());
                        reader.Close();
                    }
                    int idMedioDePago;
                    if (this.efectivo)
                        idMedioDePago = MedioDePago.obtenerID("Efectivo");
                    else
                        idMedioDePago = MedioDePago.obtenerID(this.tipo);

                    query = "EXEC JUST_DO_IT.almacenarPasaje " + this.vuelo_id + ", " + this.costo_viaje + ", " +
                                this.usuario_id + ", " + this.numero + ", " + this.codigo + ", " + this.vencimiento + ", " +
                                this.cuotas + ", " + idMedioDePago + ", " + KGsAEnviar + ", " + this.esEncomienda;

                    Server.getInstance().realizarQuery(query);

                    query = "SELECT TOP 1 codigo, monto FROM JUST_DO_IT.Compras ORDER BY codigo DESC";
                    reader = Server.getInstance().query(query);
                    reader.Read();
                    string codigo = reader["codigo"].ToString();
                    string monto = reader["monto"].ToString();
                    reader.Close();

                    new InformeDeCompra(monto, codigo).Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void btnPagaEnEfectivo_Click(object sender, EventArgs e)
        {
            btnPagaConTarjeta.Enabled = false;
            this.efectivo = true;
            this.cargoPago = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM JUST_DO_IT.ButacasReservadas WHERE vuelo_id=" + this.vuelo_id;
            Server.getInstance().realizarQuery(query);
            new compraPasaje().Show();
            this.Hide();
        }
    }
}
