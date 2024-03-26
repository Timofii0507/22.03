using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03
{
    class Program3
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            Func<int, int> cube = number => number * number * number;

            Console.WriteLine("Куб числа 3: " + cube(3)); 
            Console.WriteLine("Куб числа 4: " + cube(4)); 
        }
    }
}
