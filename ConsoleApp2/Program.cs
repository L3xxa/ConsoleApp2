using System;
using System.Text;

class Tsezar
{
    public string ProcessText(string text, int key, bool decrypt = false)
    {
        if (decrypt)
            key = -key;

        StringBuilder result = new StringBuilder();

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                char shifted = (char)(((c - offset + key + 26) % 26) + offset);
                result.Append(shifted);
            }
            else if (char.IsDigit(c))
            {
                char shifted = (char)(((c - '0' + key + 10) % 10) + '0');
                result.Append(shifted);
            }
            else
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }

    static void Main()
    {
        Tsezar tsezar = new Tsezar();

        Console.WriteLine("<-------------> Caesar Cipher <------------->");
        Console.Write("Enter the text: ");
        string inputText = Console.ReadLine();

        int key;
        while (true)
        {
            Console.Write("Enter a numeric key (e.g. 3): ");
            if (int.TryParse(Console.ReadLine(), out key))
                break;
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        Console.Write("Encrypt or Decrypt (E/D): ");
        string choice = Console.ReadLine().Trim().ToUpper();

        bool decrypt = choice == "D";

        string result = tsezar.ProcessText(inputText, key, decrypt);

        Console.WriteLine();
        Console.WriteLine(decrypt ? "Decrypted text:" : "Encrypted text:");
        Console.WriteLine(result);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}