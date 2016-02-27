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
    public partial class bajaRol : Form
    {
        public bajaRol()
        {
            InitializeComponent();
            Commons.getInstance().cargarComboBoxWhere("Roles","nombre", comboBoxNombreRol,"baja_rol = 0");
        }

        private void button1_Click(object sender, EventArgs e) //aceptar
        {

            if (comboBoxNombreRol.Text != "")
            {
                try
                {
                    string nombre = comboBoxNombreRol.Text;
                    string query_rol = "EXEC JUST_DO_IT.bajaRol '" + nombre + "'";
                    Server.getInstance().realizarQuery(query_rol);
                    MessageBox.Show("El rol se ha dado de baja correctamente");
                    this.Close();
                    new Vistas_Inicio.Inicio_Admin().Show();
                }
                catch(Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                }
            }
            else
            {
                MessageBox.Show("No seleccióno ningun rol");
            }

        }

        private void button2_Click(object sender, EventArgs e) // cancelar
        {
            this.Close();
            new Vistas_Inicio.Inicio_Admin().Show();
        }
    }
}
