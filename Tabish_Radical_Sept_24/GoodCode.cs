using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tabish_Radical_Sept_24
{
    interface IColor
    {
        string Color { get; set; }

    }
    public interface IProduct
    {
        string Name { get; set; }
        double Price { get; set; }
        string Category { get; set; }
        double GetdiscountedPrice();
        void OrderGeneartir(IProduct product);

    }
    class Elctronics : IProduct, IColor
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        private readonly IOrderProcessorOps _orderProcessorOps;
        public Elctronics(IOrderProcessorOps orderProcessorOps)
        {
            _orderProcessorOps = orderProcessorOps;
        }
        public double GetdiscountedPrice()
        {
            return Price * 0.9;

        }

        public void OrderGeneartir(IProduct product)
        {
           // OrderProcessorOps processorOps = new OrderProcessorOps(new DatabaseOps(), new EmailCommunicationOps());
            _orderProcessorOps.ProcessOrder(product);
        }
    }

    class Clothing : IProduct, IColor
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }

        private readonly IOrderProcessorOps _orderProcessorOps;
        public Clothing(IOrderProcessorOps orderProcessorOps)
        {
            _orderProcessorOps = orderProcessorOps;
        }
        public double GetdiscountedPrice()
        {
            return Price * 0.8;

        }

        public void OrderGeneartir(IProduct product)
        {
           // OrderProcessorOps processorOps = new OrderProcessorOps(new DatabaseOps(), new EmailCommunicationOps());
            _orderProcessorOps.ProcessOrder(product);
        }
    }


    class SIMCard : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        private readonly IOrderProcessorOps _orderProcessorOps;
        public SIMCard(IOrderProcessorOps orderProcessorOps)
        {
            _orderProcessorOps = orderProcessorOps;
        }
        public double GetdiscountedPrice()
        {
            return Price * 0.7;

        }

        public void OrderGeneartir(IProduct product)
        {
            //OrderProcessorOps processorOps = new OrderProcessorOps(new DatabaseOps(), new EmailCommunicationOps());
            _orderProcessorOps.ProcessOrder(product);
        }
    }

    class Others : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        private readonly IOrderProcessorOps _orderProcessorOps;
        public Others(IOrderProcessorOps orderProcessorOps)
        {
            _orderProcessorOps = orderProcessorOps;
        }
        public double GetdiscountedPrice()
        {
            return Price;
        }

        public void OrderGeneartir(IProduct product)
        {
           // OrderProcessorOps processorOps = new OrderProcessorOps(new DatabaseOps(),new EmailCommunicationOps());
            _orderProcessorOps.ProcessOrder(product);
        }
    }

    interface IOrderProcessorOps
    {
        void ProcessOrder(IProduct product);
    }
    class OrderProcessorOps:IOrderProcessorOps
    {
        private readonly IDatabaseOps _database;
        private readonly ICommunication _comm;
        public OrderProcessorOps(IDatabaseOps database, ICommunication comm)
        {
            _database = database;
            _comm = comm;
        }
        public void ProcessOrder(IProduct product)
        {
            Console.WriteLine("processing order for: " + product.Name);
            _database.SavetoDatabase(product);
            _comm.SendemailNotification(product);
        }

    }

    interface IDatabaseOps
    {
        void SavetoDatabase(IProduct product);
    }
    class DatabaseOps : IDatabaseOps
    {
        public void SavetoDatabase(IProduct product)
        {
            Console.WriteLine("saving product to database...");
        }

    }

    interface ICommunication
    {
        void SendemailNotification(IProduct product);
    }
    class EmailCommunicationOps: ICommunication
    {
        public void SendemailNotification(IProduct product)
        {
            Console.WriteLine("sending email notification for: " + product.Name);
        }

    }




    internal class GoodCode
    {
        static void Main()
        {
            IProduct electronic = new Elctronics(
                new OrderProcessorOps(
                    new DatabaseOps(),
                    new EmailCommunicationOps())
                )
            {

                Name = "Samsung",
                Price = 10000,
                Category = "ELectronics",
                Color = "Red"
            };

            IProduct cloth = new Clothing(
                new OrderProcessorOps(
                    new DatabaseOps(),
                    new EmailCommunicationOps())
                )
            {

                Name = "Jeans",
                Price = 1000,
                Category = "Fabric",
                Color = "Blue"
            };

            IProduct simcard = new SIMCard(
                new OrderProcessorOps(
                    new DatabaseOps(),
                    new EmailCommunicationOps())
                )
            {

                Name = "airtel",
                Price = 800,
                Category = "Services",
                //Color = "Red"//SIM card dont have 
            };

            electronic.OrderGeneartir(electronic);
            cloth.OrderGeneartir(cloth);
            simcard.OrderGeneartir(simcard);


        }
    }
}
