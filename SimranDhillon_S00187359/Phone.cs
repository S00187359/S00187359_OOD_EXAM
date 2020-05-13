using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimranDhillon_S00187359
{
    
    class Phone
    {     
        public string Name { get; set; }
        public float Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }


        public float IncreasePrice()
        {
            float percentage, price;
            Console.WriteLine("Enter Percentage Increase For The Price : {0}",Price);
            percentage = float.Parse(Console.ReadLine());
            price = percentage * Price;
            Price += price;
            return Price;
        }
    }

   
}
