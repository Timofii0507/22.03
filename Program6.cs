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
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            int[] array = { 5, 3, 6, 2, 8 };

            Func<int[], int> findMinimum = (numbers) =>
            {
                int min = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }
                return min;
            };

            int minimum = findMinimum(array);
            Console.WriteLine($"Мінімальне значення в масиві: {minimum}");
        }
    }
}