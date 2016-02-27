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

namespace AerolineaFrba.Abm_Funcionalidades
{
    public partial class bajaFunc : Form
    {
        public bajaFunc()
        {
            InitializeComponent();
            SqlDataReader respuesta;
            Server server = Server.getInstance();
            string queryCombo = "SELECT DISTINCT descripcion FROM JUST_DO_IT.funcionalidades WHERE eliminada = 0";
            respuesta = server.query(queryCombo);

            while (respuesta.Read())
            {
                comboBoxFunc.Items.Add(respuesta["descripcion"].ToString());
            }
            respuesta.Close();
        }


        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Vistas_Inicio.Inicio_Admin().Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxFunc.Text.Trim() != "")
            {
                string descripcion = comboBoxFunc.Text;

                string query = "EXEC JUST_DO_IT.eliminarFuncionalidad '" + descripcion + "'";
                try
                {
                    Server.getInstance().realizarQuery(query);
                    MessageBox.Show("La funcionalidad se eliminó satisfactoriamente");
                    this.Hide();
                    new Vistas_Inicio.Inicio_Admin().Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese la descripción");
            }
        }

        private void bajaFunc_Load(object sender, EventArgs e)
        {

        }
    }
}
