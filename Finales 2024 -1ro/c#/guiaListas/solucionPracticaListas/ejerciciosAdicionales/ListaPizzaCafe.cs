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
            Random monto = new Random();

            bool terminoCarga;

            do
            {
                NodoPizzaCafe nuevo = new NodoPizzaCafe();
                nuevo.siguiente = null;
                nuevo.idPedido = id.Next(0, 2001);
                nuevo.montoPedido = monto.Next(5,401);

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
                    else if (nuevo.comidaSeleccionada > primero.comidaSeleccionada)// ahora si, insercion ordenada de menor a mayor por opcion de menu 
                    {
                        //  insertamos al principio
                        nuevo.siguiente = primero;
                        primero = nuevo;
                    }
                    else if (nuevo.comidaSeleccionada <= ultimo.comidaSeleccionada)
                    {
                        //insertamos al final
                        ultimo.siguiente = nuevo;
                        ultimo = nuevo;
                    }
                    else
                    {
                        //  si no lo ponemos en la punta, va al medio
                        NodoPizzaCafe actual = primero;
                                      

                        if (actual.comidaSeleccionada > nuevo.comidaSeleccionada && actual.siguiente.comidaSeleccionada <= nuevo.comidaSeleccionada)
                        {

                            nuevo.siguiente = actual.siguiente;
                            actual.siguiente = nuevo;
                        }
                        else
                            actual = actual.siguiente;
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
                Console.WriteLine("Informacion de lista pedidos: ");
                Console.WriteLine();
                while (actual != null)
                {
                    Console.WriteLine("Id pedido: " + actual.idPedido);
                    Console.WriteLine("Nombre del cliente: " + actual.nombreCliente);
                    Console.WriteLine("Comida seleccionada: " + actual.comidaSeleccionada);
                    Console.WriteLine("Monto del pedido: " + actual.montoPedido);
                    Console.WriteLine(" -   -   -   -   -   -   -   -   -   -   -   -");
                    Console.WriteLine();
                    actual = actual.siguiente;
                }
            }
            else
                Console.WriteLine("Lista vacia");
        }

        public void VerificarPedido(int idBuscado) // buscar
        {
            int cont = 0;
            NodoPizzaCafe actual = primero;
            bool encontrado;


            if (primero!=null)
            {
                encontrado = false;
                
                while (actual!=null && encontrado == false)
                {
                    if (actual.idPedido == idBuscado)
                    {
                        Console.WriteLine($"Se encontro el pedido en el nodo n° [ {cont} ] de la lista \n" +
                            $"Id: {actual.idPedido}, | Nombre del cliente : {actual.nombreCliente} | \n" +
                            $"Opcion menú : {actual.comidaSeleccionada} ");
                        encontrado = true;

                    }
                    else
                    {
                        actual = actual.siguiente;
                        cont++;
                    }                       

                    if(actual == null)
                        Console.WriteLine("No se pudo encontrar el elemento en la lista");

                }
                
            }
            else
                Console.WriteLine("Lista vacia");
        }

        public void ObtenerPromedio() //me
        {
            NodoPizzaCafe actual = primero;
            double suma = 0;
            int cont = 0;

            if (primero!= null)
            {
                cont++; 

                while (actual != null)
                {
                    suma += actual.montoPedido;
                    cont++;
                    actual = actual.siguiente;
                }
                if (actual == null)
                {
                    double promedio = (suma / cont);

                    Console.WriteLine($" La suma de todos los pedidos es de:   ${suma} \n" +
                        $" hoy los clientes gastaron : ${promedio} en promedio "); //promedio sus
                }
            }
            else
                Console.WriteLine("Lista vacia");
        }


        public void EliminarPedido(int idAEliminar)
        {
            NodoPizzaCafe actual = primero;
            NodoPizzaCafe anterior;

            if (primero == null)
            {
                Console.WriteLine("No se puede recorrer la lista de pedidos; está vacia");
            }
            else if (primero.idPedido == idAEliminar)
            {
                primero = primero.siguiente;
            }
            else if (ultimo.idPedido == idAEliminar)
            {
                while (actual != null)
                {
                    anterior = actual;
                    actual = actual.siguiente;

                    if (actual == ultimo)
                    {
                        anterior.siguiente = null; //yo puse ultimo , en realidad es null, pq sino seguiria apuntando a un nodo que si existe
                        ultimo = anterior;
                    }

                }

            }
            else // pedido al final
            {
                bool eliminado = false;

                while (actual != null && !eliminado)
                {
                    anterior = actual;
                    actual = actual.siguiente;

                    if (actual.idPedido ==  idAEliminar)
                    {
                        anterior.siguiente = actual.siguiente;
                        eliminado = true; //probemos si se puede hacer con bool o break
                    }

                }
            }

            
        }



    }
}
