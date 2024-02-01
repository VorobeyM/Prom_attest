using System;

class Program
{
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0 && index < arr.Length)
        {
            Console.Write($"{arr[index]} ");
            PrintArrayReverse(arr, index - 1);
        }
    }

    static void Main()
    {
        int[] numbers = { 61, 52, 36, 43, 54 };

        Console.Write("Элементы массива в обратном порядке: ");
        PrintArrayReverse(numbers, numbers.Length - 1);

        Console.ReadKey();
    }
}
