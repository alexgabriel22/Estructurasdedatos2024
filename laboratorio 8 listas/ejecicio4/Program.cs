using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de uso
        HashSet<int> conjunto1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> conjunto2 = new HashSet<int> { 3, 4, 5, 6, 7 };

        HashSet<int> numerosComunes = ObtenerNumerosComunes(conjunto1, conjunto2);

        Console.WriteLine("Números comunes:");
        foreach (int numero in numerosComunes)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> ObtenerNumerosComunes(HashSet<int> conjunto1, HashSet<int> conjunto2)
    {
        HashSet<int> numerosComunes = new HashSet<int>(conjunto1);
        numerosComunes.IntersectWith(conjunto2);
        return numerosComunes;
    }
}
