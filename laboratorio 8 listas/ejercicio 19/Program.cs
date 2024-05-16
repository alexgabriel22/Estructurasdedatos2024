using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> UniqueSortedNumbers(List<int> numbers)
    {
        // Eliminar duplicados utilizando HashSet
        HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

        // Ordenar los números únicos
        List<int> sortedUniqueNumbers = uniqueNumbers.ToList();
        sortedUniqueNumbers.Sort();

        return sortedUniqueNumbers;
    }

    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
        List<int> uniqueSortedNumbers = UniqueSortedNumbers(numbers);

        Console.WriteLine("Números ordenados y sin duplicados:");
        foreach (int num in uniqueSortedNumbers)
        {
            Console.WriteLine(num);
        }
    }
}

