using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            //for (int i = 0; i < 100; i++)
            //{
            //    if ((i+1) % 3 == 0 && (i+1) % 5 == 0)
            //    {
            //        Console.WriteLine("fizzbuzz");
            //    }
            //    else if ((i+1) % 3 == 0)
            //    {
            //        Console.WriteLine("fizz");
            //    }
            //    else if((i+1)% 5 == 0)
            //    {
            //        Console.WriteLine("buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i + 1);
            //    }
            //}

            //Console.ReadLine();

            //-----------------------------------------------------------

            //RETO 11

            /*
            * Crea un programa que comprueba si los paréntesis, llaves y corchetes
            * de una expresión están equilibrados.
            * - Equilibrado significa que estos delimitadores se abren y cieran
            *   en orden y de forma correcta.
            * - Paréntesis, llaves y corchetes son igual de prioritarios.
            *   No hay uno más importante que otro.
            * - Expresión balanceada: { [ a * ( c + d ) ] - 5 }
            * - Expresión no balanceada: { a * ( c + d ) ] - 5 }
            */

            Console.WriteLine("Escribe una expresión por favor:");
            string expresion = Console.ReadLine();
            int contLlaveAbierta = 0;
            int contLlaveCerrada = 0;
            int contCorcheteAbierto = 0;
            int contCorcheteCerrado = 0;
            int contParentesisAbierto = 0;
            int contParentesisCerrado = 0;

            if (expresion.Contains("{") || expresion.Contains("}") || expresion.Contains("[") || expresion.Contains("]") || expresion.Contains("(") || expresion.Contains(")"))
            {
                List<char> chars = expresion.ToCharArray().ToList();
                foreach (var caracter in chars)
                {
                    switch (caracter)
                    {
                        case '{':
                            contLlaveAbierta++;
                            break;
                        case '}':
                            contLlaveCerrada++;
                            break;
                        case '[':
                            contCorcheteAbierto++; 
                            break;
                        case ']':
                            contCorcheteCerrado++;
                            break;
                        case '(':
                            contParentesisAbierto++;
                            break;
                        case ')': 
                            contParentesisCerrado++;
                            break;
                    }
                }
                if (contLlaveAbierta != contLlaveCerrada)
                {
                    int diferencia;

                    if (contLlaveAbierta > contLlaveCerrada)
                    {
                        diferencia = contLlaveAbierta - contLlaveCerrada;

                        for(int i = 0; i < diferencia; i++)
                        {
                            chars.Add('}');
                        }
                    }
                    else
                    {

                    }
                }
                if (contCorcheteAbierto != contCorcheteCerrado)
                {
                    
                }
                if (contParentesisAbierto != contParentesisCerrado)
                {

                }
                expresion = chars.ToString();
            }

            Console.WriteLine(expresion);
            Console.ReadLine();

        }
    }
}
