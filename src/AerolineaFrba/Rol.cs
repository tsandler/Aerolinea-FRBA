using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba
{
    class Rol
    {
        public static int obtenerID(string nombre)
        {
            return Commons.getInstance().getIDFrom("IDRol", nombre);
        }
    }
}
