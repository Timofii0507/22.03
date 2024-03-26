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
            Dictionary<string, (int, int, int)> rainbowColors = new Dictionary<string, (int, int, int)>
        {
            {"Червоний", (255, 0, 0)},
            {"Помаранчевий", (255, 165, 0)},
            {"Жовтий", (255, 255, 0)},
            {"Зелений", (0, 128, 0)},
            {"Блакитний", (0, 0, 255)},
            {"Індиго", (75, 0, 130)},
            {"Фіолетовий", (238, 130, 238)}
        };

            Func<string, (int, int, int)> getRainbowColor = (colorName) =>
            {
                if (rainbowColors.TryGetValue(colorName, out var rgb))
                {
                    return rgb;
                }
                else
                {
                    throw new ArgumentException("Невідомий колір");
                }
            };

            try
            {
                var colorName = "Зелений";
                var rgbValue = getRainbowColor(colorName);
                Console.WriteLine($"RGB значення для кольору {colorName}: ({rgbValue.Item1}, {rgbValue.Item2}, {rgbValue.Item3})");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}