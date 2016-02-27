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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class Alta : Form
    {
        public SqlDataReader respuesta;
        public string matriculaAReemplazar { get; set; }
        public Abm_Aeronave.ReemplazoAeronave owner { get; set; }

        public Alta()
        {
            InitializeComponent();
        }

        public Alta(string matriculaAReemplazar, Abm_Aeronave.ReemplazoAeronave owner)
        {
            InitializeComponent();
            this.matriculaAReemplazar = matriculaAReemplazar;
            this.owner = owner;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Commons.getInstance().cargarComboBox("Aeronaves", "fabricante", cbFabricante);
            Commons.getInstance().cargarComboBox("TiposServicios", "nombre", cbTipoServicio);
            if(matriculaAReemplazar != null){
                this.cargarDatos();
                tbEspacioTotalParaEncomiendas.Enabled = false;
                tbCantButacas.Enabled = false;
                cbFabricante.Enabled = false;
                cbTipoServicio.Enabled = false;
            }
        }

        public void cargarDatos()
        {
            this.cargarTextBox("Aeronaves", "kgs_disponibles", tbEspacioTotalParaEncomiendas);
            this.cargarTextBox("Aeronaves", "butacas_totales", tbCantButacas);
            this.autoCompletarCombo("Aeronaves", "fabricante", cbFabricante, "Aeronaves.matricula = '" + matriculaAReemplazar + "'");
            this.autoCompletarComboConOtraTabla("Aeronaves", "tipo_servicio", cbTipoServicio, "Aeronaves.matricula = '" + matriculaAReemplazar + "' AND Aeronaves.tipo_servicio = TipoServicio.id", " Aeronaves.tipo_servicio = TipoServicio.id");
        }

        public void cargarTextBox(string entidad, string atributo, TextBox textbox)
        {
            Server server = Server.getInstance();
            string queryTextBox = "SELECT DISTINCT " + atributo + " FROM JUST_DO_IT." + entidad + " AS " + entidad + " WHERE Aeronaves.matricula = '" + matriculaAReemplazar + "'";
            respuesta = server.query(queryTextBox);

            respuesta.Read();
            textbox.Text = Convert.ToString(respuesta[atributo]);

            respuesta.Close();
        }

        public void autoCompletarCombo(string entidad, string atributo, ComboBox comboBox, string condicion)
        {
            Server server = Server.getInstance();
            string queryComboBox = "SELECT " + atributo + " AS atributo FROM JUST_DO_IT." + entidad + " WHERE " + condicion;
            respuesta = server.query(queryComboBox);
            respuesta.Read();
            string nombreAtributo = respuesta["atributo"].ToString();
            respuesta.Close();

            int idAtributo = 0;
            respuesta = server.query("SELECT DISTINCT " + atributo + " AS atributo FROM JUST_DO_IT." + entidad);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbNumeroMatricula.Clear();
            tbModelo.Clear();
            cbFabricante.Items.Clear();
            cbTipoServicio.Items.Clear();
            tbCantButacas.Clear();
            tbEspacioTotalParaEncomiendas.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{ 
                if (this.aeronaveValida() && this.validarCampos())
                {
                    string altaAeronave;
                    string generarButacas;
                    string matricula = tbNumeroMatricula.Text;
                    string modelo = tbModelo.Text;
                    string fabricante = this.buscarSegunPosicion(cbFabricante.SelectedIndex, "Aeronaves", "fabricante");
                    int tipoDeServicio = TiposServicios.obtenerID(cbTipoServicio.Text);
                    float espacioParaEncomiendas = float.Parse(tbEspacioTotalParaEncomiendas.Text);
                    int cantidadButacas = int.Parse(tbCantButacas.Text);

                    altaAeronave = "EXEC JUST_DO_IT.almacenarAeronave '" + matricula + "', '" + modelo + "', '" + fabricante + "', " + tipoDeServicio + ", " + espacioParaEncomiendas + ", " + cantidadButacas;
                    generarButacas = "EXEC JUST_DO_IT.generar_butacas '" + matricula + "', " + cantidadButacas;
                    try
                    {
                        Server.getInstance().realizarQuery(altaAeronave);
                        Server.getInstance().realizarQuery(generarButacas);
                        MessageBox.Show("La aeronave se agrego satisfactoriamente");
                        if (this.matriculaAReemplazar != null)
                        {
                            owner.aeronaveCreada(matricula);
                            this.Close();
                            new Vistas_Inicio.Inicio_Admin().Show();
                        }
                        else
                        {
                            this.Close();
                            new Vistas_Inicio.Inicio_Admin().Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Debe crear una aeronave con el mismo fabricante, tipo de servicio, cantidad de butacas y kilogramos disponibles");
                }
            }
            catch
            {
                MessageBox.Show("Debe ingresar datos validos");
            }
        }

        private void tbNumeroMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbModelo_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void cbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void tbEspacioTotalParaEncomiendas_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void cbFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private bool validarCampos() {
            return (tbNumeroMatricula.Text.Trim() != "" && tbModelo.Text.Trim() != ""
                && cbFabricante.Text.Trim() != "" && cbTipoServicio.Text.Trim() != "" &&
                tbCantButacas.Text.Trim() != "" && tbEspacioTotalParaEncomiendas.Text.Trim() != "");
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new Vistas_Inicio.Inicio_Admin().Show();
        }

        public bool aeronaveValida()
        {
            bool retorno;
            if (this.matriculaAReemplazar != null)
            {
                string query = "SELECT * FROM JUST_DO_IT.Aeronaves a, JUST_DO_IT.TiposServicios t WHERE a.tipo_servicio = t.id AND a.matricula = '" + matriculaAReemplazar + "'";
                SqlDataReader reader = Server.getInstance().query(query);
                reader.Read();
                retorno = this.cbFabricante.SelectedItem.ToString() == reader["fabricante"].ToString() && this.cbTipoServicio.SelectedItem.ToString() == reader["nombre"].ToString() &&
                this.tbCantButacas.Text.ToString() == reader["butacas_totales"].ToString() && this.tbEspacioTotalParaEncomiendas.Text == reader["kgs_disponibles"].ToString();
                reader.Close();
            }
            else retorno = true;
            return retorno;
        }

    }
}
