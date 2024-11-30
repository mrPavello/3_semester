using System;
using laba_4;

class Programm
{
    static void Main()
    {
        Bench bench = new Bench("скамейка", 2);
        Bars bars = new Bars("брусья", 6);
        Ball ball = new Ball("воллейбольный мяч", 5);
        Mats mats = new Mats("маты", 8);
        BasketballBall basketballBall = new BasketballBall("баскетбольный мяч", 5);
        Tennis tennis = new Tennis("тенис", 3);

        Inventory bench2 = bench as Inventory;
        if (bench2 != null)
        {
            bench2.Application();
            if(bench2 is Bench)
            {
                Console.WriteLine(bench2.Description);
            }
        }
        else
        {
            Console.WriteLine("Не удалось преобразовать тип");
        }

        IDescriptionInventory bars2 = bars as IDescriptionInventory;
        if (bars2 != null)
        {
            Console.WriteLine(bars2.Description);
            if (bars2 is Bars)
            {
                Console.WriteLine(bars2.GetType().Name);
            }
        }
        else
        {
            Console.WriteLine("Не удалось преобразовать тип");
        }

        Console.WriteLine("\n");
        IDescriptionInventory[] inventory = { bench, bars, ball, mats, basketballBall, tennis };
        Printer printer =new Printer();
        foreach (var invent in inventory)
        {
            printer.IAmPrinting(invent);
        }
    }
}