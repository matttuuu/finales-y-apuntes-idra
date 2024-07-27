using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalStockLau
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

        public void RegistrarProducto() //Ingresar roducto
        {
            Nodo nuevo = new Nodo();
            nuevo.siguiente = null;
            bool terminoCarga;
            int productoN = 1;

            do
            {
                Console.WriteLine($"Nuevo producto ( Numero {productoN} )");
                terminoCarga = false;
                Console.WriteLine("Ingrese el id del producto; asegurese de que no se repita con el codigo de otro producto existente\n" +
                    " (ingrese 0 en este punto para dejar de cargar productos) ");
                nuevo.codigo = int.Parse(Console.ReadLine());

                if (nuevo.codigo != 0 )
                {
                    //seguimos con la carga; chequeamos si existe el codigo

                    if (ChequearCodigo(nuevo.codigo) == true) // Si existe...
                    {

                        while (ChequearCodigo(nuevo.codigo) == true) // no salimos de aca hasta que no pongamos algo que si es unico
                        {
                            Console.WriteLine("El codigo insertado ya existe en la lista\n" +
                                "Por favor, inngrese otro nuevo");
                            nuevo.codigo = int.Parse(Console.ReadLine());
                            
                        }



                    }

                    //ahora que lo pienso toda esta logica la podria haber resumido en un contador que se sume 1 :P(o no?)

                    Console.WriteLine("Ingrese el nombre del producto: ");
                    nuevo.nombreProducto = Console.ReadLine();

                    Console.WriteLine("Precio del prducto: ");
                    nuevo.precio = double.Parse(Console.ReadLine());

                    Console.WriteLine("Cantidad actual de stock: ");
                    nuevo.cantidadEnStock = int.Parse(Console.ReadLine());


                    if (primero == null)
                    {
                        primero = nuevo;
                        ultimo = nuevo;
                    }
                    else //al final (quizas pueda implementar una carga ordenada despues)
                    {
                        ultimo.siguiente = nuevo;
                        ultimo = nuevo;
                    }

                }
                else
                {
                    terminoCarga = true;
                }

                productoN++;

            } while (!terminoCarga);
            
        }

        public bool ChequearCodigo(int codigoAbuscar) // para saber si el codigo existe, si devuelve true  es pq el codigo ya existe, y deberia probar ingresando otro codigo
        {
            bool existe = false;
            Nodo actual = primero;

           
                while (actual != null && !existe )
                {
                    if (actual.codigo ==  codigoAbuscar)
                    {
                        existe = true; // existe el codigo; cortamos la busqueda
                    }
                    actual = actual.siguiente;

                }
                
            
            //por defecto si no hay nada, al principio primero siempre va a ser null;veamos si funca igual
            return existe;
        }


        public void MostrarLista()
        {
            Nodo actual = primero;
            if (primero == null)
            {
                Console.WriteLine("No se puede recorrer; lista vacia");
            }
            else
            {
                Console.WriteLine($"Informacion de lista:");
                Console.WriteLine();
                while (actual != null)
                {
                    Console.WriteLine($"Cod: [{actual.codigo}]\n" +
                        $"Nombre producto: [{actual.nombreProducto}]\n" +
                        $"Precio[{actual.precio}]" +
                        $"Cantidad en stock[{actual.cantidadEnStock}]" +
                        $"--    --  --      --");
                    Console.WriteLine();
                    actual = actual.siguiente;
                }
            }
        }

        public void NuevoMetodo()
        {

        }
    }
}
