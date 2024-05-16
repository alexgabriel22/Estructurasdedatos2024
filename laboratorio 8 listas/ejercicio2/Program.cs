using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de uso
        string[] palabras = { "gato", "perro", "girasol", "elefante", "zorro", "manzana" };
        char letraInicio = 'g';
        HashSet<string> palabrasConLetra = ObtenerPalabrasConLetra(palabras, letraInicio);

        Console.WriteLine($"Palabras que comienzan con '{letraInicio}':");
        foreach (string palabra in palabrasConLetra)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> ObtenerPalabrasConLetra(string[] palabras, char letra)
    {
        HashSet<string> palabrasConLetra = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.StartsWith(letra.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                palabrasConLetra.Add(palabra);
            }
        }

        return palabrasConLetra;
    }
}
