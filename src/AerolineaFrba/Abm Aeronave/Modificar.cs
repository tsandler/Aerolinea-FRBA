using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class Modificar : Form
    {

        public SqlDataReader respuesta;
        private string matriculaAModificar;
        public int aeronaveId { get; set; }

        public Modificar(string matricula, int id)
        {
            InitializeComponent();
            matriculaAModificar = matricula;
            aeronaveId = id;
            this.cargarDatos();
            this.habilitarBotoFueraDeServicio();
        }

        private void habilitarBotoFueraDeServicio()
        {
            string query = "SELECT * FROM JUST_DO_IT.Aeronaves WHERE id = " + aeronaveId;
            SqlDataReader reader = Server.getInstance().query(query);
            reader.Read();
            if (Convert.ToInt32(reader["baja_fuera_servicio"]) == 1)
            {
                this.btAltaFueraServicio.Enabled = true;
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server server = Server.getInstance();
            try
            {
                if (!this.validarCampos())
                {
                    MessageBox.Show("Debe completar todos los campos");
                    return;
                }
                string matricula = tbNumeroMatricula.Text;
                string modelo = tbModelo.Text;
                string fabricante = this.buscarSegunPosicion(cbFabricante.SelectedIndex, "Aeronaves", "fabricante");
                int tipoDeServicio = TiposServicios.obtenerID(cbTipoServicio.Text);
                float espacioParaEncomiendas = float.Parse(tbEspacioTotalParaEncomiendas.Text);
                int cantidadButacas = int.Parse(tbCantButacas.Text);

                string modificarAeronave = "EXEC JUST_DO_IT.modificarAeronave " + aeronaveId + ", '" + matricula + "', '" + modelo + "', '" + fabricante + "', " + tipoDeServicio + ", " + espacioParaEncomiendas + ", " + cantidadButacas;
                try
                {
                    Server.getInstance().realizarQuery(modificarAeronave);
                    MessageBox.Show("La aeronave se modifico satisfactoriamente");
                    this.Close();
                    new Vistas_Inicio.Inicio_Admin().Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch {
                MessageBox.Show("Los datos modificados no son validos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Vistas_Inicio.Inicio_Admin().Show();
        }

        public void cargarTextBox(string entidad, string atributo, TextBox textbox)
        {
            Server server = Server.getInstance();
            string queryTextBox = "SELECT DISTINCT " + atributo + " FROM JUST_DO_IT." + entidad + " AS " + entidad + " WHERE Aeronaves.matricula = '" + tbNumeroMatricula.Text + "'";
            respuesta = server.query(queryTextBox);

            respuesta.Read();
            textbox.Text = Convert.ToString(respuesta[atributo]);

            respuesta.Close();
        }

        public void autoCompletarCombo(string entidad, string atributo, ComboBox comboBox, string condicion) {
            Server server = Server.getInstance();
            string queryComboBox = "SELECT " + atributo + " AS atributo FROM JUST_DO_IT." + entidad + " WHERE " + condicion;
            respuesta = server.query(queryComboBox);
            respuesta.Read();
            string nombreAtributo = respuesta["atributo"].ToString();
            respuesta.Close();

            int idAtributo = 0;
            respuesta = server.query("SELECT DISTINCT " + atributo + " AS atributo FROM JUST_DO_IT." + entidad);
            while (respuesta.Read()){
                if (String.CompareOrdinal(nombreAtributo, respuesta["atributo"].ToString()) == 0){
                    break;
                }
                idAtributo++;
            }
            comboBox.SelectedIndex = idAtributo;
            respuesta.Close();
        }

        public void autoCompletarComboConOtraTabla(string entidad, string atributo, ComboBox comboBox, string condicionParaBuscarElTipoEspecifico, string condicionParaBuscarTodosLosTipos)
        {
            Server server = Server.getInstance();
            string queryComboBox = "SELECT DISTINCT TipoServicio.nombre AS atributo FROM JUST_DO_IT.TiposServicios AS TipoServicio, JUST_DO_IT." + entidad + " AS Aeronaves WHERE " + condicionParaBuscarElTipoEspecifico;
            respuesta = server.query(queryComboBox);
            respuesta.Read();
            string nombreAtributo = respuesta["atributo"].ToString();
            respuesta.Close();

            int idAtributo = 0;
            respuesta = server.query("SELECT DISTINCT TipoServicio.nombre AS atributo FROM JUST_DO_IT.TiposServicios AS TipoServicio, JUST_DO_IT." + entidad + " AS Aeronaves WHERE " + condicionParaBuscarTodosLosTipos);
            while (respuesta.Read())
            {
                if (String.CompareOrdinal(nombreAtributo, respuesta["atributo"].ToString()) == 0)
                {
                    break;
                }
                idAtributo++;
            }
            comboBox.SelectedIndex = idAtributo;
            respuesta.Close();
        }

        public void cargarDatos()
        {
            tbNumeroMatricula.Text = this.matriculaAModificar;
            Commons.getInstance().cargarComboBox("Aeronaves", "fabricante", cbFabricante);
            Commons.getInstance().cargarComboBox("TiposServicios", "nombre", cbTipoServicio);
            this.cargarTextBox("Aeronaves", "modelo", tbModelo);
            this.cargarTextBox("Aeronaves", "kgs_disponibles", tbEspacioTotalParaEncomiendas);
            this.cargarTextBox("Aeronaves", "butacas_totales", tbCantButacas);
            this.autoCompletarCombo("Aeronaves", "fabricante", cbFabricante, "Aeronaves.matricula = '" + tbNumeroMatricula.Text + "'");
            this.autoCompletarComboConOtraTabla("Aeronaves", "tipo_servicio", cbTipoServicio, "Aeronaves.matricula = '" + tbNumeroMatricula.Text + "' AND Aeronaves.tipo_servicio = TipoServicio.id", " Aeronaves.tipo_servicio = TipoServicio.id");
        }

        private bool validarCampos()
        {
            return (tbNumeroMatricula.Text.Trim() != "" && tbModelo.Text.Trim() != ""
                && cbFabricante.Text.Trim() != "" && cbTipoServicio.Text.Trim() != "" &&
                 tbEspacioTotalParaEncomiendas.Text.Trim() != "");
        }

        public string buscarSegunPosicion(int posicion, string entidad, string atributo)
        {
            Server server = Server.getInstance();
            SqlDataReader respuesta = server.query("SELECT DISTINCT " + atributo + " AS atributo FROM JUST_DO_IT." + entidad);
            for (int i = 0; i <= posicion; i++)
            {
                respuesta.Read();
            }
            string fabricante = respuesta["atributo"].ToString();
            respuesta.Close();
            return fabricante;
        }

        private void btAltaFueraServicio_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "EXEC JUST_DO_IT.alta_aeronave_fuera_de_servicio " + aeronaveId;
                Server.getInstance().realizarQuery(query);
                this.btAltaFueraServicio.Enabled = false;
                MessageBox.Show("Se ha dado de alta la aeronave");
            }
            catch
            {
                MessageBox.Show("No se ha podido dar de alta la aeroanve");
            }

        }

        private void Modificar_Load(object sender, EventArgs e)
        {

        }
    }
}
