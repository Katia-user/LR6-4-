using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 12, 8, 23, 81, 5, 19, 77 };
        Console.WriteLine("Масив: " + string.Join(", ", array));
        int minIndex = FindMinIndex(array, 0, array.Length - 1);
        Console.WriteLine("Індекс мінімального елемента: " + minIndex);
        Console.WriteLine("Мінімальний елемент: " + array[minIndex]);
        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
    static int FindMinIndex(int[] array, int start, int end)
    {
        if (start == end)
            return start;
        int minIndexInRest = FindMinIndex(array, start + 1, end);
        if (array[start] < array[minIndexInRest])
            return start;
        else
            return minIndexInRest;
    }
}
