using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de uso
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int divisor = 3;
        HashSet<int> numerosDivisibles = ObtenerNumerosDivisibles(numeros, divisor);

        Console.WriteLine($"Números divisibles por {divisor}:");
        foreach (int numero in numerosDivisibles)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> ObtenerNumerosDivisibles(int[] numeros, int divisor)
    {
        HashSet<int> numerosDivisibles = new HashSet<int>();

        foreach (int numero in numeros)
        {
            if (numero % divisor == 0)
            {
                numerosDivisibles.Add(numero);
            }
        }

        return numerosDivisibles;
    }
}
