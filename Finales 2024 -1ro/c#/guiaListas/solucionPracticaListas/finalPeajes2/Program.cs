using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalPeajes2
{
    public struct Autos
    {
        public int nroPase;
        public string ciudadDestino;
        public int cantidadDePasajeros;
        public int cantidadDeCinturones;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio del programa");

            Lista l = new Lista();
            int paseMin, paseMax;
            Autos[] arrPases = new Autos[500];
            CargarArreglo(arrPases);
            MostrarArreglo(arrPases);
            Console.WriteLine(" -- Ingrese los numeros de pases correspondientes para el rango de infracciones -- " + "\n" +
                "Pase minimo: ");
            paseMin = int.Parse(Console.ReadLine());
            Console.WriteLine("Pase maximo: ");
            paseMax = int.Parse(Console.ReadLine());

            l.MostrarLista();//Si esto no muestra nada, puede que sea porque la instancia de lista es distinta a la que se crea del metodo


            Console.ReadKey();
        }

        public static void CargarArreglo(Autos[] array)
        {
            int cont = 0;
            bool finCarga = false;

            do
            {
                Console.WriteLine("Ingrese num° de pase; ingrese '0' para dejar de cargar");
                array[cont].nroPase = int.Parse(Console.ReadLine());

                if (array[cont].nroPase != 0)
                {
                    Console.WriteLine(" Ingrese ciudad de destino: ");
                    array[cont].ciudadDestino = Console.ReadLine();
                    Console.WriteLine(" Ingrese cantidad de pasajeros: ");
                    array[cont].cantidadDePasajeros = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Cinturones del vehiculo: ");
                    array[cont].cantidadDeCinturones = int.Parse(Console.ReadLine());
                    
                }
                else                
                    finCarga = true;
                
                
                Console.WriteLine("Pase cargado");
                cont++;

            } while (finCarga == false);
            Console.WriteLine("Carga terminada");

        }


        public static void MostrarArreglo(Autos[] array)
        {
            Console.WriteLine("Info de pases: ");
            Console.WriteLine();
            for (int i = 0; i < array.Length && array[i].nroPase != 0; i++)
            {
                Console.WriteLine("N° PASE: " + array[i].nroPase + "\n" +
                    "DESTINO: " + array[i].ciudadDestino + "\n" +
                    "CANTIDAD PASAJEROS: " + array[i].cantidadDePasajeros + "\n" +
                    "CINTURONES DEL VEHICULO: " + array[i].cantidadDeCinturones );
                Console.WriteLine(" -- -- -- -- -- -- -- -- -- -- -- ");
                Console.WriteLine();

            }
        }

        public static void RecorrerArreglo(Autos[] array, int min, int max)
        {
            Lista l = new Lista();
            

            for (int i = 0; i < array.Length; i++)
            {
                string ciudad;
                int cantInfracciones = 0;
                if (array[i].nroPase >= min && array[i].nroPase <= max)
                {

                    //Evaluo - ¿Esta en infracción? (mas pasajeros que cinturones)
                    if (array[i].cantidadDePasajeros > array[i].cantidadDeCinturones)
                    {
                        ciudad = array[i].ciudadDestino;
                        for (int j = 0; j < array.Length; j++)
                        {
                            if (array[j].ciudadDestino == ciudad.ToUpper() && array[j].cantidadDeCinturones < array[j].cantidadDePasajeros )
                            {
                                cantInfracciones++;
                            }
                        }

                        l.AgregarALista(ciudad, cantInfracciones);
                    }

                }
            }
        }


    }
}
