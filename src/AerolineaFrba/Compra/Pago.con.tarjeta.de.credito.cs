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
    public partial class pagoTarjeta : Form
    {
        private Pagar form_pago;

        public pagoTarjeta() { InitializeComponent(); }

        public pagoTarjeta(Pagar pagar)
        {
            InitializeComponent();
            this.form_pago = pagar;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text.Length == 16 && txtCodigo.Text.Length > 0 && txtVencimiento.Text.Length == 4)
            {
                try
                {
                    float.Parse(txtNumero.Text);
                    int.Parse(txtCodigo.Text);
                    int.Parse(txtVencimiento.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar datos validos");
                    return;
                }
                this.form_pago.cargarDatosTarjeta(txtNumero.Text,
                                                  txtCodigo.Text,
                                                  txtVencimiento.Text,
                                                  cmbCuotas.Text,
                                                  cmbTipo.Text);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe ingresar un numero de tarjeta de 16 digitos, un codigo de seguridad y una fecha de vencimiento de 4 digitos");
            }
        }

        private void pagoTarjeta_Load(object sender, EventArgs e)
        {
            string query = "SELECT nombre FROM JUST_DO_IT.MediosDePago WHERE nombre <> 'Efectivo'";
            SqlDataReader reader =  Server.getInstance().query(query);
            while (reader.Read())
            {
                cmbTipo.Items.Add(reader["nombre"].ToString());
            }
            reader.Close();
            cmbTipo.SelectedIndex = 0;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT cuotas FROM JUST_DO_IT.MediosDePago WHERE nombre='" + cmbTipo.Text + "'";
            SqlDataReader reader = Server.getInstance().query(query);
            cmbCuotas.Items.Clear();
            int i;
            reader.Read();
            for (i = 1; i <= int.Parse(reader["cuotas"].ToString()); i++)
                cmbCuotas.Items.Add(i.ToString());

            cmbCuotas.SelectedIndex = 0;
            reader.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
