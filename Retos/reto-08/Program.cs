/*
 * Crea un programa que cuente cuantas veces se repite cada palabra
 * y que muestre el recuento final de todas ellas.
 * - Los signos de puntuación no forman parte de la palabra.
 * - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
 * - No se pueden utilizar funciones propias del lenguaje que
 *   lo resuelvan automáticamente.
 */

Console.WriteLine("Escribe un texto");
string text = Console.ReadLine();

if (!string.IsNullOrEmpty(text))
{

    Dictionary<string, int> wordCount = new Dictionary<string, int>();

    string[] words = text.Split(" ");

    foreach (var w in words)
    {
        string cleanedWord = new string(w.Where(x => char.IsLetter(x)).ToArray());
        string lowerCaseWord = cleanedWord.ToLower();

        if (!string.IsNullOrEmpty(lowerCaseWord))
        {
            if (wordCount.ContainsKey(lowerCaseWord))
            {
                wordCount[lowerCaseWord]++;
            }
            else
            {
                wordCount.Add(lowerCaseWord, 1);
            }
        }
    }

    foreach (var w in wordCount)
    {
        if (w.Value == 1)
        
        {
            Console.WriteLine($"Hay {w.Value} palabra: {w.Key}");
        }
        else
        {
            Console.WriteLine($"Hay {w.Value} palabras: {w.Key}");
        }
    }
}
