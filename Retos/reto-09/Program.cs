/*
 * Crea un programa se encargue de transformar un número
 * decimal a binario sin utilizar funciones propias del lenguaje que lo hagan directamente.
 */

Console.WriteLine("Ingrese un número entero por favor");
int num = int.Parse(Console.ReadLine());
string binario = "";

while (num > 1)
{
    int resto = num % 2;
    binario = resto.ToString() + binario;
    num = num / 2;
    if (num == 1)
    {
        binario = "1" + binario;
    }
}

Console.WriteLine(binario);
