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

namespace AerolineaFrba.Canje_Millas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.cargarPremios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DNI = txtDNI.Text;
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            if (DNI.Trim() == "" || nombre.Trim() == "" || apellido.Trim() == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                try
                {
                    try
                    {
                        float.Parse(txtDNI.Text);
                        int.Parse(txtCantidad.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Debe ingresar datos validos");
                        return;
                    }

                    DataGridViewRow premio = Commons.getInstance().getSelectedRow(dgvMillasPorProducto);
                    if (premio == null)
                    {
                        MessageBox.Show("Debe seleccionar algun premio");
                        return;
                    }
                    string query = "EXEC JUST_DO_IT.canjearMillas '" + DNI + "', '" + nombre + "', '" + apellido + "', '" +
                        premio.Cells[0].Value.ToString() + "', '" + txtCantidad.Text + "'";
                    Server.getInstance().realizarQuery(query);
                    MessageBox.Show("El premio se ha canjeado exitosamente");
                    this.Hide();
                    new Vistas_Inicio.Inicio_Admin().Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cargarPremios()
        {
            string query = "SELECT * FROM JUST_DO_IT.Productos";
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvMillasPorProducto.Rows.Add(reader["descripcionProd"].ToString(), reader["cantMillasNecesarias"].ToString());
            }
            reader.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Vistas_Inicio.Inicio_Admin().Show();
        }
      }
}
