using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainListas
{
    class Nodo //Los nodos constituyen las listas
    {
        public string Nombre;
        public string Apellido;
        public int DNI;
        public int edad;
        public Nodo Siguiente; //Cada nodo contiene la informacion necesaria, mas un atributo "siguiente" que apunta al siguiente nodo
    }
}
