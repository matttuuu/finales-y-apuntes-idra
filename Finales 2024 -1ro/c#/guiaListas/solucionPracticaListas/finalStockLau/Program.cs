using System;

namespace finalStockLau
{
    class Program
    {
        static void Main(string[] args)
        {
            //Consigna: la que esta en la foto
            Lista l = new Lista();

            Console.WriteLine("Inicio de programa stock");
            l.RegistrarProducto();
            l.MostrarLista();










            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }
    }
}
