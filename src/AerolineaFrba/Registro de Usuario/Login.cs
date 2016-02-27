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


namespace AerolineaFrba.Registro_de_Usuario
{
    public partial class Login : Form
    {
        Form previous;

        public Login() { }

        public Login(Form p)
        {
            InitializeComponent();
            this.previous = p;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server server = Server.getInstance();
            string queryLogueo = "EXEC JUST_DO_IT.LoguearUsuario '" + username.Text + "', '" + password.Text + "'";
            try
            {
                server.realizarQuery(queryLogueo);
                this.Hide();
                this.previous.Hide();
                new Vistas_Inicio.Inicio_Admin().Show();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultaMillas_Click(object sender, EventArgs e)
        {
            
        }
    }
}
