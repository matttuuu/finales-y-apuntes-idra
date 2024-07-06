using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        public struct MateriasAnuales
        {
            string nombreMateria;
            int anioMateria;
            string codigo; // Ej: PRI_20240507_IALP --int. a la programacion de primero y fecha de hoy
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Ej2 - Inicio");
            MateriasAnuales[] ArrayMaterias = new MateriasAnuales[500];
            Lista l = new Lista();

            ////Se tiene una lista que contiene: COD, Materia, Anio, Modalidad, Horas
            ////
            ////-Armar las clases que permitan implementar la listita
            ////-Desarrollar un metodo que devuelva si un codigo existe o no
            ////-Obtener todas las materias que sean anuales, y guardarlas en un arreglo:
            //se guarda el nombre de la materia, el año y un codigo con formato: {anio}_{date}_{cod} (detalles en pdf)
            ////-Desarrollar un metodo que permita guardar en un arreglo la carga horaria total para cada uno de los años de la carrera de TDS


            //Prueba- ingreso 2 materias
            l.cargarLista();
            l.cargarLista();

            l.MostrarLista();
        }

    }
}
