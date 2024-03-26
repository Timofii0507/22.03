using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _22._03
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            int[] array = { -1, 2, 3, -4, 5, -6, 7 };

            Func<int[], int> countPositiveNumbers = (numbers) => numbers.Count(n => n > 0);

            int count = countPositiveNumbers(array);
            Console.WriteLine($"Кількість позитивних чисел у масиві: {count}");
        }
    }
}