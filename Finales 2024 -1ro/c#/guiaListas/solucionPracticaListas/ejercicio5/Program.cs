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

            Console.WriteLine("Ingrese cada numero para agregar a la lista; ingrese 0 para dejar de cargar y mostrar la lista");

            do
            {
                Console.WriteLine("Numero nuevo (0 para dejar de cargar):  ");
                numero = int.Parse(Console.ReadLine());
                if (numero == 0)
                    break; //Si no coloco esta linea, el 0 tambien se suma 
                l.AgregarNumero(numero);
                
            } while (numero!= 0);

            //while (numero != 0)
            //{
            //    Console.WriteLine("Ingrese numero: 0 para dejar de cargar");
            //    numero = int.Parse(Console.ReadLine());
            //    l.AgregarNumero(numero); //esta bien pero el 0 que cierra la carga se agrega tmb
            //}


            l.MostrarLista();



            //Sin parametro
            //...
        }
    }
}
