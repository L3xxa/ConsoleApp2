using System;

class Matrix
{
    // Створення масиву випадкових чисел
    public int[,] CreateArray(int rows = 5, int columns = 5)
    {
        int[,] arr = new int[rows, columns];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                arr[i, j] = random.Next(-100, 100);
            }
        }

        return arr; 
    }

    // Друк масиву на екран
    public void PrintArray(int[,] arr)
    {
        int rows = arr.GetLength(0); 
        int columns = arr.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine(); 
        }
    }

    // Обчислення суми елементів між мінімальним і максимальним значенням
    public void SumBetweenMinMax(int[,] arr)
    {
        int rows = arr.GetLength(0); 
        int columns = arr.GetLength(1);

        int max = arr[0, 0];
        int min = arr[0, 0];

        // Знаходимо мінімальне та максимальне значення
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (arr[i, j] > max) max = arr[i, j];
                if (arr[i, j] < min) min = arr[i, j];
            }
        }

        int sum = 0;

        // Обчислюємо суму елементів, що знаходяться між мінімальним і максимальним значеннями
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int value = arr[i, j];
                if (value > min && value < max)
                {
                    sum += value;
                }
            }
        }

        // Виведення результатів
        Console.WriteLine($"Min: {min}, Max: {max}");
        Console.WriteLine($"Сума елементів між Min і Max: {sum}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Matrix matrix = new Matrix();
        
        // Створення масиву
        int[,] myMatrix = matrix.CreateArray();
        
        // Друк масиву на екран
        matrix.PrintArray(myMatrix);
        
        // Обчислення суми елементів між Min і Max
        matrix.SumBetweenMinMax(myMatrix);
    }
}
