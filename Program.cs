using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Predicate<int> isEven = delegate (int number)
            {
                return number % 2 == 0;
            };

            Console.WriteLine("Число 4 є парним? " + isEven(4)); 
            Console.WriteLine("Число 7 є парним? " + isEven(7));
        }
    }
}
