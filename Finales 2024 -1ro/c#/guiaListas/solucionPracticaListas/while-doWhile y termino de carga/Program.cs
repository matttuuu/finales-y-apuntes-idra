using System;

namespace while_doWhile_y_termino_de_carga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("diferentes estructuras: while y do while con temrino de carga  indicado por 0");


            list l = new list();


            ////while if
            //int[] ArregloNumeros = new int[3];
            //int num = -1;       

            //for (int i = 0; i < ArregloNumeros.Length && num != 0 ; i++)
            //{
            //    Console.WriteLine($"Indique numero a guardar en el arreglo en la posicion n° {i} /de {ArregloNumeros.Length} del arreglo\n" +
            //        $" ingrese '0'   para dejar de cargar");

            //    num = int.Parse(Console.ReadLine());
            //    if (num == 0)
            //    {
            //        break;
            //    }
            //    ArregloNumeros[i] = num;
            //}

            ////muestro  el arreglo
            //Console.WriteLine("Info  de arreglo");
            //for (int i = 0; i < ArregloNumeros.Length; i++)
            //{
            //    Console.WriteLine($"Pos {i} : [ {ArregloNumeros[i]} ]\n" +
            //        $" ");

            //}

            int datoAInsertar = -1;

            Console.WriteLine($"Ingrese un numero nuevo para insertar a la lista\n" +
                $" ( Ingrese un '0' para dejar de cargar  y mostrar la lista) ");
            

            while (datoAInsertar != 0)
            {
                int cont = 0; 

                Console.WriteLine($"ingrese numero para el nuevo nodo; o ingrese '0' para fin de carga");

                datoAInsertar = int.Parse(Console.ReadLine());

                if (datoAInsertar != 0)
                {
                    l.Insertar(datoAInsertar);
                    
                }
                


            }
            l.Listar();




            Console.WriteLine("---------------------------------\n" +
                "");
            Console.WriteLine("do while");
            Console.WriteLine();



            int dato = -1;
            bool finDeCarga = false;
            //y con do while?
            do //recordemos que el do while hace primero y despues evalúa
            {
                Console.WriteLine("Ingrese un numero para guardar");
                dato = int.Parse(Console.ReadLine());

                if (dato != 0)
                {
                    l.Insertar(dato);
                }
                else
                {
                    Console.WriteLine("Se termino de cargar datos, con do while");
                    finDeCarga = true;
                    
                }
                    

            } while (dato !=0 && finDeCarga == false);




            l.Listar();

            

            Console.WriteLine("Fin del programa");
            Console.ReadKey();

            //:D
        }

    }

}
