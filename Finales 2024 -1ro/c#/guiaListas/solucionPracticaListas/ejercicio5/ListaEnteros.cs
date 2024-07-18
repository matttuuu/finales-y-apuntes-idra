using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class ListaEnteros
    {
        NodoEnteros primero;
        NodoEnteros ultimo;

       public ListaEnteros()
       {
            primero = null;
            ultimo = null;
       }

       public void AgregarNumero(int num) //mayor a menor
        {
            NodoEnteros nuevo = new NodoEnteros();
            nuevo.siguiente = null;
            Random r = new Random();
            

           
            nuevo.NUMERO = num;
            nuevo.id = "N" + r.Next(0,101); // 1 a 100

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else if(nuevo.NUMERO >= primero.NUMERO)
            {
                //insercion al principio
                nuevo.siguiente = primero;
                primero = nuevo;
            }
            else if (nuevo.NUMERO <= ultimo.NUMERO)
            {
                ultimo.siguiente = nuevo; //al final
                ultimo = nuevo;
            }
            else // al diome - la  tecninca del 5532 (o capaz tambien 532)
            {
                NodoEnteros actual = primero;

                if (actual.NUMERO > nuevo.NUMERO && actual.siguiente.NUMERO <= nuevo.NUMERO) // funciona
                {
                    nuevo.siguiente = actual.siguiente;
                    actual.siguiente = nuevo;
                }
                else
                    actual = actual.siguiente;
            }
            Console.WriteLine("Numero agregado");
        }

        public void AgregarNumero()
        {
            int num = -1;
            while (num !=0)
            {
                Console.WriteLine("Ingrese el numero a cargar a lista; ingrese 0 para indicar fin de carga");
                num = int.Parse(Console.ReadLine());
                if (num != 0)
                {
                    NodoEnteros nuevo = new NodoEnteros();
                    Random r = new Random();
                    nuevo.siguiente = null;

                    nuevo.NUMERO = num;
                    nuevo.id = "N" + r.Next(0,101);
                    

                    if (primero == null)
                    {
                        primero = nuevo;
                        ultimo = nuevo;
                    }
                    else //al final
                    {
                        ultimo.siguiente = nuevo;
                        ultimo = nuevo;
                    }

                }

            }
            
            
            
        }

        public void MostrarLista()
        {
            NodoEnteros actual = primero;

            if (primero != null)
            {
                Console.WriteLine("Informacion de lista");
                Console.WriteLine();
                while (actual != null)
                {
                    Console.WriteLine(" numero: " + actual.NUMERO + "| Id: " + actual.id + " | ");
                    Console.WriteLine(" --- --- --- ");
                    actual = actual.siguiente;
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("La lista esta vacia");
        }

        //Estos metodos no son del ejercicio, pero me gustaria practicarlos
        //Busqueda-Eliminacion
        // para esto le voy a agregar un campo id a cada nodo que sea aleatorio


        public void BuscarNodo(string idABuscar) //Podemos buscar por id o por algun dato a verificar que exista
        {
            NodoEnteros actual = primero;
            bool encontrado = false;

            if (primero != null)
            {
                while (actual!= null && !encontrado) //que significa el '!'? que sea negativo?
                {
                    if (actual.id == idABuscar)
                    {
                        Console.WriteLine("Se encontró el nodo");
                        //Le podemos agregar mas logica, como poner un contador que me diga en que parte
                        //de la lista está el nodo, por ejemplo. Pero con esto esta bien
                        encontrado = true;
                    }
                    else
                    {
                        actual = actual.siguiente;
                    }                      
                        
                }
                if (actual == null)
                {
                    Console.WriteLine("No se encontro el nodo en la lista");
                }
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }


        }


        public void EliminarNodo(string idABuscar) //Buscamos por id o por dato del nodo, para sacarlo de la lista.
        {
            //La logica de este metodo  es que tengo  opciones para sacar el nodo del  principio,
            //del final o del medio

            NodoEnteros actual = primero;
            NodoEnteros anterior;

            if (primero == null)
                Console.WriteLine("Lista vacia");

            else if (primero.id == idABuscar) //         Principio
                primero = primero.siguiente;

            else if (ultimo.id == idABuscar) //           Final
            {
                while (actual != null)
                {
                    anterior = actual; //declaro a cada uno como el "de la derecha"
                    actual = actual.siguiente;

                    if (actual == ultimo)
                    {
                        //aca es donde esta la logica del reemplazo
                        // 5 5 3 2-> quiero sacar el 2
                        anterior.siguiente = null;
                        ultimo = anterior;

                    }
                   
                }
            }

            else //          Medio       
            {
                while (actual != null)
                {
                    anterior = actual;
                    actual = actual.siguiente;

                    if (actual.id == idABuscar)
                    {
                        anterior.siguiente = actual.siguiente;
                        break;
                    }
                }
            }


        }

       
    }
}
