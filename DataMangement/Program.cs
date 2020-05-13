using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimranDhillon_S00187359;
namespace DataMangement
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneData db = new PhoneData();

            using (db)
            {
                Phone p1 = new Phone() {ID = 1, Name = "Samsung S20", Price = 500, OperatingSystem = "Android", OS_Image = "android.png", Phone_Image = "s20.jpg" };
                Phone p2 = new Phone() {ID = 2, Name = "Iphone 11", Price = 600, OperatingSystem = "IOS", OS_Image = "apple.png", Phone_Image = "iphone11.png" };

                db.phones.Add(p1);
                db.phones.Add(p2);

                Console.WriteLine("Added Phones to db");

                db.SaveChanges();

                Console.WriteLine("Saving Changes");

            }
        }
    }
}
