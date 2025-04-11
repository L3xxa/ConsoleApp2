using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a string for frequency analysis:");
        string input = Console.ReadLine();

        Dictionary<char, int> frequency = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (frequency.ContainsKey(c))
            {
                frequency[c]++;
            }
            else
            {
                frequency[c] = 1;
            }
        }

        foreach (var item in frequency)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}