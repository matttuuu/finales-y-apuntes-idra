using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalListaVuelos
{
    class ListaVuelos
    {
        NodoVuelos primero;
        NodoVuelos ultimo;

        public ListaVuelos()
        {
            primero = null;
            ultimo = null;
        }
            
        public void CargarLista() //metodo para cargar la lista
        {
            NodoVuelos nuevo = new NodoVuelos();
            nuevo.siguiente = null;
            Random r = new Random();
            nuevo.codVuelo = "VU_" + r.Next(0,100).ToString();

            
            Console.WriteLine("Ingrese codigo de ciudad destino:");
            nuevo.codCiudadDestino = int.Parse(Console.ReadLine());
            if (nuevo.codCiudadDestino == 1)
            {
                nuevo.nombreCiudadDestino = "Mardelplata";
            }
            else if (nuevo.codCiudadDestino == 2)
            {
                nuevo.nombreCiudadDestino = "Cordoba";
            }
            else if (nuevo.codCiudadDestino == 3)
                nuevo.nombreCiudadDestino = "Mendoza";
            else if (nuevo.codCiudadDestino == 4)
                nuevo.nombreCiudadDestino = "Tucuman";
            else if (nuevo.codCiudadDestino == 5)
                nuevo.nombreCiudadDestino = "Calafate";

            Console.WriteLine("Cuantos asientos tiene el vuelo: ");
            nuevo.asientosTotales = int.Parse(Console.ReadLine());
            nuevo.asientosDisponibles = nuevo.asientosTotales;
            nuevo.tomadoresDeReservas = "";
            Console.WriteLine("Se cargo un vuelo nuevo");

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else if (nuevo.codCiudadDestino >= primero.codCiudadDestino )
            {
                nuevo.siguiente = primero;
                primero = nuevo;
            }
            else
            {
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
        }


        public void ConsultarDisponibilidad()
        {
            NodoVuelos actual = primero;

            if (primero != null)
            {
                Console.WriteLine("Info de vuelos");
                Console.WriteLine();
                while (actual != null)
                {
                    Console.WriteLine("Codigo de vuelo: " + actual.codVuelo + "\n" +
                        "ciudad de destino: " + actual.nombreCiudadDestino + " (Cod: ) " + actual.codCiudadDestino +   "\n" +

                        "Asientos totales: " + actual.asientosTotales + "\n" +
                        "Asientos disponibles: " + actual.asientosDisponibles + "\n" +
                        "Tomadores de reservas: " + actual.tomadoresDeReservas);
                    Console.WriteLine(" -   -   -   -   -   -   -   -   -   -   -   -   ");
                    actual = actual.siguiente;
                }
            }
        }

        public void RealizarReserva()
        {
            NodoVuelos actual = primero;

            int dni;
            string nombreCompleto;
            int pasajeros;
            int codigoCiudad;
            bool reservaHecha = false;
            Console.WriteLine("Ingrese su numero de documento: ");
            dni = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombre completo: ");
            nombreCompleto = Console.ReadLine();
            Console.WriteLine("Pasajeros a viajar: ");
            pasajeros = int.Parse(Console.ReadLine());
            Console.WriteLine("Ciudad de destino: \n" +
                "1-Mar del plata\n" +
                "2-Cordoba\n" +
                "3-Mendoza\n" +
                "4-Tucuman\n" +
                "5-Calafate");
            codigoCiudad = int.Parse(Console.ReadLine());
            
            if (primero != null) //si el primero no es nulo
            {
                while(actual != null && reservaHecha == false) //mientras no me encuentre ningun nulo
                {
                    if (actual.codCiudadDestino == codigoCiudad && pasajeros <= actual.asientosDisponibles)
                    {
                        //resto asientos y agrego al campo tomadores de reservas
                        actual.asientosDisponibles -= pasajeros;
                        actual.tomadoresDeReservas += nombreCompleto + dni.ToString() + "_";
                        Console.WriteLine("Reserva tomada");
                        Console.WriteLine();
                        reservaHecha = true;
                        break; //con y sin el break
                    }
                    else
                    {
                        actual = actual.siguiente;
                    }
                    if (actual == null)
                    {
                        Console.WriteLine("No se pudo realizar ninguna reserva: compruebe datos a ingresar e intente nuevamente");
                        Console.WriteLine();
                    }
                   
                }
                
                
            }
            else
                Console.WriteLine("No hay elementos en la lista, no se puede reservar");

        }


    }
}
