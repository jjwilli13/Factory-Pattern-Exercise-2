using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Which type of data base would you like to use?");
            Console.WriteLine("Type: sql");
            Console.WriteLine("Type: mongo");
            Console.WriteLine("Type: list");    

            var response = Console.ReadLine();

            var db = DataAccessFactory.GetDataAccessType(response);


            var products = db.LoadData();
            db.SaveData();
       

            Console.WriteLine("Here are your products:");
            Console.WriteLine("-----------------------");
            foreach (var product in products)
            {

                Console.WriteLine($"Name: {product.Name} Price: {product.Price}");
            }
            

        }
    }
}
