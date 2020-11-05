using System;
namespace CarDealerShipInventory
{
    public class Cars
    {
        public string CarMake{get; set;}
        public string CarModel{get; set;}
        public int Year{get; set;}
        public decimal SalePrice{get; set;}
        public string[] StoredCars;

        public void Add(string carMake, string carModel, int year, decimal salePrice)
        {
            CarMake = carMake;
            CarModel = carModel;
            Year = year;
            SalePrice = salePrice;
        }
        public void List()
        {
            Console.WriteLine($"Car Make: {CarMake}\nCar Model: {CarModel}\nYear: {Year}\nSale Price: {SalePrice}");
        }
    }
}