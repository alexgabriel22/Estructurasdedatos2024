using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static HashSet<int> SortedNumbers(HashSet<int> numbers)
    {
        List<int> sortedList = numbers.ToList();
        sortedList.Sort();

        return new HashSet<int>(sortedList);
    }

    static void Main(string[] args)
    {
        HashSet<int> numbers = new HashSet<int> { 5, 3, 8, 1, 9, 2, 7 };

        HashSet<int> sortedSet = SortedNumbers(numbers);

        Console.WriteLine("Sorted numbers:");
        foreach (int num in sortedSet)
        {
            Console.WriteLine(num);
        }
    }
}

