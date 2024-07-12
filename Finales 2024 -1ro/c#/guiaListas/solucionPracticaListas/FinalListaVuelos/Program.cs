using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalListaVuelos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio de programa");
            ListaVuelos l = new ListaVuelos();
            int opcion = -1;
            int vuelos;
            //Ingreso los vuelos en la lista
            Console.WriteLine("Ingrese la cantidad de vuelos a cargar");
            vuelos = int.Parse(Console.ReadLine());
            for (int i = 0; i < vuelos; i++)
            {
                l.CargarLista();
            }


            do
            {
                Console.WriteLine("Ingrese una opcion del menu: \n" +
               "1 - para tomar una reserva\n" +
               "2 - para consultar disponibilidad (listar los vuelos)\n" +
               "3 - para salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Tomar reserva: ...");
                        l.RealizarReserva();
                        break;
                    case 2:
                        Console.WriteLine("Disponibilidad");
                        l.ConsultarDisponibilidad();
                        break;
                    case 3:
                        Console.WriteLine("Salir del programa");
                        break;
                    default:
                        Console.WriteLine("Por favor, ingrese una opcion valida");
                        break;
                }

            } while (opcion != 3);




            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }

        
    }
}
