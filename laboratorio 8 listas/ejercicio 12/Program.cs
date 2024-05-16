using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static HashSet<int> SortedNumbersDescending(HashSet<int> numbers)
    {
        var sortedNumbers = numbers.OrderByDescending(num => num);
        return new HashSet<int>(sortedNumbers);
    }

    static void Main(string[] args)
    {
        HashSet<int> numbers = new HashSet<int> { 5, 3, 8, 1, 9, 2, 7 };

        HashSet<int> sortedSet = SortedNumbersDescending(numbers);

        Console.WriteLine("Sorted numbers in descending order:");
        foreach (int num in sortedSet)
        {
            Console.WriteLine(num);
        }
    }
}
