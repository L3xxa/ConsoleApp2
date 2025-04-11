using System;

class Program
{
    static void Main()
    {
        int rows = 10;
        int columns = 10;
        
        int[,] Array2d = new int[rows, columns];
        Random rnd = new Random();
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Array2d[i, j] = rnd.Next(-10, 20); // від -10 до 19
            }
        }
        
        int min = Array2d[0, 0];
        int max = Array2d[0, 0];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (Array2d[i, j] < min)
                    min = Array2d[i, j];
                if (Array2d[i, j] > max)
                    max = Array2d[i, j];
            }
        }
        
        Console.WriteLine("Масив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (Array2d[i, j] == min)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{Array2d[i, j],5}");
                    Console.ResetColor();
                }
                else if (Array2d[i, j] == max)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{Array2d[i, j],5}");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write($"{Array2d[i, j],5}");
                }
            }
            Console.WriteLine();
        }
    }
}