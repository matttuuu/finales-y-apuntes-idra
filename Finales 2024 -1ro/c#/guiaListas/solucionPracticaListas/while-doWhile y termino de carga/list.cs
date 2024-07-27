using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_doWhile_y_termino_de_carga
{
    class list
    {
        nodo primero;
        nodo ultimo;

        public list()
        {
            primero = null;
            ultimo = null;
        }

        //insertar sin parar con while-if, y/o con  do-while

        

        public void Insertar(int datoAInsertar)
        {
            nodo nuevo = new nodo();
            nuevo.siguiente = null;

            nuevo.dato = datoAInsertar;

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
            nodo actual = primero;

            if (primero != null)
            {
                int cont = 0;

                while (actual != null)
                {
                    Console.WriteLine($"Nodo n° {cont}\n" +
                        $"Dato : | {actual.dato} |");
                    Console.WriteLine("-    -    -    -");
                    cont++;
                    actual = actual.siguiente;

                }
            }
            else
                Console.WriteLine("La lista esta vacia");
            
        }
    }

}
