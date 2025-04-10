using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array:");
        int a = Convert.ToInt32(Console.ReadLine());
        
        int [] arr = new int [a];
        Random rnd = new Random();
        
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 10);
        }
        
        Console.WriteLine("Enter 3 numbers separated by a space (from 1 to 10):");
        string[] parts = Console.ReadLine().Split(' ');
        
        if (parts.Length != 3)
        {
            Console.WriteLine("You entered an incorrect number of numbers.");
            return;
        }
        
        foreach (string part in parts)
        {
            if (!int.TryParse(part, out int number) || number < 1 || number > 10)
            {
                Console.WriteLine("You entered an incorrect number.");
                return;
            }
        }

        int num1 = Convert.ToInt32(parts[0]);
        int num2 = Convert.ToInt32(parts[1]);
        int num3 = Convert.ToInt32(parts[2]);

        Console.WriteLine($"Ви ввели: {num1}, {num2}, {num3}");
        
        
        // Перевірка чи є такі числа в масиві
        int count = 0;
        for (int i = 0; i < arr.Length - 2; i++) // -2, щоб не вийти за межі масиву
        {
            if (arr[i] == num1 && arr[i + 1] == num2 && arr[i + 2] == num3)
            {
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("В масиві немає таких чисел.");
        }
        else
        {
            Console.WriteLine($"В масиві є {count} чисел з ваших трьох.");
        }
    }
}