using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tabish_Radical_Sept_24.EventsAndDelegates.DelegateSyntaxAndItsTypes;

namespace Tabish_Radical_Sept_24.EventsAndDelegates
{
    public class Processor
    {
        public static void ProcessNumber(int num)
        {
            int result = num * num;

            // Hardcoded action: always print
            Console.WriteLine("Result: " + result);
            //send email
            //sav

        }


        //public static void Main()
        //{
        //    ProcessNumber(10);
        //    Console.ReadLine();

        //}

        //whta if instead of rint i want to send result somewhere , you have to touch the class
        //and change the code
        //this is the problem with the above code

    }

}
