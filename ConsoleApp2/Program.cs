using System;

class Array1
{
    public int[,] array;
    public int rows = 5;
    public int cols = 5;

    public void Create()
    {
        array = new int[rows, cols];
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(1, 100);
            }
        }
    }
    
    public void Print()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(array[i, j] + "\t");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}

class Array2
{
    public int[,] array;
    public int rows = 5;
    public int cols = 5;

    public void Create()
    {
        array = new int[rows, cols];
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(1, 100);
            }
        }
    }

    public void Print()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(array[i, j] + "\t");
                Console.ResetColor();
            }

            Console.WriteLine();
        }
    }
}

class Menu
{
    public void Show()
    {
        Console.WriteLine("1. Multiplying a matrix by a number");
        Console.WriteLine("2. Adding matrices");
        Console.WriteLine("3. Matrix product");
        Console.WriteLine("4. Exit");
    }
}

class DO
{
    // Множення числа на матрицю
    public void MultiplyingNumber()
    {
        Console.WriteLine("Enter the number to multiply the matrix by: ");
        int number = int.Parse(Console.ReadLine());
        
        Array1 array1 = new Array1();
        array1.Create();
        array1.Print();
        Console.WriteLine("\nResult:");
        for (int i = 0; i < array1.rows; i++)
        {
            for (int j = 0; j < array1.cols; j++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(array1.array[i, j] * number + "\t");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
    
    // Додавання матриць
    public void AddingMatrices()
    {
        Array1 array1 = new Array1();
        Array2 array2 = new Array2();
        
        array1.Create();
        array2.Create();
        
        Console.WriteLine("Matrix 1:");
        array1.Print();
        
        Console.WriteLine("Matrix 2:");
        array2.Print();
        
        Console.WriteLine("\nResult:");
        for (int i = 0; i < array1.rows; i++)
        {
            for (int j = 0; j < array1.cols; j++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(array1.array[i, j] + array2.array[i, j] + "\t");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
    
    public void MyltiplyingMatrices()
    {
        Array1 array1 = new Array1();
        Array2 array2 = new Array2();
        
        array1.Create();
        array2.Create();
        
        Console.WriteLine("Matrix 1:");
        array1.Print();
        
        Console.WriteLine("Matrix 2:");
        array2.Print();
        
        Console.WriteLine("\nResult:");
        for (int i = 0; i < array1.rows; i++)
        {
            for (int j = 0; j < array1.cols; j++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(array1.array[i, j] * array2.array[i, j] + "\t");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
    public void Do()
    {
        int choice = int.Parse(Console.ReadLine());
        
        switch (choice)
        {
            case 1:
                MultiplyingNumber();
                break;
            case 2:
                AddingMatrices();
                break;
            case 3:
                MyltiplyingMatrices();
                break;
            case 4:
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
        
    }
}

class Program
{
    
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.Show();
        DO doo = new DO();
        doo.Do();
    }
}