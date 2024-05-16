using System;
using System.Collections.Generic;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true;
        if (number % 2 == 0)
            return false;

        int boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static List<int> FindPrimes(List<int> numbers)
    {
        List<int> primes = new List<int>();

        foreach (int num in numbers)
        {
            if (IsPrime(num))
            {
                primes.Add(num);
            }
        }

        primes.Sort();

        return primes;
    }

    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 2, 5, 8, 11, 13, 16, 17, 19, 23, 25 };
        List<int> primes = FindPrimes(numbers);

        Console.WriteLine("Números primos y ordenados:");
        foreach (int prime in primes)
        {
            Console.WriteLine(prime);
        }
    }
}
