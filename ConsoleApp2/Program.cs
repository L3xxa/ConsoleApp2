using System;
using System.Collections.Generic;

class Array1
{
    public static int[] createArray()
    {
        int size1 = 10;
        int[] arr = new int[size1];
        Random rand = new Random();

        Console.WriteLine("Перший масив:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(-10, 20);
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        return arr;
    }
}

class Array2
{
    public static int[] createArray()
    {
        int size2 = 10;
        int[] arr = new int[size2];
        Random rand = new Random();

        Console.WriteLine("Другий масив:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(-10, 20);
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        return arr;
    }
}

class Array3
{
    public static void createArray()
    {
        int[] arr1 = Array1.createArray();
        int[] arr2 = Array2.createArray();

        List<int> uniqueElements = new List<int>();

        foreach (int item in arr1)
        {
            if (!uniqueElements.Contains(item))
            {
                uniqueElements.Add(item);
            }
        }

        foreach (int item in arr2)
        {
            if (!uniqueElements.Contains(item))
            {
                uniqueElements.Add(item);
            }
        }
        
        int[] resultArray = uniqueElements.ToArray();
        
        Console.WriteLine("Третій масив без повторів:");
        foreach (int num in resultArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Array3.createArray();
    }
}
