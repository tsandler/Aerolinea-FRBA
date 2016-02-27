using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Devolucion
{
    public partial class Baja : Form
    {
        private Devoluciones owner;
        public Baja() { }
        public Baja(Devoluciones owner)
        {
            InitializeComponent();
            this.owner = owner;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "" || txtCompra.Text.Trim() == "" || txtMotivo.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }
            try
            {
                float.Parse(txtCodigo.Text);
                float.Parse(txtCompra.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Debe ingresar una compra y un codigo validos");
                return;
            }
            string query = "EXEC JUST_DO_IT.agregarCompraADevolver " + txtCompra.Text + ", " + cmbTipo.SelectedIndex + ", " +
                txtCodigo.Text + ", " + txtMotivo.Text;
            try
            {
                Server.getInstance().realizarQuery(query);
                MessageBox.Show("La cancelacion se encolo correctamente");
                this.owner.cargarCancelaciones();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Baja_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Pasaje");
            cmbTipo.Items.Add("Paquete");
            cmbTipo.SelectedIndex = 0;
        }
    }
}
