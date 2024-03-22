using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _22._03
{
    class Program6
    {
        public delegate int ComparisonDelegate(int a, int b);

        static int Min(int[] array, ComparisonDelegate comparer)
        {
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (comparer(array[minIndex], array[i]) > 0)
                {
                    minIndex = i;
                }
            }
            return array[minIndex];
        }

        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            int[] numbers = { 5, 8, 3, 1, 2, 9, 4, 7, 6 };

            int min = Min(numbers, (a, b) => a - b);

            Console.WriteLine($"Мінімальне значення: {min}");

            min = Min(numbers, (a, b) => b - a);

            Console.WriteLine($"Максимальне значення: {min}");
        }
    }
}