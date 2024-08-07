using System;

namespace Main
{
    public struct DetallesPersonas
    {
        public string username;
        public string email;
        public int edad;
        public int id_pk; //para el ej de llenar arreglo, a este lo hago autoincremental para no tener que escribir tanto.
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Para concluir, planeo escribir todo lo que se acerca de listas, menues y ciclos while 
            //Uso una clase nodo y una lista

            Lista l = new Lista();
            ListaPersona lp = new ListaPersona();


            //Empezaremos con un menu, para que el usuario pueda seleccionar su opcion
            //Este menu se compone con un switch-case dentro de un do-while
            Console.WriteLine("Inicio del programa\n" +
                "\n" +
                "Bienvenido al menu, seleccione una opcion para testear funcionalidades");
            Console.WriteLine();

            int opc = -1;

            do
            {
                Console.WriteLine("Menu: Seleccione una opción de funcionalidad\n" +
                    " (Ingrese '0' para salir del menú ) ");
                Console.WriteLine();
                Console.WriteLine("\n" +
                    "1----  -Insertar persona\n" +
                    "2----  -Insertar persona pero indicando fin de carga\n" +
                    "3----  -Mostrar la lista creada hasta el momento\n" +
                    "4----  -Buscar persona\n" +
                    "5----  -Borrar persona de la lista\n" +
                    "6----  -Verificar si existe la persona\n" +
                    "7----  -Llenar arreglo y crear lista en base a este (y mostrar despues)");
                Console.WriteLine("_    _    _    _    _    _    _\n" +
                    "");

                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        string nombre;
                        int id;
                        Console.WriteLine("Ingrese el id de un nuevo usuario: (no 0)");
                        id = int.Parse(Console.ReadLine());
                        if (id == 0)
                        {
                            while (id == 0)
                            {
                                Console.WriteLine("Por favor ingrese otro id que no sea 0 ~");
                                id = int.Parse(Console.ReadLine());
                            }
                        }
                        Console.WriteLine("Ingrese nombre ");
                        nombre = Console.ReadLine();
                        l.Insertar(id,nombre);
                        Console.WriteLine("Se insertó la persona");
                        Console.WriteLine();
                        break;

                    case 2:
                        l.InsertarConFinDeCarga();
                        break;

                    case 3:
                        l.MostrarLista();
                        break;
                    case 4:
                        l.BuscarPersona();
                        break;
                    case 5:
                        l.EliminarPersona();
                        break;

                    case 6:
                        Console.WriteLine("Coming soon! ");
                        //l.ChequearPersonaExistente();
                        break;

                    case 7:
                        Console.WriteLine("Ingrese la longitud del arreglo");
                        int cardinalidad = int.Parse(Console.ReadLine());

                        if (cardinalidad <= 0)
                        {
                            while (cardinalidad <= 0)
                            {
                                Console.WriteLine(" La cardinalidad no puede ser igual o menor a 0\n" +
                                    " Por favor, ingrese un numero valido ");
                                cardinalidad = int.Parse(Console.ReadLine());
                            }
                        }

                        DetallesPersonas[] arregloUsuariosOnline = new DetallesPersonas[cardinalidad];

                        CargarArreglo(arregloUsuariosOnline, lp); // y nos vamos hacia este medoto...


                        break;


                    default:
                        Console.WriteLine("Por favor, ingrese una opcion valida:");
                        break;
                }

            } while (opc != 0 /*Puede ser 0 o el numero que quieras*/);


            Console.WriteLine("Fin de programa");
            Console.ReadKey();
        }

        

        public static void CargarArreglo(DetallesPersonas[] arreglo,ListaPersona l) 
        {
            /*Recordar que si no tengo cardinalidad (longitud/cantidad) de antemano,
             siempre puedo cargar un arreglo con una longitud re grande hasta que el usuario corte con 0 o algun caracter*/
            bool finDeCarga = false;

          

            for (int i = 0; i < arreglo.Length && finDeCarga != true; i++)
            {

                arreglo[i].id_pk = (i + 1); // podria agregar logica de cancelar con    usuario 'n', aunque me dejaria  espacios vacios en el array (despues puedo elegir no mostrarlos igual :P)

                Console.WriteLine($" Ingrese username para el usuario de posicion [ {i} ] del array \n" +
                    $" ((Ingrese 'n' en este punto  para dejar de cargar)) ");
                arreglo[i].username = Console.ReadLine();

                if (arreglo[i].username.ToUpper() != "N"  )
                {
                    Console.WriteLine(" Ingrese correo electronico ");
                    arreglo[i].email = Console.ReadLine();
                    Console.WriteLine(" Ingrese la edad del usuario ");
                    arreglo[i].edad = int.Parse(Console.ReadLine());

                    l.InsertarEnLista(arreglo[i].id_pk, arreglo[i].edad, arreglo[i].username, arreglo[i].email); //llamo al metodo de LISTAPERSONAS  para crear la  lista

                    Console.WriteLine("Persona cargada\n" +
                        " \n" +
                        "___  ___  ___  ___\n" +
                        "");
                }
                else
                {
                    finDeCarga = true;
                }
                
                
            }

            MostrarArreglo(arreglo, l); // ya uso este metodo para que me muestre el arreglo :)P

        }


        public static void MostrarArreglo(DetallesPersonas[] arreglo,  ListaPersona lp)
        {
            Console.WriteLine("Info de arreglo:");

            for (int i = 0; i < arreglo.Length && arreglo[i].id_pk != 0; i++) // mostramos mientras  no pasemos longitud ni encontremos 0
            {
                Console.WriteLine($" Nombre de usuario : {arreglo[i].username}\n" +
                    $" Id : {arreglo[i].id_pk} \n" +
                    $" Edad : {arreglo[i].edad} \n" +
                    $" Correo Electronico {arreglo[i].email}");
                Console.WriteLine("__   ___   __   ___   __   ___\n" +
                    "");
            }

            int opc;
            Console.WriteLine("Desea mostrar la informacion de la lista generada a partir del arreglo?\n" +
                " 1:Si / 2:No");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    lp.MostrarLista();
                    break;

                case 2:
                    Console.WriteLine("Metodo finalizado");
                    break;
                default:
                    Console.WriteLine("Por favor ingrese una opcion valida la proxima vez");
                    break;
            }



        }


    }

}
