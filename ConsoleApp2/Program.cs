using System;

class Program
{
    static void GeneratePermutations(string str, int start, int end)
    {
        if (start == end)
        {
            Console.WriteLine(str);
        }
        else
        {
            for (int i = start; i <= end; i++)
            {
                str = Swap(str, start, i);
                GeneratePermutations(str, start + 1, end);
                str = Swap(str, start, i);
            }
        }
    }

    static string Swap(string str, int i, int j)
    {
        char[] charArray = str.ToCharArray();
        char temp = charArray[i];
        charArray[i] = charArray[j];
        charArray[j] = temp;
        return new string(charArray);
    }

    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide a string to generate permutations.");
            return;
        }

        string input = args[0];
        GeneratePermutations(input, 0, input.Length - 1);
    }
}