using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Radical_Sept_24
{
    interface IProductColor
    {
        public string Color { get; set; } //LSP
    }

    interface IProduct {
        string Name { get; set; }
        double Price { get; set; }
        string Category { get; set; }
        double GetdiscountedPrice();


            }
    public abstract class S_Product:IProduct
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public virtual double GetdiscountedPrice() { 
        
            return Price;

        }
    }
    class Electronics : IProduct,IProductColor//ISP
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }

        public  double GetdiscountedPrice()
        {
            return Price * 0.9;
        }

        public void ElectrnicProcessor(IProduct product)
        {
            OrderProcessor orderProcessor = new OrderProcessor();
            orderProcessor.ProcessOrder(product);
        }
    }
    class Clothing : IProduct,IProductColor
    {
        public string Color { get; set; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Category { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public  double GetdiscountedPrice()
        {
            return Price * 0.8;
        }

    }


    //SHould not have color --violation of 
    class SIM : IProduct
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Category { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public  double GetdiscountedPrice()
        {
            return Price * 0.8;
        }

    }
    class Default : IProduct
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Category { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public  double GetdiscountedPrice()
        {
            return Price;
        }
    }

    class OrderProcessor
    {
        private readonly IDataBaseOperations _dbOperation;
        private readonly ICommunication _communication;
        public OrderProcessor(IDataBaseOperations dbOperation, ICommunication communication)
        {
            _dbOperation = dbOperation;
            _communication = communication;
        }

        
        

        public void ProcessOrder(IProduct product)
        {            
            Console.WriteLine("processing order for: " + product.Name);
            //DataBaseOperations dataBase = new DataBaseOperations();//DI
            _dbOperation.SavetoDatabase(product);
           // EmailCommunication emailCommunication = new EmailCommunication(); //DI
            _communication.SendNotification(product);
        }

    }

    interface IDataBaseOperations
    {
        void SavetoDatabase(IProduct product);
    }
    class DataBaseOperations: IDataBaseOperations
    {
        public void SavetoDatabase(IProduct product)
        {
            Console.WriteLine("processing order for: " + product.Name);
        }

    }

    interface ICommunication
    {
        void SendNotification(IProduct product);
    }
    class EmailCommunication: ICommunication
    {
        public void SendNotification(IProduct product)
        {
            Console.WriteLine("processing order for: " + product.Name);
        }

    }



    internal class SolidImplementation
    {
        static void Main()
        {
            IProduct electronic = new Electronics()
            {
                Name = "Test",
                Category = "Test",
                Color = "Red",
                Price = 123
            };
            
            IProduct sim = new SIM()
            {
                Name = "Test",
                Category = "Test",
                //Color = "Red",//vioalation of LSP
                Price = 123
            };

            OrderProcessor orderProcessor = new OrderProcessor(new DataBaseOperations(), new EmailCommunication());
            orderProcessor.ProcessOrder(electronic);
            orderProcessor.ProcessOrder(sim);
            
        
        }
    }
}
