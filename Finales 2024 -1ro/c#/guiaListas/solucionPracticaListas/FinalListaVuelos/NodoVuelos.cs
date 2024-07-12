using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalListaVuelos
{
    class NodoVuelos
    {
        public string codVuelo;
        public int codCiudadDestino;
        public string nombreCiudadDestino;
        public int asientosTotales;
        public int asientosDisponibles;
        public string tomadoresDeReservas;

        public NodoVuelos siguiente;
    }
}
