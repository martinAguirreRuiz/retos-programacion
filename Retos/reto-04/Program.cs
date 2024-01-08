using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //* Escribe un programa que se encargue de comprobar si un número es o no primo.
            //* Hecho esto, imprime los números primos entre 1 y 100.


            Console.WriteLine("Ingresa un número para verificar si es primo o no:");
            string num = Console.ReadLine();

            int numero = int.Parse(num);
            int cont = 1;
            int verificador = 0;

            while (cont <= numero)
            {
                if (numero % cont == 0)
                {
                    verificador++;
                }
                cont++;
            }

            if (verificador == 2 || numero == 1)
            {
                Console.WriteLine("El número ingresado sí es primo");
            }
            else
            {
                Console.WriteLine("El número ingresado no es primo");
            }

            Console.WriteLine("Lista de números primos del 1 al 100:");
            Console.WriteLine("1");

            for (int i = 1; i < 101; i++)
            {
                cont = 1;
                verificador = 0;

                while (cont <= i)
                {
                    if (i % cont == 0)
                    {
                        verificador++;
                    }
                    cont++;
                }
                if (verificador == 2)
                {
                    Console.WriteLine(i.ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
