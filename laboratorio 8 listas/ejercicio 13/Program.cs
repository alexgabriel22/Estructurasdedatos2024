using System;
using System.Collections.Generic;

class Program
{
    static HashSet<int> FindDuplicates(int[] numbers)
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

        return duplicates;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 10, 10 };
        HashSet<int> duplicates = FindDuplicates(numbers);

        Console.WriteLine("Números duplicados:");
        foreach (int num in duplicates)
        {
            Console.WriteLine(num);
        }
    }
}

