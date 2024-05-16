﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de uso
        HashSet<int> conjunto1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> conjunto2 = new HashSet<int> { 3, 4, 5, 6, 7 };

        HashSet<int> numerosDiferentes = ObtenerNumerosDiferentes(conjunto1, conjunto2);

        Console.WriteLine("Números en el segundo conjunto pero no en el primero:");
        foreach (int numero in numerosDiferentes)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> ObtenerNumerosDiferentes(HashSet<int> conjunto1, HashSet<int> conjunto2)
    {
        HashSet<int> numerosDiferentes = new HashSet<int>(conjunto2);
        numerosDiferentes.ExceptWith(conjunto1);
        return numerosDiferentes;
    }
}

