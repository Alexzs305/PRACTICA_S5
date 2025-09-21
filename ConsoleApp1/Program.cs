using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAMOS VARIABLES 
            double precio, descuento, preciofinal, descuentoAdicional;
            int codigo;

            //PEDIMOS DATOS 
            Console.WriteLine("---- Ingrese el precio del producto: ----");
            precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el codigo de descuento: ");
            Console.WriteLine("(1) ESTUDIANTE");
            Console.WriteLine("(2) EMPLEADO");
            Console.WriteLine("(3) CLIENTE FRECUENTE");
            codigo = Convert.ToInt32(Console.ReadLine());

            //HACEMOS EL DESCUENTO 
            descuento = 0;

            if (codigo == 1)
            {
                descuento = precio * 0.10;
            }
            else if (codigo == 2)
            {
                descuento = precio * 0.15;
            }
            else if (codigo == 3)
            {
                descuento = precio * 0.20;
            }
            else
            {
                Console.WriteLine("CODIGO NO VALIDO");
            }

            preciofinal = precio - descuento;

            //DESCUENTO ADICIONAL 
            if (precio > 500)
            {
                descuentoAdicional = preciofinal * 0.05;
                preciofinal = preciofinal - descuentoAdicional;
            }

            //MOSTRAMOS LOS RESULTADOS
            Console.WriteLine("El precio final es: " + preciofinal);
        }
    }
}
