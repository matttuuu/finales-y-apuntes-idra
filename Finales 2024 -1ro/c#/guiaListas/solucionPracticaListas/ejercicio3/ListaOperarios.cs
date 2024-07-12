using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class ListaOperarios
    {
        NodoOperarios primero;
        NodoOperarios ultimo;
        public ListaOperarios()
        {
            primero = null;
            ultimo = null;
        }

        public void CargarLista(InformacionOperario[] array) //ver como cargar una lista desde un arreglo con un for
        {
            NodoOperarios nuevo = new NodoOperarios();
            for (int i = 0; i < array.Length; i++)
            {
                nuevo.nombreOperario = array[i].nombre;
                nuevo.apellidoOperario = array[i].apellido;
                nuevo.categoriaOperario = array[i].categoria;
                nuevo.sueldoOperario = array[i].sueldo;

            }
            Console.WriteLine("Se cargo un operario");
            
        }

        public void MostrarLista()
        {
            //muestro la lista implementada por el metodo CargarLista()

            NodoOperarios actual = primero;

            if (primero != null)
            {

            }
        }
    }
}
