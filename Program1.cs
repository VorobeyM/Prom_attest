using System;

class Program
{
    static void PrintNumbers(int M, int N)
    {
        if (M <= N)
        {
            Console.Write($"{M} ");
            PrintNumbers(M + 1, N);
        }
    }

    static void Main()
    {
        int M = 3;
        int N = 16;

        Console.Write($"Натуральные числа от {M} до {N}: ");
        PrintNumbers(M, N);

        Console.ReadKey();
    }
}