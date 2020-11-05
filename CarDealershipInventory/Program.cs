using System;
using System.Collections.Generic;
namespace CarDealerShipInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cars> storedcar = new List<Cars>(){};
            decimal sum = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write("Welcome to James Stuart’s Cool “Tokunbo Car” Autos! input (list) to checkout the cars in the catalogue or (add) to include a new car. To quit enter (quit): " );
                string action = Console.ReadLine().ToLower();
                Cars car = new Cars();
                if(action == "add")
                {
                    Console.Write("Make: ");
                    string make = Console.ReadLine();


                    Console.Write("Model:");
                    string model = Console.ReadLine();


                    Console.Write("Year: ");
                    int year = Convert.ToInt32(Console.ReadLine());


                    Console.Write("Price: ");
                    decimal price = Convert.ToDecimal(Console.ReadLine());
                    car.Add(make, model, year, price);
                    sum = sum + car.SalePrice;
                    storedcar.Add(car);
                    continue;
                }
                else if (action == "list")
                {
                    if (storedcar.Count == 0)
                    {
                        Console.WriteLine("There are currently no cars in the catalog.");
                    } else if (storedcar.Count > 0)
                    {
                        foreach (var item in storedcar)
                        {
                            Console.WriteLine($"Car Make: {item.CarMake}\nCar Model: {item.CarModel}\nYear: {item.Year}\nSale Price: {item.SalePrice:C}");
                        }
                        Console.WriteLine($"Total Price Of Cars: {sum:C}\nTotal number of Cars: {storedcar.Count}\n");
                    }
                } else if (action == "quit")
                {
                    break;
                } else
                {
                    Console.WriteLine($"Sorry, but {action} is not a valid command. Please try again.");
                }
            }
            


        }
    }
}
