using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba
{
    class MedioDePago
    {
        public static int obtenerID(string nombre)
        {
            return Commons.getInstance().getIDFrom("IDMedioDePago", nombre);
        }
    }
}
