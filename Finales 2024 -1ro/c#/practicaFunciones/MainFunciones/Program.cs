using System;

namespace MainFunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Archivo de practica con distintas funciones
            Console.WriteLine("Tema Funciones");

            //Una funcion es un bloque de codigo que, cuando es invocado, realiza una funcion especifica
            //Las funciones pueden tener un valor de retorno, o ninguno (void)
            // tambien pueden ser estaticas (que pertenecen a la clase y no a una instancia especifica de una clase)
            // o de instancia (que si pertenecen a una instancia de clase)



            int SumarDosNumeros(int num1, int num2) //Funcion que retorna un numero entero
            {
                int valorFinal = num1 + num2;
                return valorFinal;
            }



            
            //Console.WriteLine("El resultado de sumar los numeros es: " + SumarDosNumeros(10,30));
            //Console.WriteLine("letras a b c juntas es: " + ConcatenarLetras('a','b','c'));
            ////Instancio clase calculadora
            //Calculadora calc = new Calculadora();

            //Juego con la clase
            //Console.WriteLine("Ingrese el numero 1/2 a multiplicar");
            //int numero1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("numero 2/2 a multiplicar");
            //int numero2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Resultado: " + calc.Multiplicar(numero1, numero2));
            
            ////////////////////////////////PRACTICA GUIA 5//////////////////////////////////////////////////////
            ///

            //(1)
            int Resta(int num1, int num2) //a
            {
                int resultado = num1 - num2;
                return resultado;

            }

            double Promedio( double num1, double num2, double num3) //b
            {
                double resultado = (num1 + num2 + num3) / 3;
                return resultado;

            }

            int MaximoNumero(int num1, int num2)//c
            {
                int mayor = 0;

                if (num1 > num2)
                {
                    mayor = num1;
                    return mayor;
                }
                else if (num1 < num2)
                {
                    mayor = num2;
                    return mayor;
                }
                else            
                    Console.WriteLine("Ambos numeros son iguales");
                
                return mayor;              
            }

            string PrimeroDivisible(int num1, int num2) //d (indicar mensaje que diga si  el primer numero es divisible por el segundo)
            {
                //Un numero  es divisible por otro cuando  la division es exacta (osease, cuando el resto da 0)
                int resultado = num1 % num2; // '%' se usa para obtener el residuo de una division entre 2 numeros enteros.
                if (resultado ==  0)
                    return  "Los numeros son divisibles";                
                else               
                    return "Los numeros no son divisibles";
                
            }


            //(2)

            CalcularImpuesto(130000);






        }



        //static void Saludar() //Ejemplo de funcion estatica: pertenece a la clase "program", en este caso.
        //{
        //    Console.WriteLine("funcion saludar: buen dia grupooo");
        //}

        //static string ConcatenarLetras(char letra1, char letra2, char letra3) //Si, podrian ser directamente strings las letras, pero es para demostrar nada mas
        //{

        //    string resultado = letra1.ToString() + letra2.ToString() + letra3.ToString(); 
        //    return resultado;
        //}

        //public static void EjemploDeMetodo()
        //{

        //}

   
        //2-a
        static void CalcularImpuesto(double gananciaAnual)
        {
            double impuesto = 0;

            if (gananciaAnual < 100000)
            {
                Console.WriteLine("IMPU: " + impuesto);
            }
            else if (gananciaAnual >= 100000 && gananciaAnual < 150000)
            {
                impuesto = (2/100)* (gananciaAnual - 100000);
                Console.WriteLine("IMPU " + impuesto);
            }
            else if (gananciaAnual > 150000)
            {
                
                Console.WriteLine("blee");
            }
        }


    }
}
