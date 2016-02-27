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

namespace AerolineaFrba.Abm_Rol
{
    public partial class quitarFuncionalidad : Form
    {
        private int idRol1;
        
        public quitarFuncionalidad(int idRol)
        {
            InitializeComponent();
            this.idRol1 = idRol;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dgvShowRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void actualizarTabla()
        {
            dgvShowRoles.Rows.Clear();
            dgvShowRoles.Refresh();

            {
                string query = "SELECT * FROM JUST_DO_IT.nombresRolesYFuncionalidades (" + idRol1 + ")";
              
            
                SqlDataReader reader = Server.getInstance().query(query);
                while (reader.Read())
                {
                    dgvShowRoles.Rows.Add(reader["nombreFuncionalidad"].ToString());
                }
                reader.Close();
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            this.actualizarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           DataGridViewRow row = Commons.getInstance().getSelectedRow(dgvShowRoles);
           if (row == null)
            {
                MessageBox.Show("No se ha seleccionado ninguna funcionalidad");
                return;
            }
           if (dgvShowRoles.RowCount == 1)
           {
               MessageBox.Show("El rol no puede quedar sin funcionalidades");
               return;
           }
            string descripcionFuncionalidad = row.Cells[0].Value.ToString();
            int idFuncionalidad = Funcionalidad.obtenerID(descripcionFuncionalidad);

            string query = "EXEC JUST_DO_IT.bajaRol_Funcionalidad " + idRol1 + "," + idFuncionalidad;
            try
            {
                Server.getInstance().realizarQuery(query);
                MessageBox.Show("La funcionalidad se eliminó satisfactoriamente");
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            this.Hide();
            new Vistas_Inicio.Inicio_Admin().Show();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Vistas_Inicio.Inicio_Admin().Show();
        }
    }
}
