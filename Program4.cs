using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03
{
    class Program4
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            Func<DateTime, bool> isProgrammersDay = date => date.DayOfYear == 256;
            DateTime testDate = new DateTime(2024, 9, 12); 
            Console.WriteLine($"Чи є {testDate.ToString("d")} Днем програміста? " + (isProgrammersDay(testDate) ? "Так" : "Ні"));

            testDate = new DateTime(2024, 9, 13); 
            Console.WriteLine($"Чи є {testDate.ToString("d")} Днем програміста? " + (isProgrammersDay(testDate) ? "Так" : "Ні"));
        }
    }
}
