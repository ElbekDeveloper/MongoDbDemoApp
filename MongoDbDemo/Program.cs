using MongoDbDemo.Models;
using System;

namespace MongoDbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCrud db = new MongoCrud("ExadelBonusDb");

            db.InsertRecord<VendorModel>("Vendors",  });



            Console.ReadKey();
        }
    }



}
