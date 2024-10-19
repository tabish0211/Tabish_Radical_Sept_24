using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Radical_Sept_24.OOP
{
    //Violation of Single Responsibilty Principle----SOLID
    //OPen closed Principle---the class should be closed for modification and open for extension
    public abstract class BasicCustomer
    {
        protected int customerId;
        public BasicCustomer(int id)
        {
            customerId = id;
        }
        public virtual int Discount()
        {

            return 10;
        }

        public abstract void display();
        
    }

    public class SilverCustomer : BasicCustomer
    {
        public SilverCustomer(int id):base(id)
        {
            Console.WriteLine("Silver-created");
        }
        public override int Discount()
        {

            return base.Discount() + 5;
        }

        public override void display()
        {

            Console.WriteLine($"I am silver-my id={customerId}");
        }
    }

    public class GoldCustomer : BasicCustomer
    {
        public GoldCustomer(int id) : base(id)
        {
            Console.WriteLine("Gold-created");
        }
        public override int Discount()
        {

            return base.Discount() + 10;
        }

        public override void display()
        {

            Console.WriteLine($"I am Gold-my id={customerId}");
        }

    }
    public class PlatinumCustomer : BasicCustomer
    {
        public PlatinumCustomer(int id) : base(id)
        {
            Console.WriteLine("Platinum-created");
        }

        public override int Discount()
        {

            return base.Discount() + 15;
        }

        public override void display()
        {

            Console.WriteLine($"I am Platinum-my id={customerId}");
        }
    }

    public static class InstanceCreator
    {

        public static BasicCustomer GetInstance(int id)
        {

            BasicCustomer obj = id==1?new SilverCustomer(1001):new GoldCustomer(1002);
            return obj;
        }
    
    }

    class ClientClass
    {
        static void Main()
        {

            //BasicCustomer basicCustomer = new BasicCustomer();
            //SilverCustomer silverCustomer = new SilverCustomer();
            //GoldCustomer goldCustomer = new GoldCustomer();
            //PlatinumCustomer platinumCustomer = new PlatinumCustomer();

            //Console.WriteLine($"Basic customer={basicCustomer.Discount()}");
            //Console.WriteLine($"Silver customer ={silverCustomer.Discount()}");
            //Console.WriteLine($"Gold customer ={goldCustomer.Discount()}");
            //Console.WriteLine($"Platinum customer ={platinumCustomer.Discount()}");


            //BasicCustomer obj = new SilverCustomer();
            //obj.Discount();

            //SilverCustomer silverCustomeranother = new SilverCustomer();
            //silverCustomeranother.display();
            //silverCustomer.Discount();



            var obj=InstanceCreator.GetInstance(11);
           /// obj.customerId = 100;
            Console.WriteLine(obj.Discount() ); 
            obj.display();

            Console.ReadLine();

        }
    }
}
