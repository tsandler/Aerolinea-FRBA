using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Funcionalidades
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text.Trim() != "")
            {
                string descripcion = tbNombre.Text;

                string query = "EXEC JUST_DO_IT.almacenarFuncionalidad '" + descripcion + "'";
                try
                {
                    Server.getInstance().realizarQuery(query);
                    MessageBox.Show("La funcionalidad se agrego satisfactoriamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Hide();
                new Vistas_Inicio.Inicio_Admin().Show();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese la descripción");
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Vistas_Inicio.Inicio_Admin().Show();
        }
    }
}
