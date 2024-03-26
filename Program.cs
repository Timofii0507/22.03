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
            Backpack myBackpack = new Backpack
            {
                Color = "Червоний",
                Brand = "High Sierra",
                Fabric = "Нейлон",
                Weight = 0.5,
                Volume = 30
            };

            try
            {
                myBackpack.AddItem(new Item("Книга", 1.5));
                myBackpack.AddItem(new Item("Пляшка води", 2.0));
                myBackpack.AddItem(new Item("Намет", 35.0));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}