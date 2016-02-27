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
    public partial class Menu_Invitado : Form
    {
        public Menu_Invitado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Consulta_Millas.ConsultaMillas(this).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Canje_Millas.Form1().Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            new Compra.compraPasaje().Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new inicioPrograma().Show();
        }

    }
}
