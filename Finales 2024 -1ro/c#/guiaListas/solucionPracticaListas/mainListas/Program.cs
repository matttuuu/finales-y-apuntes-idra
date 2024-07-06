using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio del programa");
            Console.WriteLine();
            Lista l = new Lista();
            ////Archivo hecho en notebook
            ///ver despues que onda con la version ms y coso
            ///

            /////Ejercicio1 
            /// considerar lista en memoria cuyos nodos contienen: 
            /// nombre, apellido, dni, y edad
            /// 
            /// Realizar las clases necesarias y la funcionalidad para recorrer la lista y mostrar el contenido de sus elementos

            Console.WriteLine("Ingrese la cantidad de personas a ingresar:  ");
            int cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                l.cargarLista();
            }
            l.recorrerLista();

        }
    }
}
