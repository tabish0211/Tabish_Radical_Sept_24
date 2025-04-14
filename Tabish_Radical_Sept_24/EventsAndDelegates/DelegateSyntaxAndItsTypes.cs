using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Radical_Sept_24.EventsAndDelegates
{
    public class DelegateSyntaxAndItsTypes
    {
        // Delegate declaration
        public delegate void MyDelegate(string msg);

        // Method that matches the delegate signature
        public static void MyMethod(string message)
        {
            Console.WriteLine(message);

        }

        public static void MyMethod1(string message)
        {
            Console.WriteLine(message);

        }

        //public static void Main()
        //{
        //    ////single cast
        //    //// Creating an instance of the delegate
        //    //MyDelegate del = new MyDelegate(MyMethod);

        //    //// Invoking the delegate
        //    //del("Hello, World!");


        //    ////multicast delegate
        //   // MyDelegate del3 = MyMethod;
        //    // del3 += MyMethod1; // Adding another method to the delegate
        //    // del3("Hello from multicast delegate!");
        //    //// Removing a method from the multicast delegate
        //    //del3 -= MyMethod;
        //    //del3("Hello from multicast delegate after removal!");
        //    Console.ReadLine();

        //}
    }
}
