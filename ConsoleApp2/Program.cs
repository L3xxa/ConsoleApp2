using System;
using System.Drawing;

class ArrayA
{ 
    
    int size = 5;
    int [] arr1 = new int[5];
    
    public ArrayA()
    {
        Console.Write("Enter 5 array elements: ");
        for (int i = 0; i < size; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
    }
    public void PrintArrayA()
    {
        Console.WriteLine("Array A:");
        for (int i = 0; i < size; i++)
        {
            Console.Write("{0} ", arr1[i]);
        }
        Console.WriteLine("\n");
    }

    public void MaxMin()
    {
        int max = arr1[0];
        int min = arr1[0];

        for (int i = 1; i < size; i++)
        {
            if (arr1[i] > max)
            {
                max = arr1[i];
            }
            if (arr1[i] < min)
            {
                min = arr1[i];
            }   
        }
        Console.WriteLine("Max: {0}", max);
        Console.WriteLine("Min: {0}", min);
    }
    
    public void Sum()
    {
        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            sum += arr1[i];
        }
        Console.WriteLine("Sum: {0}", sum);
    }

    public void Dobutok()
    {
        int dobutok = 1;
        for (int i = 0; i < size; i++)
        {
            dobutok *= arr1[i];
        }
        Console.WriteLine("Product: {0}", dobutok);
    }

    public void Even()
    {
        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            if (arr1[i] % 2 == 0)
            {
                sum += arr1[i];
            }
        }
        Console.WriteLine("Sum of even numbers: {0}", sum);
    }

    public void Info()
    {
        Console.WriteLine("=== Array Information ===");
        PrintArrayA();
        MaxMin();
        Sum();
        Even();
        Dobutok(); 
        Console.WriteLine("==========================");
    }
}

class ArrayB
{
    int rows = 3;
    int cols = 4;
    double[,] arr2 = new double[3, 4];
    Random rand = new Random();
    
    public ArrayB()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr2[i, j] = rand.Next(1, 100);
            }
        }
    }

    public void PrintArrayB()
    {
        Console.WriteLine("Array B:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0,6:F2} ", arr2[i, j]);
            }
            Console.WriteLine();
            
        }
        Console.WriteLine("\n");
    }

    public void MaxMin()
    {
        double max = arr2[0, 0];
        double min = arr2[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (arr2[i, j] > max)
                {
                    max = arr2[i, j];
                }
                if (arr2[i, j] < min)
                {
                    min = arr2[i, j];
                }
            }
        }
        Console.WriteLine("Max: {0:F2}", max);
        Console.WriteLine("Min: {0:F2}", min);      
    }
    
    public void Sum()
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum += arr2[i, j];
            }
        }
        Console.WriteLine("Sum: {0:F2}", sum);
    }
    
    public void Dobutok()
    {
        double dobutok = 1;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                dobutok *= arr2[i, j];
            }
        }
        Console.WriteLine("Product: {0:F2}", dobutok);
    }
    
    public void Even()
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (arr2[i, j] % 2 == 0)
                {
                    sum += arr2[i, j];
                }
            }
        }
        Console.WriteLine("Sum of even numbers: {0:F2}", sum);
    }
    
    public void Info()
    {
        Console.WriteLine("=== Array Information ===");
        PrintArrayB();
        MaxMin();
        Sum();
        Even();
        Dobutok(); 
        Console.WriteLine("==========================");
    }
    
}
class Program
{
    static void Main(string[] args)
    {
        ArrayA arr1 = new ArrayA();
        ArrayB arr2 = new ArrayB();
        arr1.Info();
        arr2.Info();
    }
}