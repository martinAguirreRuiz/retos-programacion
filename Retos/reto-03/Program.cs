using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //*Escribe un programa que imprima los 50 primeros números de la sucesión
            //* de Fibonacci empezando en 0.
            //* -La serie Fibonacci se compone por una sucesión de números en
            //*la que el siguiente siempre es la suma de los dos anteriores.
            //* 0, 1, 1, 2, 3, 5, 8, 13...

            //int num = 1;
            //int num2 = 0;
            //int num3 = 0;

            //Console.WriteLine("0");

            //while (num <= 50)
            //{

            //    num = num2 + num3;
            //    Console.WriteLine(num);
            //    num3 = num2;
            //    num2 = num;

            //}

            //Console.ReadLine();

            int num = 0;
            int num2 = 0;
            int num3 = 1;

            Console.WriteLine(num);
            num++;
            Console.WriteLine(num);

            while (num < 51)
            {
                num = num2 + num3;
                Console.WriteLine(num);
                num2 = num3;
                num3 = num;
            }

            Console.ReadLine();
        }
    }
}
