using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalStockLau_Notebook
{
    public struct Productos
    {
        public int codigo;
        public string nombre_producto;
        public double precio_producto;
        public int stock_producto;
    }

    class Program
    {
       


        static void Main(string[] args)
        {
            Lista l = new Lista();
            int opcion = -1;
            Productos p = new Productos();


            Console.WriteLine("SISTEMA STOCK");
            do
            {
                
                Console.WriteLine($"Ingrese una opcion para administrar la lista de productos\n" +
                    $"----1 - Agregar productos\n" +
                    
                    
                    $"----2 - Listar lista de productos guardados\n" +
                    $"----3 - Actualizar stock de producto\n" +
                    $"----4 - Buscar producto(coming soon!)\n" +
                    $"----5 - Mostrar por codigo ");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        ValidarProducto(l);
                        break;

                    case 2:
                        l.VisualizarProductos();
                        break;

                    case 3:
                        l.ActualizarStock();
                        break;

                    case 4:
                        break;

                    case 5:
                        l.MostrarPorCodigo();
                        break;

                    case 6:
                        l.BorrarProducto();
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }

            } while (opcion != 0);

            








            

            Console.ReadKey();
        }

        public static void ValidarProducto(Lista lista)
        {

          


            Productos producto = new Productos(); // instancia de struct 


            Console.WriteLine("Informacion de nuevo producto");
            Console.WriteLine("Codigo de producto: ");
            producto.codigo = int.Parse(Console.ReadLine());
            if (lista.CodigoEsUnico(producto.codigo) == true)
            {
                while (lista.CodigoEsUnico(producto.codigo) == true)
                {
                    Console.WriteLine("El codigo ingresado ya existe\n" +
                        "Por favor, ingrese otro");
                    producto.codigo = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Ingrese nombre del producto");
            producto.nombre_producto = Console.ReadLine();
            Console.WriteLine("Ingrese Precio del producto");
            producto.precio_producto = double.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad en stock actual: ");
            producto.stock_producto = int.Parse(Console.ReadLine());

            lista.RegistrarProducto(producto);

        }

    }
}
