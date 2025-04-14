using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter any text:");
        string text = Console.ReadLine();

        bool behindChar = true;
        string newText = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                if (behindChar)
                {
                    newText += char.ToUpper(text[i]);
                    behindChar = false;
                }
                else
                {
                    newText += char.ToLower(text[i]);
                }
            }
            else if (text[i] == '.' || text[i] == '!' || text[i] == '?' || text[i] == '\n')
            {
                newText += text[i];
                behindChar = true;
            }
            else
            {
                newText += text[i];
            }
        }
        Console.WriteLine($"New text: {newText}");
    }
}