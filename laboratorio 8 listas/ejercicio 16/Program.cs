using System;
using System.Collections.Generic;

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

    static List<string> FindPalindromes(List<string> words)
    {
        List<string> palindromes = new List<string>();

        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }

        palindromes.Sort();

        return palindromes;
    }

    static void Main(string[] args)
    {
        List<string> words = new List<string> { "radar", "level", "hello", "deified", "world", "stats", "noon" };
        List<string> palindromes = FindPalindromes(words);

        Console.WriteLine("Palíndromos ordenados:");
        foreach (string palindrome in palindromes)
        {
            Console.WriteLine(palindrome);
        }
    }
}
