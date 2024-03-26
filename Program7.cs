using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _22._03
{
    class Program7
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Func<int, bool> isOdd = n => n % 2 != 0;

            var oddNumbers = array.Where(isOdd);

            Console.WriteLine("Непарні числа в масиві:");
            foreach (var number in oddNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}