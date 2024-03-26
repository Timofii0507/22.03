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
            int[] array = { -1, -3, -2, -4, -3, -2, -1, 5, 7, -8 };

            var uniqueNegativeNumbers = array.Where(n => n < 0).Distinct();

            Console.WriteLine("Унікальні негативні числа:");
            foreach (var number in uniqueNegativeNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}