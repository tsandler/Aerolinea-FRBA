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
    public partial class agregarFuncionalidad : Form
    {
        private int idRol1;
        public agregarFuncionalidad(int idRol)
        {
            InitializeComponent();
            this.idRol1 = idRol;
        }
        
        private void actualizarTabla()
        {
            dgvShowRoles.Rows.Clear();
            dgvShowRoles.Refresh();
            
            string query = "SELECT * FROM JUST_DO_IT.Funcionalidades WHERE eliminada = 0";

            System.Data.SqlClient.SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvShowRoles.Rows.Add(reader["descripcion"].ToString());
            }
            reader.Close();
            
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = Commons.getInstance().getSelectedRow(dgvShowRoles);
            if (row == null)
            {
                MessageBox.Show("No se ha seleccionado ninguna funcionalidad");
                return;
            }
  
            string descripcionFuncionalidad = row.Cells[0].Value.ToString();
            int idFuncionalidad = Funcionalidad.obtenerID(descripcionFuncionalidad);

            string query = "EXEC JUST_DO_IT.almacenarRol_Funcionalidad " + idRol1 + "," + idFuncionalidad;
            try
            {
                Server.getInstance().realizarQuery(query);
                MessageBox.Show("La funcionalidad se agregó satisfactoriamente");
                this.Hide();
                new Vistas_Inicio.Inicio_Admin().Show();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Vistas_Inicio.Inicio_Admin().Show();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            this.actualizarTabla();
        }

    }
}
