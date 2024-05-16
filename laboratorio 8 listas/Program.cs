using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de uso
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        HashSet<int> primos = ObtenerNumerosPrimos(numeros);

        Console.WriteLine("Números primos:");
        foreach (int primo in primos)
        {
            Console.WriteLine(primo);
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;

        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }

    static HashSet<int> ObtenerNumerosPrimos(int[] numeros)
    {
        HashSet<int> primos = new HashSet<int>();

        foreach (int numero in numeros)
        {
            if (EsPrimo(numero))
                primos.Add(numero);
        }

        return primos;
    }
}
