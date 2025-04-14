using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter any text: ");
        string text = Console.ReadLine();
        string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var indecentSet = new HashSet<string>(new[] { "bad", "ugly", "stupid", "idiot", "fool", "dumb", "hate", "moron", "jerk", "bastard", "asshole", "bitch", "damn", "shit", "fuck", "dick", "hell" }, StringComparer.OrdinalIgnoreCase);

        string newText = "";
        foreach (string word in words)
        {
            string cleanWord = Regex.Replace(word, @"[^\w\s]", "");
            if (indecentSet.Contains(cleanWord))
            {
                newText += "**** ";
            }
            else
            {
                newText += word + " ";
            }
        }

        Console.WriteLine($"Filtered text: {newText.Trim()}");
    }
}