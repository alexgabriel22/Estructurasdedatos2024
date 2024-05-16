using System;
using System.Collections.Generic;

class Program
{
    static List<string> WordsWithLength(List<string> words, int length)
    {
        List<string> result = new List<string>();

        foreach (string word in words)
        {
            if (word.Length == length)
            {
                result.Add(word);
            }
        }

        result.Sort();

        return result;
    }

    static void Main(string[] args)
    {
        List<string> words = new List<string> { "apple", "banana", "pear", "orange", "kiwi", "grape" };
        int targetLength = 5;
        List<string> wordsWithLength = WordsWithLength(words, targetLength);

        Console.WriteLine($"Palabras de longitud {targetLength} y ordenadas:");
        foreach (string word in wordsWithLength)
        {
            Console.WriteLine(word);
        }
    }
}
