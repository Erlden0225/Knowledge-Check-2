using System;
using System.Collections.Generic;

namespace MyConsoleApp
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Description: {Description}";
        }
    }

    class CatFood : Product
    {
        public string Flavor { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, Flavor: {Flavor}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("How many Cat Food products do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<CatFood>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                var catFood = new CatFood();

                Console.WriteLine("Enter the Name for Cat Food: ");
                catFood.Name = Console.ReadLine();

                Console.WriteLine("Enter the Price for Cat Food: ");
                catFood.Price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Quantity for Cat Food: ");
                catFood.Quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Description for Cat Food: ");
                catFood.Description = Console.ReadLine();

                Console.WriteLine("Enter the Flavor for Cat Food: ");
                catFood.Flavor = Console.ReadLine();

                recordList.Add(catFood);
            }

            // Print out the list of records using ToString() method
            foreach (var record in recordList)
            {
                Console.WriteLine(record.ToString());
            }
        }
    }
}
