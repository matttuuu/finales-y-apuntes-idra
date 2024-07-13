using System;

namespace MainCiclos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ciclos de repeticion (while-do while-switch-bucle for-) y Scope

            //while
            int a = 5;
            string mesg = "okaaa";
            double vvv = 27.5;
            while(a <= 10)
            {
                Console.WriteLine("Valor actual= {0}",a);
                a++;
            }
            Console.WriteLine("Termino el bucle suma");


            int b = 10;
            while (b >= 3)
            {
                Console.WriteLine("Valor actual= {0}", b);
                b--;
            }
            Console.WriteLine("Termino el bucle resta");



            //do while
            int numeroIngresado;
            do
            {
                Console.WriteLine("Ingrese un numero,  si es 0 cierra el programa");
                 numeroIngresado = int.Parse(Console.ReadLine());

            } while (numeroIngresado != 0);
            Console.WriteLine("Termino el programa");


            ///

            double estatura;
            do
            {
                Console.WriteLine("Ingrese su estatura");
                estatura = Convert.ToDouble(Console.ReadLine());
                if (estatura >= 175)
                {
                    Console.WriteLine("Permitido - Altura minima: 175cm");
                }

            } while (estatura >= 175);
            
            Console.WriteLine("Termino el ciclo-altura");
            Console.WriteLine();

            ///
            double nota;
            
            do
            {
                Console.WriteLine("Ingrese el promedio-calificacion");
                nota = Convert.ToDouble(Console.ReadLine());
                if (nota <= 0 || nota > 10)
                {
                    Console.WriteLine("Nota invalida, intente de nuevo");
                }

            } while (nota <= 0 || nota > 10);

            /////Entonces, el do while primero contiene, en el do, todo el bloque de codigo que se ejecuta
            //// y despues, en el while, se evalua si se cumple esa condicion
            ///

            ///////BUCLE FOR

            string[] ArrayDeStrings = new string[4];
            

            for (int i = 0; i < ArrayDeStrings.Length; i++)
            {
                string msg;
                Console.WriteLine("ingrese string de posicion: " + (i+1)  + " / " + (ArrayDeStrings.Length));
                msg = Console.ReadLine();
                ArrayDeStrings[i] = msg;
                
            }
            Console.WriteLine("Se termino de cargar, mostrando resultados");
            for (int i = 0; i < ArrayDeStrings.Length; i++)
            {
                Console.WriteLine("pos " + (i+1) + " / " + (ArrayDeStrings.Length) + ": " + ArrayDeStrings[i]);

            }
            //////
            ///

        }
    }
}
