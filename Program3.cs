using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03
{
    class Program3
    {
        delegate int CubeDelegate(int number);

        event CubeDelegate OnCubeCalculated;

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            var program = new Program3();

            CubeDelegate cube = number => number * number * number;

            program.OnCubeCalculated += cube;

            int testNumber = 3;
            int cubeResult = program.CalculateCube(testNumber);
            Console.WriteLine($"Куб числа {testNumber} дорівнює {cubeResult}");
        }

        public int CalculateCube(int number)
        {
            if (OnCubeCalculated != null)
            {
                return OnCubeCalculated(number);
            }
            else
            {
                throw new InvalidOperationException("Немає підписників на подію OnCubeCalculated.");
            }
        }
    }
}
