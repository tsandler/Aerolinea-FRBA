using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba
{
    class Ciudades
    {
        public static int obtenerID(string nombre)
        {
            return Commons.getInstance().getIDFrom("IDCiudad", nombre);
        }
    }
}
