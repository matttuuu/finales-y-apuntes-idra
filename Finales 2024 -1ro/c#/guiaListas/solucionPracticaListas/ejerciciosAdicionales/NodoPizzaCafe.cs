using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosAdicionales
{
    class NodoPizzaCafe //Cada nodo, es un pedido distinto
    {
        public int idPedido;
        public string nombreCliente;

       
        public int comidaSeleccionada;
        public NodoPizzaCafe siguiente;
    }
}
