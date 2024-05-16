using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de uso
        string[] palabras = { "roma", "amor", "perro", "torpe", "arco", "cero", "oso", "soso" };

        Dictionary<string, HashSet<string>> anagramas = EncontrarAnagramas(palabras);

        Console.WriteLine("Anagramas encontrados:");
        foreach (var grupoAnagramas in anagramas)
        {
            Console.WriteLine(string.Join(", ", grupoAnagramas.Value));
        }
    }

    static Dictionary<string, HashSet<string>> EncontrarAnagramas(string[] palabras)
    {
        Dictionary<string, HashSet<string>> anagramas = new Dictionary<string, HashSet<string>>();

        foreach (string palabra in palabras)
        {
            // Convertir la palabra a un arreglo de caracteres, ordenarlos y luego unirlos nuevamente
            // Esto nos permite comparar palabras anagramas aunque estén en diferente orden
            string clave = new string(palabra.OrderBy(c => c).ToArray());

            if (!anagramas.ContainsKey(clave))
            {
                anagramas[clave] = new HashSet<string>();
            }

            anagramas[clave].Add(palabra);
        }

        // Filtrar grupos de anagramas que tengan más de una palabra
        return anagramas.Where(pair => pair.Value.Count > 1)
                        .ToDictionary(pair => pair.Key, pair => pair.Value);
    }
}

