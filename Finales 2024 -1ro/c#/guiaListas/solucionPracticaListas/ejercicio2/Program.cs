using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    public struct Anuales //Si coloco el struct dentro del namespace, lo puedo usar en el main o en la lista
    {
        public string nombreMateria;
        public int anio;
        public string codigo;
    }

    public struct Horas
    {
        public int anio;
        public int cargaHorariaTotal;
    }

    class Program
    {
        //public struct MateriasAnuales
        //{
        //    string nombreMateria;
        //    int anioMateria;
        //    string codigo; // Ej: PRI_20240507_IALDP --int. a la programacion de primero y fecha de hoy
        //}


        static void Main(string[] args)
        {
            Console.WriteLine("Ej2 - Inicio");
            //MateriasAnuales[] ArrayMaterias = new MateriasAnuales[500];
            Anuales[] arrayAnuales = new Anuales[10];
            Horas[] arrayCargaHoraria = new Horas[3];
            
            Lista l = new Lista();

            ////Se tiene una lista que contiene: COD, Materia, Anio, Modalidad, Horas
            ////
            ////-Armar las clases que permitan implementar la listita
            ////-Desarrollar un metodo que devuelva si un codigo existe o no
            ////-Obtener todas las materias que sean anuales, y guardarlas en un arreglo:
            //se guarda el nombre de la materia, el año y un codigo con formato: {anio}_{date}_{cod} (detalles en pdf)
            ////-Desarrollar un metodo que permita guardar en un arreglo la carga horaria total para cada uno de los años de la carrera de TDS (1, 2 y 3)


            //Prueba- ingreso 2 materias

            Console.WriteLine("Ingrese la cantidad de materias a ingresar: ");
            int cantidadMaterias = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidadMaterias; i++)
            {
                l.cargarLista();
            }
            
            

            l.MostrarLista();
            l.ObtenerAnuales(arrayAnuales);
            l.MostrarInfoAnuales(arrayAnuales);
            l.ObtenerCargaHoraria(arrayCargaHoraria);
            l.MostrarHoras(arrayCargaHoraria);
        }

    }
}
