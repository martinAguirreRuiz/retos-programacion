/*
 * Crea un programa que invierta el orden de una cadena de texto
 * sin usar funciones propias del lenguaje que lo hagan de forma automática.
 * - Si le pasamos "Hola mundo" nos retornaría "odnum aloH"
 */

Console.WriteLine("Escribe algo: ");
string? texto = Console.ReadLine();

char[] cadenaCaracteres = texto.ToCharArray();
int longitud = cadenaCaracteres.Length;
char[] cadenaAux = new char[longitud];

for (int i = 0; i < cadenaCaracteres.Length; i++)
{
    cadenaAux[i] = cadenaCaracteres[longitud - 1];
    longitud--;

    if (i == cadenaCaracteres.Length - 1)
    {
        string nuevaCadena = new string(cadenaAux);
        Console.WriteLine(nuevaCadena);
    }
}




