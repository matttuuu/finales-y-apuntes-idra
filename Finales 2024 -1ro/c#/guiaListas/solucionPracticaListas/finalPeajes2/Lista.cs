using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalPeajes2
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

        public void AgregarALista(string nombreciudad,int cantInfracciones)
        {
            Nodo nuevo = new Nodo();
            nuevo.siguiente = null;

            nuevo.nombreCiudad = nombreciudad;
            nuevo.cantidadAutosInfraccionados = cantInfracciones;

            if (primero == null) //Si no hay nada en la lista (unica / primera vez)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else if (nuevo.cantidadAutosInfraccionados >= primero.cantidadAutosInfraccionados)
            {
                nuevo.siguiente = primero;
                primero = nuevo;
            }
            else if (nuevo.cantidadAutosInfraccionados <= ultimo.cantidadAutosInfraccionados)
            {
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
            else //Lo tengo que colocar en el medio
            {
                Nodo actual = primero;

                while (actual.siguiente.cantidadAutosInfraccionados >= actual.cantidadAutosInfraccionados && actual.siguiente.cantidadAutosInfraccionados >= nuevo.cantidadAutosInfraccionados)
                {
                    actual = actual.siguiente;
                }
                nuevo.siguiente = actual.siguiente;
                actual.siguiente = nuevo;
            }
        }

        public void MostrarLista()
        {
            Nodo actual = primero;
           

            if (primero != null)
            {
                Console.WriteLine("Informacion de lista");
                Console.WriteLine();

                while (actual != null)
                {
                    Console.WriteLine("Nombre de la ciudad de destino: " + actual.nombreCiudad + "\n" +
                        "Autos en falta: " + actual.cantidadAutosInfraccionados + "\n" +
                        " -- -- -- -- -- -- -- -- ") ;
                    Console.WriteLine();
                    actual = actual.siguiente;
                }
            }
            else
                Console.WriteLine("Lista vacia; no hay autos con infracciones");
            
        }

        public bool CiudadExistente(string nombreCiudad) //metodo que me dice si una ciudad existe o no
        {
            bool existe = false;
            Nodo actual = primero;

            if (primero != null)
            {
                while ( actual !=null && existe == false )
                {
                    if (actual.nombreCiudad == nombreCiudad)
                    {
                        existe = true;
                    }
                    else
                        actual = actual.siguiente;

                }

            }
            else
            {
                Console.WriteLine("No hay elementos en la lista");
            }
            return existe;
        }
    }
}
