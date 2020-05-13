using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimranDhillon_S00187359
{
    
    public class Phone
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }


        public float IncreasePrice(float percentage)
        {
            float price; 
            price = percentage * Price;
            Price += price;
            return Price;
        }
    }

   
}
