using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainListas
{
    class Lista
    {
        Nodo Primero;
        Nodo Ultimo;

        public Lista() //Constructor
        {
            Primero = null; //Cada vez que se crea una nueva instancia de lista
            Ultimo = null; //se inicializan estos punteros en null. Utilizamos estos punteros basicos para movenos entre la lista
        }

        public void cargarLista()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Ingrese informacion de nuevo nodo");
            Console.WriteLine(" Nombre: ");
            nuevo.Nombre = Console.ReadLine();
            Console.WriteLine( " Apellido: ");
            nuevo.Apellido = Console.ReadLine();
            Console.WriteLine(" Edad: ");
            nuevo.edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" N° DNI: ");
            nuevo.DNI = Convert.ToInt32(Console.ReadLine());

            if (Primero == null) //Si la lista esta vacia, insertamos y hacemos que los punteros apunten a nuevo
            {
                Primero = nuevo;//
                nuevo.Siguiente = null; //Esta linea tambien puede colocarse al principio de la funcion, para no tener que colocarla despues
                Ultimo = nuevo;
            }
            else //Si no, insertamos al final
            {
                Ultimo.Siguiente = nuevo;//1
                nuevo.Siguiente = null;
                Ultimo = nuevo;//2
            }
            /* else ////Insercion al principio
             {
                 nuevo.Siguiente = null;
                 Primero = nuevo;
             }*/
            Console.WriteLine("Se inserto un nuevo nodo");

        }

        public void recorrerLista()
        {
            Nodo actual = Primero;

            if (Primero != null)
            {
                Console.WriteLine(" Informacion de Lista ");
                while (actual != null)
                {
                    Console.WriteLine("Nombre: " + actual.Nombre + "\n" +
                        "Apellido: " + actual.Apellido+ " \n" +
                        "Edad: " +actual.edad + "\n" +
                        "DNI: " + actual.DNI + "--- --- --- ---"  );
                    Console.WriteLine();
                    actual = actual.Siguiente;
                }
            }
            else
                Console.WriteLine("La lista esta vacia");
            
        }


    }
}
