using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalStockLau
{
    class Nodo
    {
        public string nombreProducto;
        public int codigo; //debe ser unico para cada producto
        public double precio;
        public int cantidadEnStock;
        public Nodo siguiente;
    }
}
