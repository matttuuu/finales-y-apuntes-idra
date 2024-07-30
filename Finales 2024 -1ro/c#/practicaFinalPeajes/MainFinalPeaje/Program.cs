using System;

namespace MainFinalPeaje
{
   
    class Program
    {
        public struct Pases
        {
            public int numeroPase;
            public string ciudadDestino;
            public int cantidadPasajeros;
            public int cantidadCinturones;
        }
        static void Main(string[] args)
        {
            Lista l = new Lista();
            Pases[] arrPases = new Pases[500];
            Console.WriteLine("Inicio de programa.");
            CargarArreglo(arrPases);
            MostrarArreglo(arrPases);

            Console.WriteLine("Ingrese los numeros de pases minimo y maximo\n" +
                "Pase minimo: ");
            int paseMin = int.Parse(Console.ReadLine());
            Console.WriteLine("Pase maximo: ");
            int paseMax = int.Parse(Console.ReadLine());

            ChequearInfracciones2(arrPases, paseMin, paseMax, l); // NO ESTABA PROBANDO EL EMTODO JADSJAJAJA
            l.MostrarLista();







            Console.ReadKey();
        }



        static void CargarArreglo(Pases[] array)
        {
            bool finDeCarga = false;
            int i = 0;
            Console.WriteLine("Carga de arreglo de pases\n" +
                "");
            do
            {
                int nPase;
                string destino;
                int pasajeros;
                int cinturones;

                Console.WriteLine($" Ingrese el numero de pase para la posicion de arreglo [ {i} ] \n" +
                    $" (Ingrese 0 en este punto para dejar de cargar )");
                 nPase = int.Parse(Console.ReadLine());

                if (nPase != 0)
                {
                    Console.WriteLine(" Ingrese ciudad de destino ");
                    destino = Console.ReadLine();
                    Console.WriteLine("Ingrese cantidad de pasajeros ");
                    pasajeros = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese cantidad de cinturones del vehiculo");
                    cinturones = int.Parse(Console.ReadLine());

                    array[i].numeroPase = nPase;
                    array[i].ciudadDestino = destino;
                    array[i].cantidadPasajeros = pasajeros;
                    array[i].cantidadCinturones = cinturones;
                }
                else
                {
                    finDeCarga = true;
                }

                
                Console.WriteLine("Info de pase cargada\n" +
                    "");
                i++;

            } while (finDeCarga != true);
        }

        public static void MostrarArreglo(Pases[] arrPases)
        {
            Console.WriteLine("Info de arreglo:");

            for (int i = 0; i < arrPases.Length && arrPases[i].numeroPase != 0; i++)
            {
                Console.WriteLine($"Pase N° {arrPases[i].numeroPase} \n" +
                    $"  DESTINO: {arrPases[i].ciudadDestino} \n" +
                    $"  C PASAJEROS {arrPases[i].cantidadPasajeros}\n" +
                    $"  C CINTURONES {arrPases[i].cantidadCinturones}\n" +
                    $"\n" +
                    $"____________________");
                
            }

        }

        public static void ChequearInfracciones(Pases[] arrPases, int min, int max, Lista lista ) //verifica y si encuentra infracciones, llama a otro metodo que las inserta (y tambien otro que chequee si exista la ciudad con bool para no poner cosas repetidas JAJJSAJAJASJSAJSA)
        {
            string ciudadActual = "";//"agarro" la ciudad en la  que este;
            int infracciones = 0;

            for (int i = 0; i < arrPases.Length && arrPases[i].numeroPase != 0; i++) // primer for para el arreglo
            {

                if (arrPases[i].numeroPase <= max  && arrPases[i].numeroPase >= min && arrPases[i].cantidadCinturones < arrPases[i].cantidadPasajeros)//esta en infraccion
                {
                    ciudadActual = arrPases[i].ciudadDestino; // la idea basica es: esta en infraccion? entonces volve a recorrer el  arreglo y sumale todas las infracciones que encuentres
                    infracciones = 1;

                    //for (int j = i; j < arrPases.Length; j++) // segundo for para recorrer todo el arreglo con la misma ciudad 



                    //    //Y  SI HAGO A  J EMPEZAR DESDE  I? // bajó  1  solo  (5 en vez de 6)
                    //{
                    //    if (arrPases[j].ciudadDestino == ciudadActual && arrPases[j].cantidadCinturones < arrPases[j].cantidadPasajeros)//
                    //    {
                    //        infracciones++;
                    //    }


                    //}

                    if (lista.CiudadExiste(ciudadActual) == true) 
                    {
                        lista.ActualizarInfraccion(ciudadActual); // intento de nueva logica en el metodo de abajo :P
                        
                    }
                    else
                    {
                        lista.InsertarInfraccion(ciudadActual, infracciones);
                    }






                    //he logrado  insertar con la cantidad justa de infracciones, peeeero
                    //todavia  me falta insertar ordenado, y ese punto lo se hacer, pero es complicado  cuando tengo que recorrer e insertar al mismo tiempo

                    //resumo
                    // 1. se que cada ciudad debe estar con su nombre y cantidad de infracciones 1 sola vez,
                    // para que me de la posibilidad de insertar ordenado de mayor a menor cant infracciones

                    //de otra manera (al actualizar una ciudad existente), no tengo la posibilidad de controlar el orden 

                }

                

            }

        }

        public static void ChequearInfracciones2(Pases[] arrPases, int min, int max, Lista lista)
        {
            //hagamos esto:

            //recorramos el arreglo entero  cada ciclo que demos para poder juntar toda la informacion necesaria acerca de la ciudad y su cantidad de infractores
            //Para eso: necesito:

            //1-Agarrar la ciudad de la posicion uno, verificar si esta en infraccion: en caso de estarlo, agarrar esa ciudad para
            // recorrer toooodo el arreglo para juntar su respectiva cantidad de informaciones
            // (ignorar la ciudad si ya existe en la lista-puedo usar ciudadExiste())

            //2-Para que sea  ordenada, la insercion debe ser al final de todo; 
            // ~ al hacer esto tecnicamente debe cambiar la logica de como uso el actualizar infraccion

            string ciudadActual = "";
            


            for (int i = 0; i < arrPases.Length && arrPases[i].numeroPase != 0; i++) //for  para   recorrer el arreglo (agarrar cada ciudad)
            {
                ciudadActual = arrPases[i].ciudadDestino;
                int infraccionesTotales = 0;

                if (arrPases[i].numeroPase <= max && arrPases[i].numeroPase >= min && arrPases[i].cantidadCinturones < arrPases[i].cantidadPasajeros)
                {
                    for (int j = 0; j < arrPases.Length && arrPases[j].numeroPase != 0; j++)//segundo for para   recorrer el arreglo entero con la ciudad y sumar infracciones
                    {
                        if (arrPases[j].cantidadPasajeros > arrPases[j].cantidadPasajeros && lista.CiudadExiste(ciudadActual) != true) // si esta en infraccion Y si no existe ya en la lista
                        {
                            infraccionesTotales++; /// revisar cantidad de inracciones 
                                                    
                        }
                    }
                    lista.InsertarInfraccion(ciudadActual,infraccionesTotales);
                }



                
            }
            
        }




    }

    
}

