using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Escribe un programa que muestre por consola (con un print) los
            * números de 1 a 100 (ambos incluidos y con un salto de línea entre
            * cada impresión), sustituyendo los siguientes:
            * - Múltiplos de 3 por la palabra "fizz".
            * - Múltiplos de 5 por la palabra "buzz".
            * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
            */

            for (int i = 0; i < 100; i++)
            {
                if ((i+1) % 3 == 0 && (i+1) % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if ((i+1) % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if((i+1)% 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i + 1);
                }
            }

            Console.ReadLine();
        }
    }
}
