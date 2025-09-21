using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAMOS VARIABLES 
            int nota;
            double raiz_cuadrada, potencia_cubo;

            //PEDIMOS LA NOTA
            Console.WriteLine("---- INGRESE SU NOTA (0-20) -----");
            nota = Convert.ToInt32(Console.ReadLine());

            //USAMOS EL SWITCH
            switch (nota)
            {
                case int n when (n >= 0 && n <= 10):
                    Console.WriteLine("DESAPROBADO");
                    break;
                case int n when (n >= 11 && n <= 13):
                    Console.WriteLine("Regular");
                    break;
                case int n when (n >= 14 && n <= 17):
                    Console.WriteLine("Bueno");
                    break;
                case int n when (n >= 18 && n <= 20):
                    Console.WriteLine("Excelente");
                    break;
                default:
                    Console.WriteLine("NOTA NO VALIDA");
                    return;
            }

            //USAMOS CONDICIONALES Y OPERADORES LOGICOS
            if (nota >= 14 && nota % 2 == 0)
            {
                Console.WriteLine("Buen desempeño con nota par");
            }
            if (nota % 2 != 0 && nota < 11)
            {
                Console.WriteLine("Necesita reforzar");
            }

            //CALCULAMOS Y MOSTRAMOS 
            raiz_cuadrada = Math.Sqrt(nota);
            potencia_cubo = Math.Pow(nota, 3);

            Console.WriteLine("La raiz cuadrada de la nota es: " + raiz_cuadrada);
            Console.WriteLine("La potencia al cubo de la nota es: " + potencia_cubo);
        }
    }
}
