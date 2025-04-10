using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[] { 1, 4, 4, 7, 5, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1 };

        int parne = 0;
        int neparne = 0;
        bool allUnique = true;

        Console.Write("Унікальні елементи: ");

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
                parne++;
            else
                neparne++;
            
            bool isUnique = true;
            for (int j = 0; j < arr.Length; j++)
            {
                if (i != j && arr[i] == arr[j])
                {
                    isUnique = false;
                    break;
                }
            }

            if (isUnique)
            {
                Console.Write(arr[i] + " ");
            }
            else
            {
                allUnique = false;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Парних чисел: " + parne);
        Console.WriteLine("Непарних чисел: " + neparne);
    }
}