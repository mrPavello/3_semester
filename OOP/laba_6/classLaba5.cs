using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba_6
{
    public interface IDescriptionInventory
    {
        string Description {  get; }
    }
    public abstract partial class Inventory : IDescriptionInventory
    {
        public virtual string Name { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public InventoryState State { get; set; }

        public Inventory(string name, int count, int price)
        {
            if (name == null) throw new ArgumentNullException("Ошибка! Аргумент не может быть пустым.");
            if (name.Length == 0) throw new InvalidArgument<string>("Ошибка! Недопустимое значение аргумента: пустая строка.", name);
            if (name.Length > 40) throw new InvalidArgument<string>("Ошибка! Недопустимое значение аргумента: слишком длинное имя.", name);
            Debug.Assert(count >= 0, "\nОшибка! Количество инвенторя не может быть отрицательным.\n");
            Debug.Assert(price >= 0, "\nОшибка! Цена не может быть отрицателььной.\n");
            Name = name;
            Count = count;
            State = InventoryState.Good;
            Price = price;
        }

        public enum InventoryState
        {
            Bad,
            Good
        }

        public abstract string Description { get; }
    }

    public class Bench : Inventory
    {
        public Bench(string name, int count, int price) : base(name, count, price) { }
        public override void Application()
        {
            Console.WriteLine("Скамейка, чаще всего, используется в силовых тренировках, особенно для выполнения жимов лежа.");
        }

        public override string Description
        {
            get { 
                return $"Тип: название: {Name}, количество: {Count}, цена: {Price}"; 
            }
        }
    }

    public class Bars : Inventory
    {
        public Bars(string name, int count, int price) : base(name, count, price) { }
        public override void Application()
        {
            Console.WriteLine("Брусья предназначены для выполнения упражнений на верхнюю часть тела, включая отжимания и подтягивания.");
        }

        public override string Description
        {
            get
            {
                return $"Тип: название: {Name}, количество: {Count}, цена: {Price}";
            }
        }
    }

    public class Ball : Inventory
    {
        public Ball(string name, int count, int price) : base(name, count, price) { }
        public override void Application()
        {
            Console.WriteLine("Спортивные мячи используются в различных видах спорта, таких как футбол, волейбол, плавание и многие другие.");
        }

        public override string Description
        {
            get
            {
                return $"Тип: название: {Name}, количество: {Count}, цена: {Price}";
            }
        }
    }

    public class Mats : Inventory
    {
        public Mats(string name, int count, int price) : base(name, count, price) { }
        public override void Application()
        {
            Console.WriteLine("Маты обычно используются в гимнастике, йоге, боевых искусствах и других видах физической активности, где происходит работа на полу.");
        }

        public override string Description
        {
            get
            {
                return $"Тип: название: {Name}, количество: {Count}, цена: {Price}";
            }
        }
    }

    public class BasketballBall : Inventory
    {
        public BasketballBall(string name, int count, int price) : base(name, count, price) { }
        public override void Application()
        {
            Console.WriteLine("Баскетбольный мяч используется в игре в баскетбол, где его бросают в корзину, пытаясь набрать очки.");
        }

        public override string Description
        {
            get
            {
                return $"Тип: название: {Name}, количество: {Count}, цена: {Price}";
            }
        }
    }

    public sealed class Tennis : Inventory
    {
        private InventoryTennis inventoryTennis;
        public Tennis(string name, int count, int price) : base(name, count, price) { }
        public Tennis(string name, int countRacket, int priceRacket, int countBall, int priceBall) : base(name, countRacket, priceRacket + priceBall)
        {
            inventoryTennis = new InventoryTennis(countRacket, priceRacket, countBall, priceBall);
        }

        struct InventoryTennis
        {
            public int racket {  get; set; }
            public int racketPrice {  get; set; }
            public int ball { get; set; }
            public int ballPrice {  get; set; }

            public InventoryTennis(int countRacket, int priceRacket, int countBall, int priceBall)
            {
                racket = countRacket > 0 ? countRacket : 0;
                ball = countBall > 0 ? countBall : 0;
                racketPrice = priceRacket > 0 ? priceRacket : 0;
                ballPrice = priceBall > 0 ? priceBall : 0;
            }
        }
        
        public override void Application()
        {
            Console.WriteLine("Теннис развивает ловкость, скорость, реакцию и координацию, а также является отличным способом развивать силу, выносливость и стратегическое мышление.");
        }

        public override string Description
        {
            get
            {
                return $"Тип: название: {Name}, количество: {Count}, цена: {Price}";
            }
        }
    }


    public class Printer
    {
        public void IAmPrinting(IDescriptionInventory someObj)
        {
            Console.WriteLine(someObj.GetType().Name);
            Console.WriteLine(someObj.ToString());
        }
    }
}
