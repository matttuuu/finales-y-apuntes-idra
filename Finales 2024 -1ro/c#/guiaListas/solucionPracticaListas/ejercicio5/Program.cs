using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnteros l = new ListaEnteros();
            //Se tiene una lista L simple, cuyos elementos son enteros
            //desarrollar un metodo que elimine todas las apariciones de un unico valor en la lista
            // a) con lista ordenada   b) con lista no ordenada

            //primero, hagamoslo con la lista ordenada por insercion, de mayor a menor(los mas grandes al principio)

            //Con parametro
            int numero = -1;           

            //do
            //{
            //    Console.WriteLine("Numero nuevo (0 para dejar de cargar):  ");
            //    numero = int.Parse(Console.ReadLine());
            //    if (numero == 0)
            //        break; //Si no coloco esta linea, el 0 tambien se suma 
            //    l.AgregarNumero(numero);

            //} while (numero!= 0);



            while (numero != 0)
            {
                Console.WriteLine("Ingrese un numero para agregar a la lista; ingrese un 0 para dejar de cargar (metodo con parametro)");
                numero = int.Parse(Console.ReadLine());
                if (numero != 0)
                {            
                    l.AgregarNumero(numero); //esta bien pero el 0 que cierra la carga se agrega tmb
                }
                
            }



            l.MostrarLista();



            //Sin parametro
            //
            Console.WriteLine("Volvemos a cargar, pero sin parametros...");
            l.AgregarNumero();

            Console.WriteLine("Despues de cargar con el metodo sin parametros, la lista quedaria:");
            l.MostrarLista();

            Console.WriteLine("Busqueda: ingrese el id del nodo que desea buscar ");
            l.BuscarNodo(Console.ReadLine());

            Console.WriteLine("Eliminacion  de nodo: ");
            Console.WriteLine("Ingrese el id del nodo a sacar: ");
            l.EliminarNodo(Console.ReadLine());


            Console.WriteLine("(Mensaje del main:) la lista resultante es:  ");
            l.MostrarLista();
            Console.ReadKey();
        }
    }
}
