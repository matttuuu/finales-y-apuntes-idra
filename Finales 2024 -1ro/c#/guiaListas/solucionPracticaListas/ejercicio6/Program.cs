using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio del programa");
            Lista l = new Lista();

            double[] ArrayValoresMaximos; //guarda el valor maximo de cada columna de la matriz (1)
            
            Console.WriteLine("Ingrese cantidad de filas de la matriz");
            int cantFilas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de columnas de la matriz");
            int cantColumnas = (int)double.Parse(Console.ReadLine());

            ArrayValoresMaximos = new double[cantColumnas]; //le ponemos como tamaño la cantidad de columnas (2)

            


            for (int i = 0; i < cantFilas; i++)
            {
                
                for (int j = 0; j < cantColumnas; j++)
                {
                    Console.WriteLine($"Ingrese el valor de la posicion FILA [{i}] | COLUMNA[{j}] ");
                    double valor = double.Parse(Console.ReadLine());
                    l.CargarListaMatriz(i, j, valor);
                    
                }

            }

            l.Listar();

            l.GuardarMaximoDeColumna(ArrayValoresMaximos);

            Console.WriteLine("Info de arreglo");
            for (int i = 0; i < ArrayValoresMaximos.Length; i++)
            {
                Console.WriteLine($"Valor maximo para columna {i} : [ {ArrayValoresMaximos[i]} ]\n" +
                    $"---   --- --- --- --- --- --- ---");
            }


            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }
    }
}
