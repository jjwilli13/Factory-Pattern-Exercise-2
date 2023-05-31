using System;
namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {

        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "Gas Outdoor Fire Pit", Price = 49.99m},
            new Product() { Name = "Max and Lily Bunk Bed",Price = 399.99m},
            new Product() { Name = "Hey Dude Men's Slip on Shoes", Price = 34.81m},
            new Product() { Name = "Honest Amish Beard Oil", Price = 12.22m},
            new Product() { Name = "Hill's Science Diet Dog Food", Price = 51.99m}
        };


        public List<Product> LoadData()
        {
            Console.WriteLine("Reading data from SQL Data Access");

            return Products;

            
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data from SQL Data Access!");
        }
    }
}

