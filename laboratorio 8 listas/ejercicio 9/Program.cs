using System;
using System.Collections.Generic;

class Program
{
    static List<string> WordsWithLength(HashSet<string> words, int length)
    {
        List<string> wordsOfLength = new List<string>();

        foreach (string word in words)
        {
            if (word.Length == length)
            {
                wordsOfLength.Add(word);
            }
        }

        return wordsOfLength;
    }

    static void Main(string[] args)
    {
        HashSet<string> words = new HashSet<string> { "apple", "banana", "orange", "pear", "grape" };

        int targetLength = 5;
        List<string> wordsOfLength = WordsWithLength(words, targetLength);

        Console.WriteLine($"Words with length {targetLength}:");
        foreach (string word in wordsOfLength)
        {
            Console.WriteLine(word);
        }
    }
}

