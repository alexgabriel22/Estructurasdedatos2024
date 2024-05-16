using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (word[left] != word[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

    static List<string> PalindromesWithLength(List<string> words, int length)
    {
        List<string> result = new List<string>();

        foreach (string word in words)
        {
            if (word.Length == length && IsPalindrome(word))
            {
                result.Add(word);
            }
        }

        result.Sort();

        return result;
    }

    static void Main(string[] args)
    {
        List<string> words = new List<string> { "radar", "level", "hello", "deified", "world", "stats", "noon" };
        int targetLength = 5;
        List<string> palindromesWithLength = PalindromesWithLength(words, targetLength);

        Console.WriteLine($"Palíndromos de longitud {targetLength} y ordenados:");
        foreach (string palindrome in palindromesWithLength)
        {
            Console.WriteLine(palindrome);
        }
    }
}
