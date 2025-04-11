using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write any text: ");
        string input = Console.ReadLine();

        int Vowel = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'a' || 
                input[i] == 'e' ||
                input[i] == 'i' ||
                input[i] == 'o' ||
                input[i] == 'u')
            {
                Vowel++;
            }
            
            
        }
        Console.Write("The number of vowels in the text is: ");
        Console.WriteLine(Vowel);
    }
}