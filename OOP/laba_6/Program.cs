using System;
using System.Diagnostics;
using System.Reflection;
using laba_6;

class Programm
{
    static void Main()
    {
        Debug.WriteLine("Начало программы.");
        try
        {
            Bench bench = new Bench("скамейка", 2, 4);
            Bars bars = new Bars("брусья", 2, 5);
            Ball ball = new Ball("воллейбольный мяч", 3, 2);
            Mats mats = new Mats("маты", 5, 3);
            BasketballBall basketballBall = new BasketballBall("баскетбольный мяч", 5, 2);
            Tennis tennis = new Tennis("тенис", 2, 8);

            Gym<Inventory> gym = new Gym<Inventory>();
            gym.AddInventory(bench);
            gym.AddInventory(bench);
            gym.AddInventory(bars);
            gym.AddInventory(mats);
            gym.AddInventory(basketballBall);
            gym.AddInventory(tennis);
            gym.PrintInventory();
            gym.RemoveInventory(bench);
            gym.PrintInventory();
            Console.WriteLine();
            Gym<Inventory> gym2 = new Gym<Inventory>();
            gym2.Inventory = gym.Inventory;
            gym2.PrintInventory();

            Gym<Inventory> inventoryByPrice;
            inventoryByPrice = gym.SelectByPrice(3, 9);
            inventoryByPrice.PrintInventory();

            Console.WriteLine();

            GymController gymControl = new GymController(40);
            gymControl.AddInventory(bench);
            gymControl.AddInventory(bars);
            gymControl.AddInventory(mats);
            gymControl.AddInventory(tennis);
            gymControl.AddInventory(ball);
            gymControl.RemoveInventory(bench);
            gymControl.PrintInventory();

            gymControl.sortByPrice();
            gymControl.PrintInventory();

            ///////////////////////////////////
            //gymControl.AddInventory(bars);
            //Bench bench1 = new Bench("а", 2, -4);
            //Bench bench2 = new Bench("", 2, -4);
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"\n{new string('-', 60)}\n{ex.Message}\n{ex.TargetSite}\n{ex.InnerException}{new string('-', 60)} \n");
        }
        catch (InvalidArgument<string> ex)
        {
            Console.WriteLine($"\n{new string('-', 60)}\n{ex.Message}{ex.Value}\n{ex.TargetSite}\n{ex.InnerException}{new string('-', 60)}\n");
        }
        catch(InventoryDuplication ex)
        {
            Console.WriteLine($"\n{new string('-', 60)}\n{ex.Message}\n{ex.TargetSite}\n{ex.InnerException}{new string('-', 60)}\n");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"\n{new string('-', 60)}\n{ex.Message}\n{ex.TargetSite}\n{ex.InnerException}{new string('-', 60)}\n");
        }
        finally {
            Console.WriteLine("Обработка исключений завершена.");
            Debug.WriteLine("Конец программы.");
        }
    }
}
