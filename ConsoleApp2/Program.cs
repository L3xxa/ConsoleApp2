using System;

class Tsezar
{
    // Метод для шифрування
    public string Encryption()
    {
        Console.WriteLine("<-------------> Tsezar <------------->");
        Console.WriteLine("Enter the text to encrypt:");
        string text = Console.ReadLine();
        Console.Write("Enter a key: ");
        int key = Convert.ToInt32(Console.ReadLine());
        
        string encryptedText = "";
        foreach (char c in text)
        {
            if (char.IsLetter(c)) // Шифруємо літери
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                char encryptedChar = (char)(((c - offset + key) % 26) + offset);
                encryptedText += encryptedChar;
            }
            else if (char.IsDigit(c)) // Шифруємо цифри
            {
                char encryptedDigit = (char)(((c - '0' + key) % 10) + '0');
                encryptedText += encryptedDigit;
            }
            else // Інші символи залишаємо як є
            {
                encryptedText += c;
            }
        }
        return encryptedText;
    }
    
    // Метод для розшифрування
    public string Decryption(string encryptedText, int key)
    {
        string decryptedText = "";
        foreach (char c in encryptedText)
        {
            if (char.IsLetter(c)) // Розшифровуємо літери
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                char decryptedChar = (char)(((c - offset - key + 26) % 26) + offset);
                decryptedText += decryptedChar;
            }
            else if (char.IsDigit(c)) // Розшифровуємо цифри
            {
                char decryptedDigit = (char)(((c - '0' - key + 10) % 10) + '0');
                decryptedText += decryptedDigit;
            }
            else // Інші символи залишаємо як є
            {
                decryptedText += c;
            }
        }
        return decryptedText;
    }
    
    static void Main(string[] args)
    {
        Tsezar tsezar = new Tsezar();
        
        // Шифруємо текст
        string encryptedText = tsezar.Encryption();
        Console.WriteLine("Encrypted text: " + encryptedText);
        
        Console.WriteLine("Do you want to decrypt the text? (y/n)");
        string answer = Console.ReadLine();
        if (answer.ToLower() == "y")
        {
            // Задаємо ключ для розшифрування
            Console.Write("Enter the key to decrypt: ");
            int key = Convert.ToInt32(Console.ReadLine());
            
            // Розшифровуємо
            string decryptedText = tsezar.Decryption(encryptedText, key);
            Console.WriteLine("Decrypted text: " + decryptedText);
        }
        else
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
