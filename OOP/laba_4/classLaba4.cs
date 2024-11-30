using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba_4
{
    public interface IDescriptionInventory
    {
        string Description {  get; }
    }
    public abstract class Inventory : IDescriptionInventory
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public Inventory(string name, int count)
        {
            Name = name ?? "Undefined";
            Count = count < 0 ? 0 : count;
        }

        public abstract string Description { get; }

        public override string ToString()
        {
            return Description;
        }
        public virtual void Application() { }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (!(obj is Inventory)) return false;
            Inventory other = (Inventory)obj;
            if (Name != other.Name) return false;

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class Bench : Inventory
    {
        public Bench(string name, int count) : base(name, count) { }
        public override void Application()
        {
            Console.WriteLine("Скамейка, чаще всего, используется в силовых тренировках, особенно для выполнения жимов лежа.");
        }

        public override string Description
        {
            get { 
                return $"Тип: {GetType().Name}, название: {Name}, количество: {Count}"; 
            }
        }
    }

    public class Bars : Inventory
    {
        public Bars(string name, int count) : base(name, count) { }
        public override void Application()
        {
            Console.WriteLine("Брусья предназначены для выполнения упражнений на верхнюю часть тела, включая отжимания и подтягивания.");
        }

        public override string Description
        {
            get
            {
                return $"Тип: {GetType().Name}, название: {Name}, количество: {Count}";
            }
        }
    }

    public class Ball : Inventory
    {
        public Ball(string name, int count) : base(name, count) { }
        public override void Application()
        {
            Console.WriteLine("Спортивные мячи используются в различных видах спорта, таких как футбол, волейбол, плавание и многие другие.");
        }

        public override string Description
        {
            get
            {
                return $"Тип: {GetType().Name}, название: {Name}, количество: {Count}";
            }
        }
    }

    public class Mats : Inventory
    {
        public Mats(string name, int count) : base(name, count) { }
        public override void Application()
        {
            Console.WriteLine("Маты обычно используются в гимнастике, йоге, боевых искусствах и других видах физической активности, где происходит работа на полу.");
        }

        public override string Description
        {
            get
            {
                return $"Тип: {GetType().Name}, название: {Name}, количество: {Count}";
            }
        }
    }

    public class BasketballBall : Inventory
    {
        public BasketballBall(string name, int count) : base(name, count) { }
        public override void Application()
        {
            Console.WriteLine("Баскетбольный мяч используется в игре в баскетбол, где его бросают в корзину, пытаясь набрать очки.");
        }

        public override string Description
        {
            get
            {
                return $"Тип: {GetType().Name}, название: {Name}, количество: {Count}";
            }
        }
    }

    public sealed class Tennis : Inventory
    {
        public Tennis(string name, int count) : base(name, count) { }
        public override void Application()
        {
            Console.WriteLine("Теннис развивает ловкость, скорость, реакцию и координацию, а также является отличным способом развивать силу, выносливость и стратегическое мышление.");
        }

        public override string Description
        {
            get
            {
                return $"Тип: {GetType().Name}, название: {Name}, количество: {Count}";
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
