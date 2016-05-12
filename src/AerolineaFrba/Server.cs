using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AerolineaFrba
{
    class Server
    {

		/// <summary>Load the connection variables from the configuration file</summary>
        string servidor = ConfigurationManager.AppSettings["server"];
        string db = ConfigurationManager.AppSettings["database"];
        string user = ConfigurationManager.AppSettings["username"];
        string password = ConfigurationManager.AppSettings["password"];
		///
		
        public static Server server;
        private SqlConnection connection;
        private SqlDataReader reader;

		/// <summary>Get the instance for the server</summary>
        public static Server getInstance()
        {
            if (server == null)
            {
                server = new Server();
                server.conectar();
            }
            return server;
        }

		/// <summary>Execute a query with a return value (functions or selects)</summary>
		/// <param name="query">Query to be executed</param>
		/// <returns>Returns the reader with the results of the query</returns>
        public SqlDataReader query(string query)
        {
            SqlCommand command = new SqlCommand(query, this.connection);
            this.reader = command.ExecuteReader();
            return this.reader;
        }
		
		/// <summary>Close the reader opened with the previous method (if the reader is not closed it will fail in the next execution)</summary>
        public void closeReader()
        {
            this.reader.Close();
        }

		/// <summary>Execute a query without a return value (procedures, updates, drops, etc)</summary>
        public void realizarQuery(string query) {
            this.query(query);
            this.closeReader();
        }
		
		/// <summary>Connects to the database</summary>
        private void conectar()
        {
            try
            {
                this.connection = new SqlConnection("Data Source=" + servidor +
                    ";Initial Catalog=" + db + ";Integrated Security=False;User ID=" + user + ";Password=" + password);
                this.connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
