using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write any text: ");
        string text = Console.ReadLine();
        
        string [] words = text.Split(' ');
        
        Console.Write("Enter the word you want to find: ");
        string findWord = Console.ReadLine();
        
        int count = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (findWord == words[i])
            {
                count++;
            }
        }
        
        Console.WriteLine($"The word '{findWord}' appears {count} times in the text.");
    }
}