using System;

class Program
{
    static void Main()
    {
        int [] arr = new int [20];
        Random random = new Random();

        // Заповнення масиву випадковими числами
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(0, 100);
        }

        int a;
        Console.WriteLine("Введіть число: ");
        a = Convert.ToInt32(Console.ReadLine());

        int min = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr [i] < a)
            {
                min++;
            }
        }
        
        Console.WriteLine("Кількість чисел менших за {0} = {1}", a, min);
        
    }
    
}