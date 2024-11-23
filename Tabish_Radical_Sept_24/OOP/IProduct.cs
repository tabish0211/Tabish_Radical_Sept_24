using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Radical_Sept_24.OOP
{
    //class A
    //{

    //    void Display() { }
    //}
    // interface IProduct
    //{
    //    void Add();
    //    void Update();
    //}
    //interface IServices
    //{
    //    void ServiceNow();
    //    void ServiceHistory();

    //}
    //class SilverProduct : IProduct
    //{
    //    public void Add()
    //    {
    //        //own definition
    //    }

    //    public void Update()
    //    {
    //        //own definition
    //    }
    //}

    ////class sample : GoldCustomer, SilverCustomer
    ////{ 
    ////}

    ////class ,interfaces,
    //class Mysample : SilverCustomer, IServices
    //{
    //    public Mysample(int id) : base(id)
    //    {
    //    }

    //    public void ServiceHistory()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void ServiceNow()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //class GoldProduct : IProduct,IServices
    //{
    //    public void Add()
    //    {
    //        //own definition
    //    }

    //    public void ServiceHistory()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void ServiceNow()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update()
    //    {
    //        //own definition
    //    }
    //}

    interface I1 {

        void M1();
    
    }

    interface I2
    {

        void M1();

    }

    class A:I1,I2
    {
       void I1.M1()
        {

            Console.WriteLine(  "m from I1");
        }
       void I2.M1()
        {
            Console.WriteLine("m from I2");
        }

    }

    class Caller
    {


        //static void Main()
        //{
        //    I1 obj = new A();
        //    I2 obj2 = new A();

        //    obj.M1();
        //    obj2.M1();
        //    Console.ReadLine();
        //}


    }
    
}
