using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace reto_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //*Escribe una función que reciba dos palabras(String) y retorne
            //*verdadero o falso(Bool) según sean o no anagramas.
            //* -Un Anagrama consiste en formar una palabra reordenando TODAS
            //*las letras de otra palabra inicial.
            //* -NO hace falta comprobar que ambas palabras existan.
            //* -Dos palabras exactamente iguales no son anagrama.

            bool respuesta = Anagrama("aroma", "amora");

            Console.WriteLine(respuesta);
            Console.ReadLine();

            bool Anagrama(string palabra1, string palabra2)
            {
                int cont = 0;

                if (palabra1 == palabra2)
                {
                    return false;
                }
                
                if(palabra1.Length != palabra2.Length)
                {
                    return false;
                }

                char[] array1 = new char[palabra1.Length];
                char[] array2 = new char[palabra2.Length];

                for (int i = 0; i < palabra1.Length; i++)
                {
                    for (int x = 0; x < palabra2.Length; x++)
                    {
                        if (array1[i] == array2[x])
                        {
                            x = palabra2.Length;
                            cont++;
                        }
                        
                    }
                }

                if (cont == palabra1.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
