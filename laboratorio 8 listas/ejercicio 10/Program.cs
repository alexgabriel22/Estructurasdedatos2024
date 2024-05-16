using System;
using System.Collections.Generic;

class Program
{
    static List<string> WordsContainingLetter(HashSet<string> words, char letter)
    {
        List<string> wordsWithLetter = new List<string>();

        foreach (string word in words)
        {
            if (word.Contains(letter))
            {
                wordsWithLetter.Add(word);
            }
        }

        return wordsWithLetter;
    }

    static void Main(string[] args)
    {
        HashSet<string> words = new HashSet<string> { "apple", "banana", "orange", "pear", "grape" };

        char targetLetter = 'a';
        List<string> wordsWithLetter = WordsContainingLetter(words, targetLetter);

        Console.WriteLine($"Words containing the letter '{targetLetter}':");
        foreach (string word in wordsWithLetter)
        {
            Console.WriteLine(word);
        }
    }
}
