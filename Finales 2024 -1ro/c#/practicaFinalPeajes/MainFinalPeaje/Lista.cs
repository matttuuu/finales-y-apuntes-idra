using System;
using System.Collections.Generic;
using System.Text;

namespace MainFinalPeaje
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

        public void InsertarInfraccion(string nombreCiudad, int cantidadInfracciones) // inserto con ciudad nueva
        {
            Nodo nuevo = new Nodo();
            nuevo.siguiente = null;

            nuevo.nombre_ciudad_destino = nombreCiudad;
            nuevo.cantidad_infracciones = cantidadInfracciones;

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else if (nuevo.cantidad_infracciones > primero.cantidad_infracciones)
            {
                nuevo.siguiente = primero;
                primero = nuevo;
            }
            else if (nuevo.cantidad_infracciones <= ultimo.cantidad_infracciones)
            {
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
            else
            {
                Nodo actual = primero;

                while (actual != null)
                {
                    if (actual.cantidad_infracciones > nuevo.cantidad_infracciones && actual.siguiente.cantidad_infracciones < nuevo.cantidad_infracciones)
                    {
                        nuevo.siguiente = actual.siguiente;
                        actual.siguiente = nuevo;
                        break;
                    }
                    else
                    {
                        actual = actual.siguiente;
                    }
                }

                
            }

        }

        public bool CiudadExiste( string nombreCiudad) // es TRUE si existe dicha ciudad
        {
            bool existe = false;

            Nodo actual = primero;

            while (actual!=null && existe != true)
            {
                if (actual.nombre_ciudad_destino.ToUpper() == nombreCiudad.ToUpper())
                {
                    existe = true; // encontramos la ciudad
                }
                actual = actual.siguiente;
            }


            return existe;
        }


        public void ActualizarInfraccion(string nombreCiudad ) // busco esa ciudad y le agrego una infraccion mas
        {
            Nodo actual = primero;

            while (actual!=null)
            {
                if (actual.nombre_ciudad_destino == nombreCiudad)
                {
                    actual.cantidad_infracciones +=1;
                }

                actual = actual.siguiente;
            }
        }

        public void MostrarLista() // recorro y muestro la lista
        {
            Nodo actual = primero;

            if (primero == null)
            {
                Console.WriteLine("No se puede mostrar la lista ya que esta vacia");
            }
            else 
            {
                Console.WriteLine("Info de lista");

                while (actual!= null)
                {
                    Console.WriteLine($"---CIUDAD: {actual.nombre_ciudad_destino}\n" +
                        $"AUTOS CON INFRACCIONES: {actual.cantidad_infracciones}");
                    Console.WriteLine("_    _   _   _    _");
                    Console.WriteLine();
                    actual = actual.siguiente;
                }
            }

        }

    }

}
