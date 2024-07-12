using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    public struct InformacionOperario
    {
        public string nombre;
        public string apellido;
        public char categoria;//a b c
        public double sueldo;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //tres arreglos, cada uno con informacion de operario
            //se guarda: nombre, apellido, categoria, sueldo
            ListaOperarios lo = new ListaOperarios();

            InformacionOperario[] operarioUno = new InformacionOperario[1];
            operarioUno[0].nombre = "Juan";operarioUno[0].apellido = "Azcuenaga"; operarioUno[0].categoria = 'A'; operarioUno[0].sueldo = 20000;
            InformacionOperario[] operarioDos = new InformacionOperario[1];
            operarioDos[0].nombre = "Maria"; operarioDos[0].apellido = "Torres"; operarioDos[0].categoria = 'B'; operarioDos[0].sueldo = 25000;
            InformacionOperario[] operarioTres = new InformacionOperario[1];
            operarioTres[0].nombre = "Miguel"; operarioTres[0].apellido = "Velasquez"; operarioTres[0].categoria = 'C'; operarioTres[0].sueldo = 30000;

            lo.CargarLista(operarioUno);
            lo.CargarLista(operarioDos);
            lo.CargarLista(operarioTres);

            lo.MostrarLista();

            //faltan puntos b y c


        }
    }
}
