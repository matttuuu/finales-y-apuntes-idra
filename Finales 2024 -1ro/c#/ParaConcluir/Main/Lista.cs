using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
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

        public void MostrarLista()
        {
            Nodo actual = primero;

            if (primero == null)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else if (primero!=null)
            {
                Console.WriteLine("Informacion de lista -------");
                Console.WriteLine();

                while (actual!= null)
                {
                    Console.WriteLine($"ID:   {actual.id}\n" +
                        $"Nombre_usuario:   {actual.nombre_usuario}\n" +
                        $"_  _  _  _  _  _  _  _  _  _\n" +
                        $"");
                    actual = actual.siguiente;

                }

            }

        }

        public void Insertar(int id, string nombreUsuario) // este me toma los parametros del main
        {
            Nodo nuevo = new Nodo();
            nuevo.siguiente = null;

            nuevo.id = id;
            nuevo.nombre_usuario = nombreUsuario;

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else if (nuevo.id > primero.id) // la insercion es ordenada de mayor a menor
            {
                nuevo.siguiente = primero;
                primero = nuevo;
            }
            else if (nuevo.id <= ultimo.id)
            {
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
            else 
            {
                Nodo actual = primero;

                while (actual!=null)
                {
                    if (actual.id > nuevo.id && actual.siguiente.id <= nuevo.id)  // razonar esta parte de nuevo (soy capaz de razonarla en un minuto :D)
                    {
                        nuevo.siguiente = actual.siguiente;
                        actual.siguiente = nuevo;
                        break;
                    }
                    else
                    {
                        actual = actual.siguiente;
                    }
                } // Cuando veas este mensaje de nuevo: estas en condiciones de aprobar :)
                 //recorda siempre leer con detenimiento el ejercicio y usar hoja y lapiz para plantear y razonar el flujo del problema
                 // dividir los problemas grandes en mas chicos, y que cada parte haga su propia cosa, ayuda bastante
                 // 
                 //  Razonar con consciencia y confianza, y tomarse su tiempo;  Se puede :D 
                

            }

            
            

        }

        public void InsertarConFinDeCarga() // este hace todo dentro, con fin de carga indicado con 0 ()
        {
            bool finCarga = false;

            do
            {

                Nodo nuevo = new Nodo();
                nuevo.siguiente = null;

                Console.WriteLine("(1/2) Ingrese el id de la persona a agregar: \n" +
                    " (ingrese '0' (cero) en este punto para dejar de cargar ) ");

                nuevo.id = int.Parse(Console.ReadLine());

                if (nuevo.id == 0)
                {
                    finCarga = true;
                }
                else
                {
                    Console.WriteLine("(2/2) Ingrese el nombre de la persona a agregar: ");
                    nuevo.nombre_usuario = Console.ReadLine();

                    if (primero == null)
                    {
                        primero = nuevo;
                        ultimo = nuevo;
                    }
                    else if (nuevo.id < primero.id) //hagamos que esta vez sea de menor a mayor 
                    {
                        nuevo.siguiente = primero;
                        primero = nuevo;
                    }
                    else if (nuevo.id >= ultimo.id)
                    {
                        ultimo.siguiente = nuevo;
                        ultimo = nuevo;
                    }
                    else
                    {
                        Nodo actual = primero;

                        while (actual != null)
                        {
                            if (actual.id < nuevo.id && actual.siguiente.id >= nuevo.id)
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


                Console.WriteLine("Persona Insertada");
                Console.WriteLine("");

            } while (finCarga != true);

            
        }

        public bool ChequearPersonaExistente(int idAVerificar) //devuelve true o false segun exista un id o no
        {
            Nodo actual = primero;
            bool existe = false;

            while (actual != null && existe != true)
            {
                if (actual.id == idAVerificar )
                {
                    existe = true;
                }
                actual = actual.siguiente;
            }


            return existe;

        }


        public void BuscarPersona()
        {
            Nodo actual = primero;
            int idABuscar;
            bool encontrado = false;

            Console.WriteLine("Por favor, ingrese el id de la persona a buscar ");
            idABuscar = int.Parse(Console.ReadLine());

            if (primero != null)
            {
                while (actual != null && encontrado != true)
                {
                    if (actual.id == idABuscar)
                    {
                        Console.WriteLine(" Se encontro a la persona! ");
                        encontrado = true;
                    }
                    actual = actual.siguiente;
                }
                if (actual == null) // al parecer si encuentra al usuario al final de todo, como tiene que dar una vuelta mas, me salen los dos mensajes sjsjsj
                {
                    Console.WriteLine("No se encontro a la persona en la lista");
                }
            }
            else
            {
                Console.WriteLine("No se puede buscar; la lista está vacia");
            }

            

        }
       
        public void EliminarPersona() // recordemos que este metodo tiene 4 condiciones, las nombro a cada una mas abajo
        {
            Nodo actual = primero;
            Nodo anterior;
            int idAEliminar;


            Console.WriteLine("Ignrese el id de la persona a eliminar");
            idAEliminar = int.Parse(Console.ReadLine());

            if (primero == null)
            {
                Console.WriteLine("No se puede eliminar; la lista está  vacia");
            }

            else if (primero.id == idAEliminar) // Principio: simplemente muevo el puntero hacia la derecha
            {
                primero = primero.siguiente;
            }

            else if (ultimo.id == idAEliminar) // Final: 
            {
                

                while (actual!=null)
                {
                    anterior = actual;
                    actual = actual.siguiente;

                    if (actual == ultimo) // si nos encontramos al ultimo
                    {
                        anterior.siguiente = null; // entender esto antes de seguir (o tratar ) /*El que  le sigue a anterior, sea quien sea, va a ser nulo
                                                   // acto seguido,  decimos que el ultimo de la lista pase a ser nuestro anterior*/
                        ultimo = anterior;

                        break;
                    }


                }

            }

            else // al medio
            {
                while (actual != null)
                {
                    anterior = actual;
                    actual = actual.siguiente;

                    if (actual.id == idAEliminar)
                    {
                        anterior.siguiente = actual.siguiente;
                        break;
                    }
                }

            }
        }

    }



}
