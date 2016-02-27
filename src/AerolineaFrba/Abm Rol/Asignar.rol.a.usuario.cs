using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Rol
{
    public partial class Asignar_rol_a_usuario : Form
    {
        public int idRol;
        public int idUsuario;

        public Asignar_rol_a_usuario()
        {
            InitializeComponent();
            Commons.getInstance().cargarComboBox("Roles","nombre",comboBoxRoles);
        }

        private void cargarListadoDeUsuarios()
        {
            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Refresh();
            
            string query = "SELECT * FROM JUST_DO_IT.ListadoUsuarios()";
            System.Data.SqlClient.SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvUsuarios.Rows.Add(reader["nombre"].ToString(), reader["apellido"].ToString(), reader["dni"].ToString());
            }
            reader.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            this.cargarListadoDeUsuarios();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
           // Busco al usuario
           DataGridViewRow row = Commons.getInstance().getSelectedRow(dgvUsuarios);
           if (row == null)
            {
                MessageBox.Show("No se ha seleccionado ningun usuario");
            }
            else
            {
                string nombre = row.Cells[0].Value.ToString();
                string apellido = row.Cells[1].Value.ToString();
                string dni = row.Cells[2].Value.ToString();

                System.Data.SqlClient.SqlDataReader reader;
                string query = "SELECT * FROM JUST_DO_IT.BuscarUsuario ('" + nombre + "','" + apellido + "'," + dni + ") AS id";
                string idUsuario;
               try
                {
                    reader = Server.getInstance().query(query);
                    reader.Read();
                    idUsuario = reader["id"].ToString();
                    reader.Close();
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    return;
                }



               // Busco al rol

                if (comboBoxRoles.Text == "")
                {
                    MessageBox.Show("No ingresó un rol");
                    return;
                }

                else
                {
                    string nombreRol = comboBoxRoles.Text;
                    idRol = Rol.obtenerID(nombreRol);
                }


               //Asigno Rol - Usuario
                query = "EXEC JUST_DO_IT.asignarRolAUsuario " + idRol + "," + idUsuario;
                try
                {
                    Server.getInstance().realizarQuery(query);
                    MessageBox.Show("El rol se asignó satisfactoriamente");
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                }

                this.Hide();
                new Vistas_Inicio.Inicio_Admin().Show();
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Vistas_Inicio.Inicio_Admin().Show();
        }
    }
}
