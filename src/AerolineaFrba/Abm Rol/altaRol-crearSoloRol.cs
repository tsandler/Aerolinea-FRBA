using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Rol
{
    public partial class altaRol_crearSoloRol : Form
    {
        public altaRol_crearSoloRol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //siguiente
        {
            if (tbNombreNuevo.Text.Trim() != "")
            {
                string nombreR = tbNombreNuevo.Text;
                new altaRol_elegirFuncionalidades(nombreR).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No ingresó el nombre del nuevo rol");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Vistas_Inicio.Inicio_Admin().Show();
        }



    }
}
