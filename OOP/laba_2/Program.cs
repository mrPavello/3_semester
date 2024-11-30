using System;
using System.Runtime.InteropServices;
using laba_2;

class Program
{
    static void Main(string[] args)
    {
        Bus rider0 = new Bus();
        Bus rider1 = new Bus("Василий В.В.", "AD 2342-4", "33c", "mersedes");
        Bus rider2 = new Bus("Павел В.В.", "AD 5321-4", "23", "mersedes", 2012, 12223);
        Bus rider3 = new Bus("Владислав В.В.", "AD 4342-4", "12", "mersedes", 2012, 12411);
        Bus rider4 = new Bus("Илья В.В.", "AD 7446-4", "33c", "mersedes", 2012, 23922);

        Console.WriteLine(rider0.Fio);
        Console.WriteLine(rider1.NumOfBus);
        Console.WriteLine(rider2.RoteNumber);
        Console.WriteLine(rider3.BusBrand);
        Console.WriteLine(rider4.StartYear);
        Console.WriteLine(rider3.Mileage);
        Console.WriteLine(rider4.ID);
        Console.WriteLine();
        Console.WriteLine(rider0.ToString());
        Console.WriteLine(rider0.GetHashCode());
        Console.WriteLine(rider1.Equals(rider3));
        Console.WriteLine(rider3.GetType());
        Console.WriteLine(rider3.GetBusAge());
        Bus.ClassBusInfo();

        
        Bus[] buses = {rider0, rider1, rider2, rider3, rider4};

        string BusRoteNumber = "33c";
        Console.WriteLine($"\nАвтобусы с номером маршрута {BusRoteNumber}:\n");
        foreach (Bus bus in buses.Where(b => b.RoteNumber == BusRoteNumber))
        {
            Console.WriteLine($"{bus.ToString()}\n");

        }

        int serviceLife = 15;
        Console.WriteLine($"Автобусы, которые эксплуатируются больше {serviceLife}г.\n");
        foreach(Bus bus in buses.Where(b => b.GetBusAge() > serviceLife))
        {
            Console.WriteLine($"{bus.ToString()}\n");
        }

        string message;
        Bus.UpdateBusMileage(ref rider3, 10, out message);
        Console.WriteLine(message);

        Console.WriteLine(rider3.ToString());

        var myType = new
        {
            fio = "Овчинников А. А.",
            num_of_bus = "AB2442-1",
            rote_number = "22c",
            bus_brand = "Volvo",
            start_year = 2015,
            mileage = 30000
        };
        Console.WriteLine(myType);
    }
}