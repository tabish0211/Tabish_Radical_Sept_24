using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Radical_Sept_24.EventsAndDelegates
{
    internal class SoutionWithDelegate
    {
        public delegate void ResultHandler(int result);
        public void ProcessNumber(int num, ResultHandler handler)
        {
            int result = num * num;

            // Dynamically execute whatever action is passed
            handler(result);
        }
        public static void PrintResult(int result)
        {
            Console.WriteLine("Result: " + result);
        }

        public static void SaveResult(int result)
        {
            // Simulate saving to a database
            Console.WriteLine("Result saved to database: " + result);
        }

        //public static void Main()
        //{
        //    SoutionWithDelegate processor = new SoutionWithDelegate();

        //    // Using the PrintResult method
        //    processor.ProcessNumber(10, PrintResult);

        //    // Using the SaveResult method
        //    processor.ProcessNumber(20, SaveResult);
        //}
    }
}
