using System;
class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main()
    {
        int m = 2;
        int n = 1;

        int result = Ackermann(m, n);
        Console.WriteLine($"Значение функции Аккермана  m={m} и n={n}: {result}");

        Console.ReadKey();
    }
}