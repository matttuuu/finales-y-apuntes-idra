using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
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

        public void CargarListaMatriz(int fil, int col, double dato)
        {
            Nodo nuevo = new Nodo();
            nuevo.siguiente = null;

            nuevo.fila = fil;
            nuevo.columna = col;
            nuevo.dato = dato;

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }


        }

        public void Listar()
        {
            Nodo actual = primero;

            if (primero !=  null)
            {
                Console.WriteLine("Info de lista");

                while (actual != null)
                {
                    Console.WriteLine($"Fila- {actual.fila}\n" +
                        $"Columna- {actual.columna}\n" +
                        $"Dato= [ {actual.dato} ]");
                    Console.WriteLine();
                    actual = actual.siguiente;
                }
            }
            else
                Console.WriteLine("La lista esta vacía");
            
        }

        public void GuardarMaximoDeColumna( double[] array ) //el maximo de cada columna (ej, si la matriz es de 2x4, hallar el maximo de cada una de las 4 columnas)
        {
            Nodo actual = primero;

            int columnaActual = 0;
            double max;



            if (primero == null)
                Console.WriteLine("No se puede recorrer la lista; está vacia");

            //recorrido, insercion al final en el arreglo


            else
            {
                for (int i = 0; i <= ultimo.columna; i++) //we made it!!!!!!
                {
                    actual = primero;
                    max = 0;
                    
                    while (actual != null)
                    {
                       
                        if (actual.columna == i && actual.dato > max )
                        {
                            max = actual.dato;
                        }
                        actual = actual.siguiente;
                    }
                    array[i] = max;
                }
                
            }

        }



    }

   
}
