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
    public partial class modificarNombre : Form
    {
        private int idRolLocal;
        
        public modificarNombre(int idRol, string nombreRol)
        {
            InitializeComponent();
            this.idRolLocal = idRol;
            tbNombreViejo.Text = nombreRol;

        }

        private void tbNombreViejo_TextChanged(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            string nombreNuevo = tbNombreNuevo.Text;
            if (tbNombreNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nuevo nombre");
                return;
            }
            string query_rol = "EXEC JUST_DO_IT.modificarNombreRol " + idRolLocal + ",'" + nombreNuevo + "'";
            try
            {
                Server.getInstance().realizarQuery(query_rol);
                MessageBox.Show("El nombre de rol fue cambiado satisfactoriamente");
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
