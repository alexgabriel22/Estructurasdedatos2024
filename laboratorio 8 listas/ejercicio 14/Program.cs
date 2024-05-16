using System;
using System.Collections.Generic;

class Program
{
    static HashSet<int> FindUniqueNumbers(int[] numbers)
    {
        HashSet<int> uniqueNumbers = new HashSet<int>();
        HashSet<int> duplicates = new HashSet<int>();

        foreach (int num in numbers)
        {
            // Si el número ya está en uniqueNumbers, es un duplicado
            if (!uniqueNumbers.Add(num))
            {
                duplicates.Add(num);
            }
        }

        HashSet<int> uniqueSet = new HashSet<int>();
        foreach (int num in numbers)
        {
            // Si el número no está en el conjunto de duplicados, se agrega al conjunto de números únicos
            if (!duplicates.Contains(num))
            {
                uniqueSet.Add(num);
            }
        }

        return uniqueSet;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 10, 10 };
        HashSet<int> uniqueNumbers = FindUniqueNumbers(numbers);

        Console.WriteLine("Números no duplicados:");
        foreach (int num in uniqueNumbers)
        {
            Console.WriteLine(num);
        }
    }
}


