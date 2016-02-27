using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba
{
    class Funcionalidad
    {
        public static int obtenerID(string descripcion)
        {
            return Commons.getInstance().getIDFrom("IDFuncionalidad", descripcion);
        }

    }

}
