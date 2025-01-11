using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Radical_Sept_24
{
    internal class Tuple
    {
        //static void Main()
        //{ 
        //   TupleDemo demo=new TupleDemo();
        //   (int,string) data= demo.GetData();
        //    Console.WriteLine(data.Item1);
        //    Console.WriteLine(data.Item2);
        //    Console.ReadLine();

        //}
    }

    public class TupleDemo
    {

        public (int,string) GetData()
        {

            string s = "Ramesh";
            return (10, s);
        
        }
    }
}
