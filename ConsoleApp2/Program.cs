using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Array and Multiplication ===");

        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        Console.Write("Enter a multiplier: ");
        int multiplier = int.Parse(Console.ReadLine());

        int[,] array = new int[rows, columns];
        Random rand = new Random();

        Console.WriteLine("\nOriginal array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = rand.Next(1, 10); 
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine($"\nArray multiplied by {multiplier}:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] *= multiplier;
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}