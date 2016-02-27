using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba
{
    public partial class inicioPrograma : Form
    {
        public inicioPrograma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Vistas_Inicio.Menu_Invitado().Show();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            new Registro_de_Usuario.Login(this).Show();
        }
    }
}
