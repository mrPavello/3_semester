using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection.Metadata.Ecma335;

namespace laba_2
{
    internal partial class Bus
    {
        string fio;
        string num_of_bus;
        string rote_number;
        string bus_brand;
        int start_year;
        int mileage;

        static int bus_count;
        static string id;
        public const int max_mileage = 10000000;

        static Bus()
        {
            bus_count = 0;
            id = Guid.NewGuid().ToString();
        }

        public Bus() : this("неизвестный", "не определён", "не определён", "не определён", 2000, 1000) { }
        
        public Bus(
            string fio = "неизвестный",
            string num_of_bus = "не определён",
            string rote_number = "не определён",
            string bus_brand = "не определён",
            int start_year = 2000,
            int mileage = 1000
            )
            {
                if (string.IsNullOrEmpty(fio) || 
                    string.IsNullOrEmpty(num_of_bus) || 
                    string.IsNullOrEmpty(rote_number) || 
                    string.IsNullOrEmpty(bus_brand) || 
                    start_year < 1980 || 
                    start_year > DateTime.Now.Year || 
                    mileage < 0)
                {
                    throw new ArgumentException("Некорректные данные");
                }
            
            bus_count++;
            this.fio = fio;
            this.num_of_bus = num_of_bus;
            this.rote_number = rote_number;
            this.bus_brand = bus_brand;
            this.start_year = start_year;
            this.mileage = mileage;
        }

        public Bus(
        string fio = "неизвестный",
        string num_of_bus = "не определён",
        string rote_number = "не определён")
        {
            if (string.IsNullOrEmpty(fio) ||
                string.IsNullOrEmpty(num_of_bus) ||
                string.IsNullOrEmpty(rote_number)
                )
            {
                throw new ArgumentException("Некорректные данные");
            }

            bus_count++;
            this.fio = fio;
            this.num_of_bus = num_of_bus;
            this.rote_number = rote_number;
            this.bus_brand = "не определён";
            this.start_year = DateTime.Now.Year;
            this.mileage = 0;
        }

        public string Fio
        {
            get => fio;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Строка не может быть пустой");
                }
                else if (!Regex.IsMatch(value, @"^[а-яА-Яa-zA-Z\s\.\-]+$"))
                {
                    Console.WriteLine("В строке присутсвует недопустимый символ.");
                }
                else if (value.Length < 4 || value.Length > 50)
                {
                    Console.WriteLine("Недопустимая длина строки.");
                }
                else
                {
                    fio = value;
                }

            }
        }

        public string NumOfBus
        {
            get => num_of_bus;
            private set
            {
                if (!Regex.IsMatch(value, @"^[ABEIKMHOPCTX1-7\-]+$"))
                {
                    Console.WriteLine("Недопустимый символ в номере автобуса.");
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Строка не может быть пустой.");
                }
                else
                {
                    num_of_bus = value;
                }
            }
        }

        public string RoteNumber
        {
            get => rote_number;
            set
            {
                if (!Regex.IsMatch(value, @"^[0-9ABCЭ]+$"))
                {
                    Console.WriteLine("Недопустимый символ в номере маршрута.");
                } 
                else if (string.IsNullOrWhiteSpace (value))
                {
                    Console.WriteLine("Строка не может быть пустой.");
                }
                else
                {
                    rote_number = value;
                }
            }
        }

        public string BusBrand
        {
            get => bus_brand;
            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-Zа-яА-Я\.]+$"))
                {
                    Console.WriteLine("Недопустимый символ в строке.");
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Строка не может быть пустой.");
                }
                else
                {
                    bus_brand = value;
                }
            }
        }

        public int StartYear
        {
            get => start_year;
            set
            {
                if (value < 1980 || value > DateTime.Now.Year)
                {
                    Console.WriteLine("Невозможное значение года.");
                }
                else
                {
                    start_year = value;
                }
            }
        }

        public int Mileage
        {
            get => mileage;
            set
            {
                if (value < 0 || value > int.MaxValue)
                {
                    Console.WriteLine("Недопустимое значчение.");
                }
                else
                {
                    mileage = value;
                }
            }
        }

        public string ID => id;


    }

    internal partial class Bus
    {
        public override string ToString()
        {
            return $"Type: Bus\n" +
                $"ФИО: {fio}\n" +
                $"Номер автобуса: {num_of_bus}\n" +
                $"Номер маршрута: {rote_number}\n" +
                $"Марка: {bus_brand}\n" +
                $"Начало эксплуатации: {start_year}г.\n" +
                $"Пробег: {mileage}км.";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(fio, num_of_bus, rote_number, bus_brand, start_year, mileage);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Bus thisBus)
            {
                return fio == thisBus.fio &&
                    num_of_bus == thisBus.num_of_bus &&
                    rote_number == thisBus.rote_number &&
                    bus_brand == thisBus.bus_brand &&
                    start_year == thisBus.start_year &&
                    mileage == thisBus.mileage;
            }
            return false;
        }

        public int GetBusAge()
        {
            return DateTime.Now.Year - start_year;
        }

        public static void ClassBusInfo()
        {
            Console.WriteLine($"Количество экземпляров класса Bus: {bus_count}");
        }

        public static void UpdateBusMileage(ref Bus bus, int new_mileage, out string message)
        {
            if (new_mileage >= 0)
            {
                bus.Mileage = new_mileage;
                message = "Пробег успешно обновлен.";
            }
            else
            {
                message = "Недопустимое значение";
            }
        }
    }
}
