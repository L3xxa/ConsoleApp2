using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write any text: ");
        string text = Console.ReadLine();
        
        string reversedWords = ReverseEachWord(text);
        Console.WriteLine("Reversed text: " + reversedWords);
    }

    static string ReverseEachWord(string input)
    {
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            char[] chars = words[i].ToCharArray();
            Array.Reverse(chars);
            words[i] = new string(chars);
        }
        return string.Join(" ", words);
    }
}