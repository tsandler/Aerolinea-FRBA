using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Registro_de_Usuario;
using AerolineaFrba.Abm_Aeronave;
using AerolineaFrba.Abm_Ruta;

namespace AerolineaFrba
{
    static class Program
    {
        /// <summary> 
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new inicioPrograma()); 
        }   
    }
}
