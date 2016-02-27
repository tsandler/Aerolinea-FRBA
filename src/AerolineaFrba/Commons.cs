using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba
{
    class Commons
    {

        public static Commons commons;

        public static Commons getInstance()
        {
            if (commons == null)
            {
                commons = new Commons();
            }
            return commons;
        }

        public void cargarComboBox(string entidad, string atributo, ComboBox comboBox)
        {
            SqlDataReader respuesta;
            Server server = Server.getInstance();
            string queryCombo = "SELECT DISTINCT " + atributo + " FROM JUST_DO_IT." + entidad + " AS " + entidad;
            respuesta = server.query(queryCombo);

            while (respuesta.Read())
            {
                comboBox.Items.Add(respuesta[atributo].ToString());
            }
            respuesta.Close();
        }

        public void cargarComboBoxWhere(string entidad, string atributo, ComboBox comboBox, string where)
        {
            SqlDataReader respuesta;
            Server server = Server.getInstance();
            string queryCombo = "SELECT DISTINCT " + atributo + " FROM JUST_DO_IT." + entidad + " AS " + entidad + " WHERE " + where;
            respuesta = server.query(queryCombo);

            while (respuesta.Read())
            {
                comboBox.Items.Add(respuesta[atributo].ToString());
            }
            respuesta.Close();
        }

        public void cargarComboBoxOrderBy(string entidad, string atributo, ComboBox comboBox)
        {
            SqlDataReader respuesta;
            Server server = Server.getInstance();
            string queryCombo = "SELECT DISTINCT " + atributo + " FROM JUST_DO_IT." + entidad + " ORDER BY " + atributo;
            respuesta = server.query(queryCombo);

            while (respuesta.Read())
            {
                comboBox.Items.Add(respuesta[atributo].ToString());
            }
            respuesta.Close();
        }

        public int getIDFrom(string function, string atributo)
        {
            SqlDataReader reader;
            string query = "SELECT JUST_DO_IT." + function + "('%" + atributo + "%') AS id";
            reader = Server.getInstance().query(query);
            reader.Read();
            int id = int.Parse(reader["id"].ToString());
            reader.Close();
            return id;
        }

        public string getNombreFrom(string function, int id)
        {
            SqlDataReader reader;
            string query = "SELECT JUST_DO_IT." + function + "(" + id + ") AS nombre";
            reader = Server.getInstance().query(query);
            reader.Read();
            string nombre = reader["nombre"].ToString();
            reader.Close();
            return nombre;
        }

        public DataGridViewRow getSelectedRow(DataGridView dataGrid)
        {
            foreach (DataGridViewRow row in dataGrid.SelectedRows)
                return row;

            return null;
        }
    }
}
