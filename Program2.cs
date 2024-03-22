using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03
{
    class Program2
    {
        delegate int SquareDelegate(int num);

        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            SquareDelegate square = delegate (int num)
            {
                return num * num;
            };

            int number = 4;
            int result = square(number);
            Console.WriteLine("Квадрат числа {0} дорівнює {1}", number, result);
        }
    }
}
