using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace reto_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Crea una única función (importante que sólo sea una) que sea capaz
            * de calcular y retornar el área de un polígono.
            * - La función recibirá por parámetro sólo UN polígono a la vez.
            * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
            * - Imprime el cálculo del área de un polígono de cada tipo.
            */

            //cuadrado = 1; triangulo = 2; rectangulo = 3

            Console.WriteLine("Ingresa 1 (cuadrado), 2 (rectángulo) o 3 (triángulo) para saber su área:");
            int num = int.Parse(Console.ReadLine());

            float rdo = AreaPoligono(num);

            if (rdo == 0)
            {
                Console.WriteLine("Hubo un error, volver a iniciar el programa");
            }
            else if (num == 1)
            {
                Console.WriteLine("El área del cuadrado es: " + rdo);
            }else if (num == 2)
            {
                Console.WriteLine("El área del rectángulo es: " + rdo);
            }
            else
            {
                Console.WriteLine("El área del triángulo es: " + rdo);
            }
            Console.ReadLine();

            float AreaPoligono(int poligono)
            {
                float area;

                if (poligono == 1)
                {
                    Console.WriteLine("Medida de los lados del cuadrado:");
                    area = float.Parse(Console.ReadLine());
                    area = area * area;
                    return area;
                }
                else if (poligono == 2)
                {
                    Console.WriteLine("Medida de la base del rectángulo:");
                    float basee = float.Parse(Console.ReadLine());
                    Console.WriteLine("Medida de la altura del rectángulo:");
                    float altura = float.Parse(Console.ReadLine());
                    area = basee * altura;
                    return area;

                }
                else if (poligono == 3)
                {
                    Console.WriteLine("Medida de la base del triángulo:");
                    float basee = float.Parse(Console.ReadLine());
                    Console.WriteLine("Medida de la altura del triángulo:");
                    float altura = float.Parse(Console.ReadLine());
                    area = (basee * altura) / 2;
                    return area;
                }
                else
                {
                    Console.WriteLine("Solo se pueden seleccionar las opciones mencionadas previamente");
                    float error = 0;
                    return error;
                }
            }




        }
    }
}
