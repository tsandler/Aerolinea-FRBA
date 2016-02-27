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
        string servidor = ConfigurationManager.AppSettings["server"];
        string db = ConfigurationManager.AppSettings["database"];
        string user = ConfigurationManager.AppSettings["username"];
        string password = ConfigurationManager.AppSettings["password"];
        public static Server server;
        private SqlConnection connection;
        private SqlDataReader reader;

        public static Server getInstance()
        {
            if (server == null)
            {
                server = new Server();
                server.conectar();
            }
            return server;
        }

        public SqlDataReader query(string query)
        {
            SqlCommand command = new SqlCommand(query, this.connection);
            this.reader = command.ExecuteReader();
            return this.reader;
        }

        public void closeReader()
        {
            this.reader.Close();
        }

        public void realizarQuery(string query) {
            this.query(query);
            this.closeReader();
        }

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
