using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
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

        public void cargarLista()
        {
            Nodo nuevo = new Nodo();
            nuevo.Siguiente = null; //Pruebo con declarar que el siguiente del nuevo nodo sea null

            Console.WriteLine("Nueva materia");
            Console.WriteLine("Ingrese codigo");
            Console.WriteLine(" TSS: ");
            nuevo.cod ="TSS" + Console.ReadLine();
            Console.WriteLine(" Nombre materia: ");
            nuevo.materia = Console.ReadLine();
            Console.WriteLine(" Año:  ");
            nuevo.anio = int.Parse(Console.ReadLine());
            Console.WriteLine(" Modalidad: ");
            nuevo.modalidad = char.Parse(Console.ReadLine());
            Console.WriteLine(" cantidad Horas: ");
            nuevo.horas = int.Parse(Console.ReadLine());

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
            Console.WriteLine("Nueva materia insertada ♫ ");
            Console.WriteLine();

        }

        public void MostrarLista()
        {
            Nodo actual = primero;

            if (primero != null)
            {
                Console.WriteLine("Informacion de Lista");

                while (actual != null)
                {
                    Console.WriteLine("Codigo de materia:" + actual.cod + "\n" +
                        "Materia: " + actual.materia + "\n" +
                        "Anio: " + actual.anio + "\n" +
                        "Modalidad: " + actual.modalidad  + "\n" +
                        "Horas: " + actual.horas);
                    actual = actual.Siguiente;
                }
            }
            else
                Console.WriteLine("Lista Vacia");
        }

        public void ObtenerAnuales(Anuales[] array)
        {
            Nodo actual = primero;

            if (primero != null)
            {
                
                int cont = 0;
                
                while (actual != null)
                {
                    if (actual.modalidad == 'A') //Si nos encontramos una anual, guardamos en arreglo
                    {
                        string formato = "";
                        array[cont].nombreMateria = actual.materia;
                        array[cont].anio = actual.anio;
                        if (actual.anio == 1)
                        {
                            formato += "PRI_";
                        }
                        else if (actual.anio ==2)
                        {
                            formato += "SEG_";
                        }
                        else if(actual.anio == 3)
                        {
                            formato = "TER_";
                        }

                        array[cont].codigo = formato + "20240707_" + "PIDCP";
                        cont++;
                    }
                    actual = actual.Siguiente;
                }
            }
            else
                Console.WriteLine("Lista vacia - No se puede recorrer");
        }

        public void MostrarInfoAnuales(Anuales[] array)
        {
            if (array[0].nombreMateria != null)
            {
                Console.WriteLine("Informacion de materias anuales --- --- : ");
                Console.WriteLine();

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].nombreMateria == null)                    
                        break;                    
                    Console.WriteLine("Nombre de la materia: " + array[i].nombreMateria);
                    Console.WriteLine("Año :" + array[i].anio);
                    Console.WriteLine("Codigo: " + array[i].codigo);
                    Console.WriteLine();
                    
                }
            }
            else
                Console.WriteLine("Array vacio ");
        }

        public void ObtenerCargaHoraria(Horas [] array)
        {
            Nodo actual = primero;
            array[0].anio = 1;
            array[1].anio = 2;
            array[2].anio = 3;

            if (primero != null)
            {

                while (actual != null)
                {
                    //guardar carga horaria para primer año, segundo y tercero
                    if (actual.anio == 1)
                    {
                        array[0].cargaHorariaTotal += actual.horas;
                    }
                    else if (actual.anio == 2)
                    {
                        array[1].cargaHorariaTotal += actual.horas;
                    }
                    else
                    {
                        array[2].cargaHorariaTotal += actual.horas;
                    }

                    actual = actual.Siguiente;
                }
                Console.WriteLine("Arreglo cargado");
            }
            else
                Console.WriteLine("No hay materias en la lista");

        }
        
        public void MostrarHoras(Horas[] array)
        {
            Console.WriteLine("Info de horas");
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Año de la carrera: " + array[i].anio);
                Console.WriteLine("Carga horaria total: " + array[i].cargaHorariaTotal);
                Console.WriteLine("---  ---  ---  ---  ---  ---  ---");
                Console.WriteLine();
            }
        }

        

    }

}

