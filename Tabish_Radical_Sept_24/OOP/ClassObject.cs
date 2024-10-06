using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Radical_Sept_24.OOP
{

    class Launcher
    {
        //static void Main()
        //{

        //    //(new ClassObject()).Display();
        //    //ClassObject obj = new ClassObject();
        //    //obj.Display();

        //    //(new ClassObject()).Display();
        //    //(new ClassObject()).Operation();

        //    Console.ReadLine();

        //}






        static void Main()
        {
            Customer customer = new Customer();

            //customer.SetCustomerId(1);
            //customer.SetCustomerName("Ramesh");
            //var id=customer.GetCustomerId();
            //var name=customer.GetCustomerName();

            customer.ID = 1;
            customer.Name = "Ramesh";
            

            Console.WriteLine($"Id={customer.ID} and name={customer.Name}");
            Console.ReadLine();

        }
    }

    //encapsulation--Implement properties

    class Customer
    {

        //private int _id;
        //private string _name;

        ////C# 2.0
        //public int ID {
        //    set { 

        //        _id = value;

        //    }
        //    get
        //    {
        //        return _id;
        //    }        


        //}

        //public string Name
        //{
        //    set
        //    {

        //        _name = value;

        //    }
        //    get
        //    {
        //        return _name;
        //    }


        //}

        public int ID { get; set; }
        public string Name  { get; set; }

        ////Defauult attribute is private for methods in C#
        //public void SetCustomerId(int cid)
        //{

        //    id = cid;

        //}

        //public void SetCustomerName(string cname)
        //{

        //    name = cname;

        //}

        //public int GetCustomerId()
        //{

        //    return id;

        //}

        //public string GetCustomerName()
        //{

        //    return name;

        //}


    }









    class ClassObject
    {
        int x;
        public void Operation()
        {

            x = x + 1;
        }

        public void Display()
        {


            Console.WriteLine(x);
        }


    }

    
}
