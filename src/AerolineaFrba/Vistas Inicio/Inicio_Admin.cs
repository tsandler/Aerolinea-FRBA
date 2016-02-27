using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Vistas_Inicio
{
    public partial class Inicio_Admin : Form
    {
        public Inicio_Admin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void altaAeronave_Click(object sender, EventArgs e)
        {
            new Abm_Aeronave.Alta().Show();
            this.Hide();
        }

        private void altaRuta_Click(object sender, EventArgs e)
        {
            new Abm_Ruta.Alta_Ruta().Show();
            this.Hide();
        }

        private void modificarRuta_Click(object sender, EventArgs e)
        {
            new Abm_Ruta.Listado_Rutas().Show();
            this.Hide();
        }

        private void bajaRuta_Click(object sender, EventArgs e)
        {
            new Abm_Ruta.Baja_Ruta().Show();
            this.Hide();
        }

        private void modificarAeronave_Click(object sender, EventArgs e)
        {
            new Abm_Aeronave.Listado_Aeronaves(true).Show();
            this.Hide();
        }

        private void bajaAeronave_Click(object sender, EventArgs e)
        {
            new Abm_Aeronave.Baja().Show();
            this.Hide();
        }

        private void altaViaje_Click(object sender, EventArgs e)
        {
            new Generacion_Viaje.Alta_Viaje().Show();
            this.Hide();
        }

        private void registroLlegada_Click(object sender, EventArgs e)
        {
            new Registro_Llegada_Destino.Registro().Show();
            this.Hide();
        }

        private void compraPasajes_Encom_Click(object sender, EventArgs e)
        {
            new Compra.compraPasaje().Show();
            this.Hide();
        }

        private void crearFuncionalidad_Click(object sender, EventArgs e)
        {
            new Abm_Funcionalidades.Alta().Show();
            this.Hide();
        }

        private void modificarFuncionalidad_Click(object sender, EventArgs e)
        {

        }

        private void bajaFuncionalidad_Click(object sender, EventArgs e)
        {
            new Abm_Funcionalidades.bajaFunc().Show();
            this.Hide();
        }

        private void bajaPasaje_Encom_Click(object sender, EventArgs e)
        {
            new Devolucion.Devoluciones().Show();
            this.Hide();
        }

        private void estadisticas_Click(object sender, EventArgs e)
        {
            new Listado_Estadistico.Estadistica().Show();
            this.Hide();
        }

        private void crearRol_Click(object sender, EventArgs e)
        {
            new Abm_Rol.altaRol_crearSoloRol().Show();
            this.Hide();
        }

        private void modificarRol_Click(object sender, EventArgs e)
        {
            new Abm_Rol.modificarRol().Show();
            this.Hide();
        }

        private void eliminarRol_Click(object sender, EventArgs e)
        {
            new Abm_Rol.bajaRol().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Abm_Ciudad.AltaCiudad().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Canje_Millas.Form1().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Abm_Ruta.Alta_Ruta().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Abm_Ruta.Modificar_Ruta().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Abm_Ruta.Baja_Ruta().Show();
            this.Hide();
        }

        private void btnConsultarMillas_Click(object sender, EventArgs e)
        {
            new Consulta_Millas.ConsultaMillas(this).Show();
            this.Hide();
        }

        private void asignarRol_Usuario_Click(object sender, EventArgs e)
        {
            new Abm_Rol.Asignar_rol_a_usuario().Show();
            this.Hide();
        }


    }
}
