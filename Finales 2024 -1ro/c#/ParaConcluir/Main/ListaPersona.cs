using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class ListaPersona
    {
        NodoPersona primero;
        NodoPersona ultimo;

        public ListaPersona()
        {
            primero = null;
            ultimo = null;
        }

        public void MostrarLista()
        {
            NodoPersona actual = primero;

            if (primero != null)
            {
                while (actual!=null)
                {
                    Console.WriteLine($"ID: [{actual.user_id}]  \n" +
                        $"Usuario : [{actual.user_name}]  \n" +
                        $"Edad :  [{actual.edad}]\n" +
                        $"Correo :  [{actual.email}]\n" +
                        $"-   -   -   -   -   -   -\n" +
                        $"");

                    actual = actual.siguiente;
                }
            }
            else
            {
                Console.WriteLine("La lista está vacia");
            }
        }

        public void InsertarEnLista(int id,int edad, string nombre, string eMail) //como siempre, insertamos de manera ordenada por EDAD, de mayor a menor
        {
            //como es un metodo que toma los datos de un arrayt de struct, se lo pasamos  por parametro
            NodoPersona nuevo = new NodoPersona();
            nuevo.siguiente = null;


            nuevo.user_id = id;

            nuevo.edad = edad;
            nuevo.user_name = nombre;
            nuevo.email = eMail;

            //Insertamos de mayor a menor por edad
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else if (nuevo.edad > primero.edad) // al principio
            {
                nuevo.siguiente = primero;
                primero = nuevo;
            }
            else if (nuevo.edad <= ultimo.edad) // al final
            {
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
            else  // en cambio, si lo tenemos que poner al medio...
            {
                NodoPersona actual = primero;

                while(actual != null)
                {
                    if (nuevo.edad < actual.edad && nuevo.edad >= actual.siguiente.edad)
                    {
                        nuevo.siguiente = actual.siguiente;
                        actual.siguiente = nuevo;
                        break;
                    }
                    actual = actual.siguiente;
                }
               
            }

        }

        public bool VerificarUsuarioExistente(int idABuscar) //devuelve bool true si encuentra a un usuario (por id)
        {
            bool existe = false;
            NodoPersona actual = primero;

            while (actual != null && existe != true)
            {
                if (actual.user_id == idABuscar)
                {
                    existe = true;
                }
                actual = actual.siguiente;
            }
            if (actual == null)
            {
                Console.WriteLine("No existe la persona en la lista;");
            }
            return existe;
        }





    }
}
