using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03
{
    public class Backpack
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Fabric { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public List<Item> Contents { get; set; }

        public Backpack()
        {
            Contents = new List<Item>();
        }

        public void AddItem(Item item)
        {
            double currentVolume = 0;
            foreach (var i in Contents)
            {
                currentVolume += i.Volume;
            }

            if (currentVolume + item.Volume > Volume)
            {
                throw new InvalidOperationException("Перевищення об'єму рюкзака!");
            }

            Action<Item> addItem = delegate (Item newItem)
            {
                Contents.Add(newItem);
                Console.WriteLine($"Об'єкт {newItem.Name} додано до рюкзака.");
            };

            addItem(item);
        }
    }
}
