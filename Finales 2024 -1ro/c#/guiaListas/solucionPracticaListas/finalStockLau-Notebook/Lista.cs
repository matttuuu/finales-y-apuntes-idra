using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalStockLau_Notebook
{
    class Lista
    {
        Nodo primero;
        Nodo ultimo;

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public void RegistrarProducto(Productos producto) // insertar nodo en la lista (mayor a menor) ///en este caso lo  hago con una instancia de struct,no con array en si :P
        {

            Nodo nuevo = new Nodo();
            nuevo.siguiente = null;

            nuevo.codigoProducto = producto.codigo;
            nuevo.nombreProducto = producto.nombre_producto;
            nuevo.precioProducto = producto.precio_producto;
            nuevo.cantidadEnStock = producto.stock_producto;

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else if (nuevo.codigoProducto > primero.codigoProducto)
            {
                nuevo.siguiente = primero;
                primero = nuevo;
            }
            else if (nuevo.codigoProducto <= ultimo.codigoProducto)
            {
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
            else // si no esta al principio o al final, debemos insertarlo en el medio
            {
                Nodo actual = primero; //5532

                while (actual!=null)
                {
                    if (actual.codigoProducto > nuevo.codigoProducto && actual.siguiente.codigoProducto <= nuevo.codigoProducto)
                    {
                        nuevo.siguiente = actual.siguiente;
                        actual.siguiente = nuevo;

                        break;

                    }
                    else
                        actual = actual.siguiente;

                }
                
            }
            


            ///////////////otra manera/////////////////
            ///


            //bool terminoCarga;

            //do
            //{
            //    Nodo nuevo = new Nodo();
            //    nuevo.siguiente = null;

            //    terminoCarga = false;

            //    Console.WriteLine(" 1/4 | Ingrese el codigo del producto a guardar\n" +
            //        "indique 0 en este punto para dejar de cargar");
            //    nuevo.codigoProducto = int.Parse(Console.ReadLine());

            //    if (nuevo.codigoProducto != 0)
            //    {
            //        if (CodigoEsUnico(nuevo.codigoProducto) == true)
            //        {
            //            while (CodigoEsUnico(nuevo.codigoProducto) == true)
            //            {
            //                Console.WriteLine("Por favor, ingrese un codigo que no exista en la lista");
            //                nuevo.codigoProducto = int.Parse(Console.ReadLine());
            //            }
            //        }

            //        //seguimos...
            //        Console.WriteLine(" 2|4  Nombre del producto: ");
            //        nuevo.nombreProducto = Console.ReadLine();
            //        Console.WriteLine(" 3|4 Precio del producto: ");
            //        nuevo.precioProducto = double.Parse(Console.ReadLine());
            //        Console.WriteLine(" 4|4 Stock disponible: ");
            //        nuevo.cantidadEnStock = int.Parse(Console.ReadLine());

            //        if (primero == null)
            //        {
            //            primero = nuevo;
            //            ultimo = nuevo;
            //        }
            //        else
            //        {
            //            ultimo.siguiente = nuevo;
            //            ultimo = nuevo;
            //        }

            //    }
            //    else
            //    {
            //        terminoCarga = true;
            //    }

            //} while (terminoCarga != true);



        }

  
        public void VisualizarProductos() //mostrar lista
        {
            Nodo actual = primero;
            Console.WriteLine("Informacion de productos: ");

            if (primero != null)
            {
                while (actual != null)
                {
                    Console.WriteLine($"Nombre producto : {actual.nombreProducto}\n" +
                        $"Codigo: | {actual.codigoProducto} |\n" +
                        $"Precio : {actual.precioProducto }\n" +
                        $"Cantidad en stock : {actual.cantidadEnStock}");
                    Console.WriteLine();
                    actual = actual.siguiente;
                }
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }

        }

        public bool CodigoEsUnico(int CodigoABuscar) //si esto devuelve true, es pq el codigo existe, y por lo tanto se deberia ingresar otro
        {
            bool existe = false;

            Nodo actual = primero;

            while (actual != null && existe != true)
            {
                if (actual.codigoProducto == CodigoABuscar)
                {
                    existe = true;
                }
                actual = actual.siguiente;
            }
            if (actual == null)
            {
                existe = false;
            }

            return existe;
        }

        public void ActualizarStock () //metodo que permite elegir entre agregar o restar el stock de un producto de la lista
        {
            Nodo actual = primero;
            Console.WriteLine("Ingrese el id del producto del cual modificar stock...");
            int codigoABuscar = int.Parse(Console.ReadLine());
            bool finModificacion = false;

            while (actual != null && finModificacion != true)
            {
                if (actual.codigoProducto == codigoABuscar)
                {
                    int opcion = -1;
                    Console.WriteLine("Producto encontrado\n" +
                        "¿Que desea hacer?\n" +
                        "-1 -- Agregar Stock\n" +
                        "-2 -- Quitar Stock");

                    opcion = int.Parse(Console.ReadLine());

                    do
                    {
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Agregar stock (1)\n" +
                                    $"Stock Actual del producto: {actual.cantidadEnStock} \n" +
                                    $"\n" +
                                    $"Ingrese la cantidad a sumar");
                                int plusStock = int.Parse(Console.ReadLine());
                                actual.cantidadEnStock += plusStock;
                                Console.WriteLine("Stock Agregado");

                                finModificacion = true;
                                break;

                            case 2:
                                Console.WriteLine("Quitar stock (2)\n" +
                                    $"Stock actual del producto: {actual.cantidadEnStock} \n" +
                                    $"\n" +
                                    $"Ingrese una cantidad menor (o igual) a restar del stock");
                                int minusStock = int.Parse(Console.ReadLine());
                                if (minusStock > actual.cantidadEnStock)
                                {
                                    while (minusStock > actual.cantidadEnStock)
                                    {
                                        Console.WriteLine("Ingrese una cantidad no mayor para restar del stock actual");
                                        minusStock = int.Parse(Console.ReadLine());
                                    }
                                }
                                actual.cantidadEnStock -= minusStock;
                                Console.WriteLine("Stock reducido");
                                finModificacion = true;
                                break;

                            default:
                                Console.WriteLine("Ingrese una opcion valida (1-2)");
                                break;
                        }

                    } while (finModificacion != true) ;
                    



                }
                else
                {
                    actual = actual.siguiente;
                }
            }


        }//


        private Productos BuscarProducto(int codigoABuscar)//(4) funcion Interna, la funcion 4 busca y devuelve, y la funcion 6 muestra (como la complican)
        {
          
            Productos productoEncontrado = new Productos();
            Nodo actual = new Nodo();
            actual = primero;
            bool encontrado = false;

            if (primero!=null)
            {
                while (actual!=null && encontrado != true )
                {
                    if (actual.codigoProducto == codigoABuscar)
                    {
                        productoEncontrado.codigo = actual.codigoProducto;
                        productoEncontrado.nombre_producto = actual.nombreProducto;
                        productoEncontrado.precio_producto = actual.precioProducto;
                        productoEncontrado.stock_producto = actual.cantidadEnStock;
                        encontrado = true;
                    }
                    actual = actual.siguiente;
                }
            }
            
            return productoEncontrado;
        }

        //5

        public void MostrarPorCodigo(int codigoIngresado) //(6) este metodo utiliza al metodo 4 (debe recibir por parametro)
        {
            //Console.WriteLine("Ingrese el codigo(id) del producto que desea buscar para mostrar su informacion"); /////COMENTO ESTO PARA QUE CAMBIE EL MODO DE USO
            //int codigoIngresado = int.Parse(Console.ReadLine());
           
            Console.WriteLine("***  *** *** *** ");
            Console.WriteLine($"Codigo: {BuscarProducto(codigoIngresado).codigo}\n" +
                $"Nombre del producto: {BuscarProducto(codigoIngresado).nombre_producto}\n" +
                $"Precio: {BuscarProducto(codigoIngresado).precio_producto}\n" +
                $"Stock disponible: {BuscarProducto(codigoIngresado).stock_producto}" );
            //revisar como es eso de que el metodo 4 me de null :P
        }

        public void GenerarReporteAgotados(int [] arrayCodigosAgotados) // Ingresa el codigo del producto en un array, si tiene stock 0. Acto seguido, usa la funcion 6) para mostrar 
            // la info cargada en el arreglo (la cual a su vez, usa el punto 4 dentro de si)
        {
            Nodo actual = primero;

            if (primero == null)
            {
                Console.WriteLine("No se puede generar el reporte ya que la lista está vacia");
                
            }
            else if (primero != null)
            {
                int i = 0;

                while (actual != null)
                {

                    if (actual.cantidadEnStock == 0) //Producto agotado (stock igual a 0)
                    {
                        arrayCodigosAgotados[i] = actual.codigoProducto;
                        i++;
                    }
                    
                    actual = actual.siguiente;
                }

            }

            Console.WriteLine(" Informacion de arreglo: ");

            for (int i = 0; i < arrayCodigosAgotados.Length && arrayCodigosAgotados[i] != 0; i++)
            {
                MostrarPorCodigo(arrayCodigosAgotados[i]);
            }

        }


        public void BorrarProducto()
        {
            Nodo actual = primero;
            Nodo anterior;

            Console.WriteLine("Ingrese el ID/codigo del producto a borrar de la lista de productos ");
            int idAEliminar = int.Parse(Console.ReadLine());

            if (primero == null)
            {
                Console.WriteLine("La lista esta vacia; no se puede eliminar");
            }

            else if(primero.codigoProducto == idAEliminar) // Lo eliminamos si es que está al principio
            {
                primero = primero.siguiente;
            }
            else if (ultimo.codigoProducto == idAEliminar) // Lo eliminamos si esta a l final
            {
                while (actual!=null)
                {
                    anterior = actual;
                    actual = actual.siguiente;

                    if (actual == ultimo)
                    {
                        anterior.siguiente = null;
                        ultimo = anterior; // "El que le sigue al anterior va a ser nulo, y despues, el ultimo pasara a ser el anterior"
                    }
                    
                }

            }
            else // al medio
            {
                while (actual!=null)
                {
                    anterior = actual;
                    actual = actual.siguiente;

                    if (actual.codigoProducto == idAEliminar)
                    {
                        anterior.siguiente = actual.siguiente;
                        break;
                    }


                }

            }

        }

    }

}
