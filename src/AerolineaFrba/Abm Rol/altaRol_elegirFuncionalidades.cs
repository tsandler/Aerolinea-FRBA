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
    public partial class altaRol_elegirFuncionalidades : Form
    {
        public int idRol;
        public string nombreRol1;
        public int primeraEjecución=0;

        public altaRol_elegirFuncionalidades(string nombreR)
        {
            InitializeComponent();
            nombreRol1 = nombreR;
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



        private void btnAgregarFunc_Click(object sender, EventArgs e)
        {
            if (comboBoxFunc.Text == "")
                MessageBox.Show("No ingresó una funcionalidad");
            else
            {
                string descrFunc = comboBoxFunc.Text;
                string query = "EXEC JUST_DO_IT.existeFuncionalidad '" + descrFunc + "'";
                try
                {
                    Server.getInstance().realizarQuery(query);
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    return;
                }
                int idFuncionalidad = Funcionalidad.obtenerID(descrFunc);
                if (primeraEjecución == 0)
                {
                    query = "EXEC JUST_DO_IT.almacenarRol '" + nombreRol1 + "', " + idFuncionalidad;
                    primeraEjecución = 1;
                    try
                    {
                        Server.getInstance().realizarQuery(query);
                        MessageBox.Show("El rol se creo satisfactoriamente y se le asigno la funcionalidad");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    query = "EXEC JUST_DO_IT.almacenarRol_Funcionalidad " + idRol + "," + idFuncionalidad;
                    try
                    {
                        Server.getInstance().realizarQuery(query);
                        MessageBox.Show("La funcionalidad se agrego satisfactoriamente");
                    }
                    catch (Exception ex1)
                    {
                        MessageBox.Show(ex1.Message);
                    }
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new altaRol_crearSoloRol().Show();
        }
        
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (primeraEjecución == 0)
                MessageBox.Show("No ha seleccionado ninguna funcionalidad para el nuevo rol");
            else
            {
                this.Hide();
                new Vistas_Inicio.Inicio_Admin().Show();
            }
        }

        private void altaRol_elegirFuncionalidades_Load(object sender, EventArgs e)
        {

        }


    }
}
