using System;

class MyClass
{
    static void Main(string[] args)
    {
        Console.Write("Write any text: ");
        string input = Console.ReadLine();
        
        string[] words = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        
        Console.WriteLine("Words in the input:" + words.Length);
    }
    
}