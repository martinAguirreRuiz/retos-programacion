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

            //bool respuesta = Anagrama("aroma", "amora");

            //Console.WriteLine(respuesta);
            //Console.ReadLine();

            //bool Anagrama(string palabra1, string palabra2)
            //{
            //    int cont = 0;

            //    if (palabra1 == palabra2)
            //    {
            //        return false;
            //    }

            //    if(palabra1.Length != palabra2.Length)
            //    {
            //        return false;
            //    }

            //    char[] array1 = new char[palabra1.Length];
            //    char[] array2 = new char[palabra2.Length];

            //    for (int i = 0; i < palabra1.Length; i++)
            //    {
            //        for (int x = 0; x < palabra2.Length; x++)
            //        {
            //            if (array1[i] == array2[x])
            //            {
            //                x = palabra2.Length;
            //                cont++;
            //            }

            //        }
            //    }

            //    if (cont == palabra1.Length)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}

            /*
            * Crea una función que reciba dos cadenas como parámetro (str1, str2)
            * e imprima otras dos cadenas como salida (out1, out2).
            * - out1 contendrá todos los caracteres presentes en la str1 pero NO
            *   estén presentes en str2.
            * - out2 contendrá todos los caracteres presentes en la str2 pero NO
            *   estén presentes en str1.
            */

            (string rdo1, string rdo2) = Expresiones("hola", "capo");
            Console.WriteLine(rdo1);
            Console.WriteLine(rdo2);
            Console.ReadLine();

            (string,string) Expresiones(string cadena1, string cadena2)
            {
                List<char> lista1 = cadena1.ToCharArray().ToList();
                List<char> lista2 = cadena2.ToCharArray().ToList();

                List<char> listaAux1 = new List<char>();
                List<char> listaAux2 = new List<char>();

                foreach (char c in lista1) //HL
                {
                    foreach (char c2 in lista2) //CP
                    {
                        if (c == c2)
                        {
                            listaAux1.Add(c);
                            listaAux2.Add(c2);
                        }
                    }
                }

                foreach (char c in listaAux1)
                {
                    lista1.Remove(c);
                }
                foreach (char c in listaAux2)
                {
                    lista2.Remove(c);
                }

                string resultado1 = new string(lista1.ToArray());
                string resultado2 = new string(lista2.ToArray());

                return (resultado1, resultado2);
            }

        }
    }
}
