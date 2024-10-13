using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tabish_Radical_Sept_24.OOP
{
    internal class ConstructorDemo:IDisposable
    {
        private int balance;
        private bool disposedValue;


        //constructor is an especial method whose name is same as that of class name 
        //It is used for initialization of data member 
        //constructor can be overloaded--with param--without parm
        //constructor do not hav eany return type not even void
        //public ConstructorDemo()
        //{
        //    balance = 0;

        //    Console.WriteLine("This is Default");
        //}
        
        public ConstructorDemo(int minmBal) {

            balance = minmBal;
            Console.WriteLine( balance);
            Console.WriteLine("This is Params");
        }

        //SIngleton pattern
        private ConstructorDemo() { 
        
        
        }

        private static ConstructorDemo obj = null;
        public static ConstructorDemo GetInstance()
        {
            if (obj is  null)
            {
                obj = new ConstructorDemo();

            }
            
            return obj;
        
        }

        //no access specifier
        //can not be overloaded
        //
        static ConstructorDemo()
        {
            Console.WriteLine("Site is up now");


        }

        public void DisplayBalance()
                {

            Console.WriteLine($"Current balance {balance}");
        }

        public void Deposit(int amount)
        {
            balance += amount;

        }

        //overloading is not possible-destructor
        //when you wish to do resource free code
        //memory clean up for some unmanged code(that not maintained by CLR)
        ~ConstructorDemo()
        {
            //write resource free code in destructor
            Dispose();
            Console.WriteLine("Resource got free");

        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~ConstructorDemo()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

    }

    public class Customer
    {
       // private string name;
        private int salary;

        private readonly string name;

        public Customer(string name)
        {
            this.name = name;
                
        }

        public Customer(string name, int salary):this(name)
        {
            this.salary = salary;

        }

        public void WriteData()
        {
            salary = salary + 1200;
            ///this.name = "Gabbar";
        }
        public void Details()
        {

            Console.WriteLine($"Name={this.name} and Salary={this.salary}");

        }


        //Shallow copy
        public static Customer Clone(Customer customer)
        { 
        
            return (Customer)customer.MemberwiseClone();
        
        }

    }


    class ClientClass
    {
        static void Main() {

            ///Customer obj = new Customer("Ramesh");//IBM
           

            //obj.WriteData();
            //obj.Details();

             Customer anothrCLient = new Customer("Rahul", 1200);
             //wipro
             anothrCLient.Details();

            //Customer mynewCLient = anothrCLient;
            //mynewCLient.WriteData();

            //anothrCLient.Details();

            //copy constructor

            var myCLonedObject = Customer.Clone(anothrCLient);
            myCLonedObject.WriteData();

            anothrCLient.Details();

            //find out what deep copy and it use cases





            Console.ReadLine();
        
        }

        //tabish.com
        //Site is up now
        //static void Main()
        //{
        //    //Console.WriteLine("Enter minm balnce");
        //    //int bal = Convert.ToInt32(Console.ReadLine());
        //    //var demo = new ConstructorDemo(bal);//explicit calling of constructor

        //    //demo.DisplayBalance();

        //    //Console.WriteLine("Enter deposit amount");
        //    //int deposit = Convert.ToInt32(Console.ReadLine());
        //    //demo.Deposit(deposit);
        //    //demo.DisplayBalance();


        //    //understanding static constructor

        //    //default
        //    // var call_obj=new ConstructorDemo();
        //    // call_obj = null;
        //    //var call_obj1 = new ConstructorDemo(1200);
        //    //var call_obj2 = new ConstructorDemo();
        //    //Console.ReadLine();

        //    //static methods called --className.Method name
        //    //var obj=ConstructorDemo.GetInstance();//user-1
        //    //var obj1 = ConstructorDemo.GetInstance();//user-2

        //    Console.ReadLine();
        //}

    }
}
