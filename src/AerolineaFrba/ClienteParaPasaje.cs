using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba
{
    public partial interface ClienteParaPasaje
    {
        void cargarCliente(int id, string dni, string nombre, string apellido, string direccion, string telefono, string mail, string fecha);
    }
}
