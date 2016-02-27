using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Abm_Aeronave
{
    public class Aeronave
    {
        public int id { get; set; }
        public string matricula { get; set; }
        public string modelo { get; set; }
        public float kgs_disponibles { get; set; }
        public int butacas_totales { get; set; }
        public string fabricante { get; set; }
        public string servicio { get; set; }
    }
}
