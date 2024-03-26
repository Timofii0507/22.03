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
            int[] array = { 14, 21, 28, 4, 7, 35, 42 };
            Func<int[], int> countMultiplesOfSeven = (numbers) =>
            {
                int count = 0;
                foreach (var num in numbers)
                {
                    if (num % 7 == 0)
                        count++;
                }
                return count;
            };

            int result = countMultiplesOfSeven(array);
            Console.WriteLine($"Кількість чисел кратних семи: {result}");
        }
    }
}