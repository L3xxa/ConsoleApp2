using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter an expression (for example, 10+5-3): ");
        string expression = Console.ReadLine();
        
        int result = 0;
        int number = 0;
        char operation = '+';

        for (int i = 0; i <= expression.Length; i++)
        {
            if (i < expression.Length && char.IsDigit(expression[i]))
            {
                number = number * 10 + (expression[i] - '0');
            }
            else if (i == expression.Length || expression[i] == '+' || expression[i] == '-')
            {
                if (operation == '+')
                {
                    result += number;
                }
                else if (operation == '-')
                {
                    result -= number;
                }
                if (i < expression.Length)
                    operation = expression[i];

                number = 0;
            }
        }
            
        Console.WriteLine($"Result: {result}");
    }
}