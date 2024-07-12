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

           
            nuevo.NUMERO = num;

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
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
            Console.WriteLine("Numero agregado");
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
                    Console.WriteLine(" numero: " + actual.NUMERO);
                    Console.WriteLine(" --- --- --- ");
                    actual = actual.siguiente;
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("La lista esta vacia");
        }


       
    }
}
