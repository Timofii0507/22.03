using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03
{
    public delegate bool IsProgrammerDayDelegate(DateTime date);

    class Program4
    {
        public static event EventHandler DateChecked;

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            IsProgrammerDayDelegate isProgrammerDay = (date) => date.DayOfYear == 256;

            DateChecked += (sender, e) => Console.WriteLine("Дата була перевірена.");

            DateTime testDate = new DateTime(2024, 9, 13); 
            bool result = isProgrammerDay(testDate);
            OnDateChecked(); 

            Console.WriteLine(result ? "Це День програміста!" : "Це не День програміста.");
        }

        protected static void OnDateChecked()
        {
            DateChecked?.Invoke(null, EventArgs.Empty);
        }
    }
}
