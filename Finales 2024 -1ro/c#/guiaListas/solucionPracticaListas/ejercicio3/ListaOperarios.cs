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
            nuevo.siguiente = null;
          
            nuevo.nombreOperario = array[0].nombre;
            nuevo.apellidoOperario = array[0].apellido;
            nuevo.categoriaOperario = array[0].categoria;
            nuevo.sueldoOperario = array[0].sueldo;

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
            
            Console.WriteLine("Se cargo un operario");
            
        }

        public void MostrarLista()
        {
            //muestro la lista implementada por el metodo CargarLista()

            NodoOperarios actual = primero;

            if (primero != null)
            {
                while (actual != null)
                {
                    Console.WriteLine("Nombre: " + actual.nombreOperario + "\n" +
                        "Apellido: " + actual.apellidoOperario + "\n" +
                        "Categoria: "  + actual.categoriaOperario + "\n" +
                        "Sueldo: " + actual.sueldoOperario);
                    actual = actual.siguiente;
                }
            }
            else
                Console.WriteLine("La lista esta vacia");
        }
    }
}
