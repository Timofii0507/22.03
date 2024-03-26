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
            Func<string, string, bool> containsWord = (text, word) => text.Contains(word);

            string sampleText = "Це приклад рядка для тестування.";
            string wordToFind = "приклад";

            bool result = containsWord(sampleText, wordToFind);
            Console.WriteLine($"Чи містить рядок слово '{wordToFind}': {result}");
        }
    }
}