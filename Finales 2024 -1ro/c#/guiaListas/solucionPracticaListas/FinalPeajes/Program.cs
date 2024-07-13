using System;

namespace FinalPeajes
{
    public struct InformacionAutos
    {
        public int numeroPase;
        public string ciudadDestino;
        public int cantidadPasajeros;
        public int cinturones;
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Encontrar una forma de dejar de cargar con 0, sin usar break;

            Console.WriteLine("Inicio del programa");


            InformacionAutos[] arrPases = new InformacionAutos[500];
            CargarArreglo(arrPases);
            MostrarArreglo(arrPases);

            //A partir de este arreglo cargado, mostrar





            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }

        public static void CargarArreglo(InformacionAutos[] array)
        {
            Console.WriteLine("Carga de arreglo pases");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Nuevo pase; ingrese 0 para dejar de cargar");
                array[i].numeroPase = int.Parse(Console.ReadLine());
                if (array[i].numeroPase == 0)
                    break;      //como se puede hacer sin break? ver
                Console.WriteLine(" ciudad destino: ");
                array[i].ciudadDestino = Console.ReadLine();
                Console.WriteLine(" cantidad pasajeros: ");
                array[i].cantidadPasajeros = int.Parse(Console.ReadLine());
                Console.WriteLine(" cantidad cinturones de seguridad: ");
                array[i].cinturones = int.Parse(Console.ReadLine());
                Console.WriteLine("Se inserto el pase numero " +  "[ "+i+" ]" );
                Console.WriteLine();
                
            }
            Console.WriteLine("Carga terminada");
            
            
        }

        public static void MostrarArreglo(InformacionAutos[] array)
        {
            Console.WriteLine("Informacion de arreglos:");
            Console.WriteLine();
            for (int i = 0; i < array.Length && array[i].ciudadDestino != null; i++)
            {
                Console.WriteLine("Nro Pase: " + array[i].numeroPase);
                Console.WriteLine("Destino : " + array[i].ciudadDestino);
                Console.WriteLine("Pasajeros: " + array[i].cantidadPasajeros);
                Console.WriteLine("Cantidad Cinturones : " + array[i].cinturones + "\n" +
                    "   --  --  --  --  --  --  --  ");
                
                Console.WriteLine("");


            }
        }

        
            
        
    }
}
