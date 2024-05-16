using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<string> WordsWithLetter(List<string> words, char letter)
    {
        List<string> result = new List<string>();

        foreach (string word in words)
        {
            if (word.Contains(letter))
            {
                result.Add(word);
            }
        }

        result = result.OrderByDescending(w => w).ToList();

        return result;
    }

    static void Main(string[] args)
    {
        List<string> words = new List<string> { "apple", "banana", "pear", "orange", "kiwi", "grape" };
        char targetLetter = 'a';
        List<string> wordsWithLetter = WordsWithLetter(words, targetLetter);

        Console.WriteLine($"Palabras que contienen la letra '{targetLetter}' y ordenadas de mayor a menor:");
        foreach (string word in wordsWithLetter)
        {
            Console.WriteLine(word);
        }
    }
}
