using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Lista
    {
        Nodo primero;
        Nodo ultimo;

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public void cargarLista()
        {
            Nodo nuevo = new Nodo();
            nuevo.Siguiente = null; //Pruebo con declarar que el siguiente del nuevo nodo sea null

            Console.WriteLine("Nueva materia");
            Console.WriteLine("Ingrese codigo");
            Console.WriteLine(" TSS: ");
            nuevo.cod ="TSS" + Console.ReadLine();
            Console.WriteLine(" Nombre materia: ");
            nuevo.materia = Console.ReadLine();
            Console.WriteLine(" Año:  ");
            nuevo.anio = int.Parse(Console.ReadLine());
            Console.WriteLine(" Modalidad: ");
            nuevo.modalidad = char.Parse(Console.ReadLine());
            Console.WriteLine(" cantidad Horas: ");
            nuevo.horas = int.Parse(Console.ReadLine());

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
            Console.WriteLine("Nueva materia insertada ♫ ");
            Console.WriteLine();

        }

        public void MostrarLista()
        {
            Nodo actual = primero;

            if (primero != null)
            {
                Console.WriteLine("Informacion de Lista");

                while (actual != null)
                {
                    Console.WriteLine("Codigo de materia:" + actual.cod + "\n" +
                        "Materia: " + actual.materia + "\n" +
                        "Anio: " + actual.anio + "\n" +
                        "Modalidad: " + actual.modalidad  + "\n" +
                        "Horas: " + actual.horas);
                    actual = actual.Siguiente;
                }
            }
            else
                Console.WriteLine("Lista Vacia");
        }

        public void ObtenerAnuales()
        {
            Nodo actual = primero;

            if (primero != null)
            {
                while (actual != null)
                {
                    if (actual.modalidad == 'A') //Si nos encontramos una anual, guardamos en arreglo
                    {
                        //guardar nombre año y codigo formateado

                    }
                }
            }
            else
                Console.WriteLine("Lista vacia - No se puede recorrer");
        }

    }
}
