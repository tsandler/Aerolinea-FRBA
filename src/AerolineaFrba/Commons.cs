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
		
		/// <summary>Get the instance for the commons functions</summary>
        public static Commons getInstance()
        {
            if (commons == null)
            {
                commons = new Commons();
            }
            return commons;
        }
		
		/// <summary>Load the combobox executing a query with the given parameters</summary>
		/// <param name="entidad">Name of the table</param>
		/// <param name="atributo">Name of the field to select</param>
		/// <param name="comboBox">Name of the combo box to insert the results</param>
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
		
		/// <summary>Load the combobox executing a query with the given parameters, using a where statement</summary>
		/// <param name="entidad">Name of the table</param>
		/// <param name="atributo">Name of the field to select</param>
		/// <param name="comboBox">Name of the combo box to insert the results</param>
		/// <param name="where">Condition to include in the query</param>
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
	
		/// <summary>Load the combobox executing a query with the given parameters, using the order by statement</summary>
		/// <param name="entidad">Name of the table</param>
		/// <param name="atributo">Name of the field to select</param>
		/// <param name="comboBox">Name of the combo box to insert the results</param>
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
		
		/// <summary>Select an ID from a table of a specific attribute</summary>
		/// <param name="function">The SQL function to execute</param>
		/// <param name="atributo">Name of the field to get the ID</param>
		/// <returns>The id of the given field in the table<returns>
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

		/// <summary>Get the selected row in a DataGridView</summary>
		/// <param name="dataGrid">The data grid to get the selected row</param>
		/// <returns>The selected row<returns>
        public DataGridViewRow getSelectedRow(DataGridView dataGrid)
        {
            foreach (DataGridViewRow row in dataGrid.SelectedRows)
                return row;

            return null;
        }
    }
}
