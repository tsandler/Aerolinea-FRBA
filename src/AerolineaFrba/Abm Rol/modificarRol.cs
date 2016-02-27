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
    public partial class modificarRol : Form
    {

        public modificarRol()
        {
            InitializeComponent();
            Commons.getInstance().cargarComboBox("Roles","nombre", comboBox1);
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Vistas_Inicio.Inicio_Admin().Show();
        }

        private void modificarNombre_Click_1(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
            {
                MessageBox.Show("No seleccionó ningun rol");
            }
            else
            {

                string descrRol = comboBox1.Text;
                string query = "EXEC JUST_DO_IT.existeRol '" + descrRol + "'";
                try
                {
                    Server.getInstance().realizarQuery(query);
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    return;
                }

                string nombreRol = comboBox1.Text;
                int idRol = Rol.obtenerID(nombreRol);
                new modificarNombre(idRol,nombreRol).Show();
                this.Hide();
            }
        }

        private void agregarFuncionalidad_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("No seleccionó ningun rol");
            }
            else
            {
                string descrRol = comboBox1.Text;
                string query = "EXEC JUST_DO_IT.existeRol '" + descrRol + "'";
                try
                {
                    Server.getInstance().realizarQuery(query);
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    return;
                }
                
                
                string nombreRol = comboBox1.Text;
                int idRol = Rol.obtenerID(nombreRol);

                new agregarFuncionalidad(idRol).Show();
                this.Hide();
            }
        }

        private void quitarFunc_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("No seleccionó ningun rol");
            }
            else
            {
                string descrRol = comboBox1.Text;
                string query = "EXEC JUST_DO_IT.existeRol '" + descrRol + "'";
                try
                {
                    Server.getInstance().realizarQuery(query);
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    return;
                }          
                
                string nombreRol = comboBox1.Text;
                int idRol = Rol.obtenerID(nombreRol);

                new quitarFuncionalidad(idRol).Show();
                this.Hide();
            }
        }

        private void btn_altaRolExistente_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("No seleccionó ningun rol");
            }
            else
            {
                string descrRol = comboBox1.Text;
                string query = "EXEC JUST_DO_IT.existeRol '" + descrRol + "'";
                try
                {
                    Server.getInstance().realizarQuery(query);
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    return;
                }

                descrRol = comboBox1.Text;
                query = "EXEC JUST_DO_IT.estabaDadoDeBajaElRol '" + descrRol + "'";
                try
                {
                    Server.getInstance().realizarQuery(query);
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    return;
                }
                string nombreRol = comboBox1.Text;
                query = "EXEC JUST_DO_IT.altaRolExistente '" + nombreRol + "'";
                try
                {
                    Server.getInstance().realizarQuery(query);
                    MessageBox.Show("El rol se habilitó correctamente");
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                }
            } 
        }
    }
}
