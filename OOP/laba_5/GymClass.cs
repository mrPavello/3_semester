using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace laba_5
{
    internal class Gym<T> where T : Inventory
    {
        private List<T> inventory = new List<T>();
        public List<T> Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }

        public void AddInventory(T item)
        {
            inventory.Add(item);
        }

        public bool RemoveInventory(T item)
        {
            if (inventory.Remove(item)) return true;
            return false;
        }

        public void PrintInventory()
        {
            foreach (var item in  inventory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public void SortByPrice()
        {
            inventory.Sort();
        }

        public Gym<Inventory> SelectByPrice(int minPrice, int maxPrice)
        {
            Gym<Inventory> list = new Gym<Inventory>();
            foreach (var item in inventory)
            {
                if (item.Price >= minPrice && item.Price <= maxPrice)
                {
                    list.AddInventory(item);
                }
            }
            Console.WriteLine($"Товары с соответсующей ценовой категорией от {minPrice} до {maxPrice}:");
            return list;
        }
    }

    internal class GymController
    {
        private Gym<Inventory> gym;
        public int budget {  get; set; }

        public GymController(int budget)
        {
            this.budget = budget;
            gym = new Gym<Inventory>();
        } 
        public void AddInventory(Inventory item)
        {
            if (budget < item.Price * item.Count)
            {
                Console.WriteLine("Недостаточно средств.");
                return;
            }
            gym.AddInventory(item);
            budget -= item.Price * item.Count;
            Console.WriteLine($"Инвентарь {item.Name} добавлен. Количество {item.Count}. Осталось средств {budget}");
        }
        public void RemoveInventory(Inventory item)
        {
            if (gym.RemoveInventory(item))
            {
                budget += item.Price * item.Count;
            }
            Console.WriteLine($"Инвентарь {item.Name} удален. Осталось средств {budget}");
        }
        public void PrintInventory()
        {
            Console.WriteLine("\nИнвентарь:");
            foreach(var item in gym.Inventory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Осталось средств {budget}");
        }

        public void sortByPrice()
        {
            gym.SortByPrice();
        }
    }
}
