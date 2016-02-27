using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Abm_Ruta
{
    public class Ruta
    {
        public int id { get; set; }
        public int codigo { get; set; }
        public float precio_base_kg { get; set; }
        public float precio_base_pasaje { get; set; }
        public string ciudad_origen { get; set; }
        public string ciudad_destino { get; set; }
        public string servicio { get; set; }

        public Ruta() { }
    }
}
