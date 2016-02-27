using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba
{
    class TiposServicios
    {
        public static int obtenerID(string nombre)
        {
            return Commons.getInstance().getIDFrom("IDTipoDeServicio", nombre);
        }

        public static string obtenerNombre(int id)
        {
            return Commons.getInstance().getNombreFrom("NombreTipoDeServicio", id);
        }
    }
}
