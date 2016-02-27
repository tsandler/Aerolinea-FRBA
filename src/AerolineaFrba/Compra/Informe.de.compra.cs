using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class InformeDeCompra : Form
    {
        public InformeDeCompra() { }

        public InformeDeCompra(string monto, string codigo)
        {
            InitializeComponent();
            lblMontoAAbonar.Text = monto.ToString();
            lblNumeroCompraPNR.Text = codigo.ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            new Vistas_Inicio.Inicio_Admin().Show();
            this.Hide();
        }
    }
}
