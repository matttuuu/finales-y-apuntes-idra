using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosAdicionales
{
    class ListaPizzaCafe
    {
        NodoPizzaCafe primero;
        NodoPizzaCafe ultimo;

        public ListaPizzaCafe()
        {
            primero = null;
            ultimo = null;
        }


        public void InsertarPedido()
        {
           
            Random id = new Random();
            
            bool terminoCarga;

            do
            {
                NodoPizzaCafe nuevo = new NodoPizzaCafe();
                nuevo.siguiente = null;
                nuevo.idPedido = id.Next(0, 2001);

                terminoCarga = false;


                Console.WriteLine("Ingrese su nombre: \n" +
                " escriba e ingrese 'n' para cancelar el pedido ");

                nuevo.nombreCliente = Console.ReadLine();

                if (nuevo.nombreCliente.ToUpper() != "N")
                {
                    Console.WriteLine("Seleccione una opcion del menu");
                    Console.WriteLine("1-Spaghetti\n" +
                        "2-Ensalada\n" +
                        "3-Hamburguesa\n" +
                        "4-Pizza\n" +
                        "5-Helado");

                    nuevo.comidaSeleccionada = int.Parse(Console.ReadLine());
                    if (nuevo.comidaSeleccionada > 5 || nuevo.comidaSeleccionada < 1)
                    {
                        while (nuevo.comidaSeleccionada > 5 || nuevo.comidaSeleccionada < 1)
                        {
                            Console.WriteLine("Por favor ingrese una opcion valida: ");
                            Console.WriteLine("1-Spaghetti\n" +
                                                "2-Ensalada\n" +
                                                "3-Hamburguesa\n" +
                                                "4-Pizza\n" +
                                                "5-Helado");
                            nuevo.comidaSeleccionada = int.Parse(Console.ReadLine());
                        }
                        
                    }

                    if (primero == null)
                    {
                        primero = nuevo;
                        ultimo = nuevo;
                    }
                    else // por ahora al final, dps ordenado
                    {
                        ultimo.siguiente = nuevo;
                        ultimo = nuevo;
                    }


                    Console.WriteLine("Pedido tomado!");
                }

                else
                    terminoCarga = true;

            } while (terminoCarga != true);
           

        }

        public void MostrarListaPedidos()
        {
            NodoPizzaCafe actual = primero;
            if (primero != null)
            {
                while (actual != null)
                {
                    Console.WriteLine("Id pedido: " + actual.idPedido);
                    Console.WriteLine("Nombre del cliente: " + actual.nombreCliente);
                    Console.WriteLine("Comida seleccionada: " + actual.comidaSeleccionada);
                    Console.WriteLine(" -   -   -   -   -   -   -   -   -   -   -   -");
                    Console.WriteLine();
                    actual = actual.siguiente;
                }
            }
            else
                Console.WriteLine("Lista vacia");
        }
    }
}
