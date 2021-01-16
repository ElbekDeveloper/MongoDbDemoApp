using MongoDbDemo.Models;
using System;

namespace MongoDbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCrud db = new MongoCrud("ExadelBonusDb");

            //INSERT SOME RECORDS 
            //var record = new VendorModel
            //{
            //    Name = "Black Barber",
            //    Email = "black.barber@fake.email.com",
            //    Info = "A barbeshop in the city center",
            //    Location = new Location
            //    {
            //        Street = "Oak Str",
            //        City = "Huston",
            //        Country = "LA",
            //        Zip = "125211"
            //    }
            //};

            //db.InsertRecord<VendorModel>("Vendors", record);

            //SHOW RECORDS 
            var recs = db.LoadRecords<VendorModel>("Vendors");

            recs.ForEach(element => Console.WriteLine($"{element.Name}"));

            Console.ReadKey();
        }
    }



}
