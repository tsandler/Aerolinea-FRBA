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
    public partial class SoyCliente : Form
    {
        private ClienteParaPasaje formOrigen;

        public SoyCliente()
        {
        }

        public SoyCliente(ClienteParaPasaje origen)
        {
            InitializeComponent();
            this.formOrigen = origen;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "" || txtApellido.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                try
                {
                    string query = "SELECT * FROM JUST_DO_IT.Usuarios WHERE dni=" +
                        int.Parse(txtDNI.Text) + " AND nombre='" + txtNombre.Text +
                        "' AND apellido='" + txtApellido.Text + "'";
                    SqlDataReader reader = Server.getInstance().query(query);
                    reader.Read();
                    if (reader.HasRows)
                    {
                        this.formOrigen.cargarCliente(int.Parse(reader["id"].ToString()),
                                                        reader["dni"].ToString(),
                                                        reader["nombre"].ToString(),
                                                        reader["apellido"].ToString(),
                                                        reader["direccion"].ToString(),
                                                        reader["telefono"].ToString(),
                                                        reader["mail"].ToString(),
                                                        reader["fecha_nacimiento"].ToString());
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario ingresado no existe");
                    }
                    reader.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar datos validos");
                }
            }
        }
    }
}
