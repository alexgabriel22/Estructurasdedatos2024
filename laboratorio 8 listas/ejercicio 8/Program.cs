using System;
using System.Collections.Generic;

class Program
{
    static HashSet<string> Palindromes(HashSet<string> words)
    {
        HashSet<string> palindromes = new HashSet<string>();

        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }

        return palindromes;
    }

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

    static void Main(string[] args)
    {
        HashSet<string> words = new HashSet<string> { "ana", "oso", "casa", "reconocer", "arriba", "radar" };

        HashSet<string> palindromes = Palindromes(words);

        Console.WriteLine("Palíndromos encontrados:");
        foreach (string palindrome in palindromes)
        {
            Console.WriteLine(palindrome);
        }
    }
}
