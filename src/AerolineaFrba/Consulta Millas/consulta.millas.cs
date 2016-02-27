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

namespace AerolineaFrba.Consulta_Millas
{
    public partial class ConsultaMillas : Form
    {
        private Form owner;
        public ConsultaMillas(Form owner)
        {
            InitializeComponent();
            this.owner = owner;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            owner.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string DNI = txtDNI.Text;
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            if (DNI.Trim() == "" || nombre.Trim() == "" || apellido.Trim() == "")
            {
                MessageBox.Show("Debe completar los 3 campos");
            }
            else
            {
                try
                {
                    string query = "SELECT * FROM JUST_DO_IT.ConsultaMillas (" + DNI + ", '" + nombre + "', '" + apellido + "')";
                    SqlDataReader reader = Server.getInstance().query(query);
                    int cont = 0;
                    while (reader.Read())
                    {
                        dgvDetalleMillas.Rows.Add(reader["millas"].ToString(), reader["vencimiento"].ToString());
                        cont++;
                    }
                    if (cont == 0)
                        MessageBox.Show("El usuario ingresado no existe o no posee millas");
                    reader.Close();
                    query = "SELECT JUST_DO_IT.CantidadDeMillasUsuario (" + DNI + ", '" + nombre + "', '" + apellido + "') AS millas";
                    reader = Server.getInstance().query(query);
                    reader.Read();
                    lblMillas.Text = reader["millas"].ToString();
                    reader.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar datos validos");
                }
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvDetalleMillas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
