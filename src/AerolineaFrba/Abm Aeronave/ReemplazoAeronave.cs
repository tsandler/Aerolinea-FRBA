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
    public partial class ReemplazoAeronave : Form
    {
        Form ventanaAnterior;
        Boolean finVidaUtil;
        DateTimePicker fechaFueraServicio;
        DateTimePicker fechaReinicioServicio;
        public string matriculaNueva { get; set; }

        private string matriculaAReemplazar;
        public ReemplazoAeronave(string matricula, Form formulario)
        {
            InitializeComponent();
            matriculaAReemplazar = matricula;
            finVidaUtil = true;
            ventanaAnterior = formulario;
        }

        public ReemplazoAeronave(string matricula, DateTimePicker fechaFueraServicio, DateTimePicker fechaReinicioServicio, Form formulario)
        {
            InitializeComponent();
            matriculaAReemplazar = matricula;
            this.fechaFueraServicio = fechaFueraServicio;
            this.fechaReinicioServicio = fechaReinicioServicio;
            finVidaUtil = false;
            ventanaAnterior = formulario;
        }

        private void ReemplazoAeronaveFinVidaUtil_Load(object sender, EventArgs e)
        {
            string query;
            if (finVidaUtil)
            {
                query = "SELECT * FROM JUST_DO_IT.obtener_aeronaves_que_reemplacen_a('" + this.matriculaAReemplazar + "', 1, null, null)";
            }
            else {
                query = "SELECT * FROM JUST_DO_IT.obtener_aeronaves_que_reemplacen_a('" + this.matriculaAReemplazar + "', 0, '" + this.fechaFueraServicio.Value.ToString("yyyy-MM-dd") + "', '" + this.fechaReinicioServicio.Value.ToString("yyyy-MM-dd") + "')";
            }
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvAeronaves.Rows.Add(reader["matricula"].ToString(), reader["butacas"].ToString(),
                    reader["kgs"].ToString(), reader["tipoServicio"].ToString(), reader["fabricante"].ToString());
            }
            reader.Close();
            mostrarBotonNuevaAeronave();
        }

        private void listadoDeRutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReemplazarAeronave_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = Commons.getInstance().getSelectedRow(dgvAeronaves);
                if (this.matriculaNueva == null)
                {
                    this.matriculaNueva = row.Cells[0].Value.ToString();
                }
                string query;
                if (finVidaUtil)
                {
                    query = "EXEC JUST_DO_IT.reemplazar_vuelos_aeronave_fin_vida_util '" + this.matriculaAReemplazar + "', '" + matriculaNueva + "'";
                }
                else {
                    query = "EXEC JUST_DO_IT.reemplazar_vuelos_aeronave_fuera_servicio '" + this.matriculaAReemplazar + "', '" + matriculaNueva + "', '" + this.fechaFueraServicio.Value.ToString("yyyy-MM-dd") + "', '" + this.fechaReinicioServicio.Value.ToString("yyyy-MM-dd") + "'";
                }
                SqlDataReader reader = Server.getInstance().query(query);
                MessageBox.Show("Los vuelos han sido reemplazados y la aeronave se dio de baja satisfactoriamente");
                reader.Close();
                this.Close();
                ventanaAnterior.Close();
                new Vistas_Inicio.Inicio_Admin().Show();
            }
            catch {
                MessageBox.Show("Error: Los vuelos no han sido reemplazados");
            }

        }

        public void mostrarBotonNuevaAeronave()
        {
            if (this.dgvAeronaves.RowCount == 0)
                this.agregarAeronave.Show();
        }

        private void agregarAeronave_Click(object sender, EventArgs e)
        {
            new Abm_Aeronave.Alta(matriculaAReemplazar, this).Show();
            this.Close();
        }

        public void aeronaveCreada(string matricula)
        {
            this.matriculaNueva = matricula;
            btnReemplazarAeronave.PerformClick();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
