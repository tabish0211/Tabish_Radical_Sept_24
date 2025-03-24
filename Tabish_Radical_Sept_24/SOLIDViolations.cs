
using System;

namespace Tabish_Radical_Sept_24
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public double GetdiscountedPrice()
        {
            if (Category == "electronics")
            {
                return Price * 0.9;
            }
            else if (Category == "clothing")
            {
                return Price * 0.8;
            }
            return Price;
        }

        public void ProcessOrder()
        {
            Console.WriteLine("processing order for: " + Name);
        }

        public void SavetoDatabase()
        {
            Console.WriteLine("saving product to database...");
        }

        public void SendemailNotification()
        {
            Console.WriteLine("sending email notification for: " + Name);
        }
    }




}


