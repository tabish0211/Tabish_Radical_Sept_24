//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tabish_Radical_Sept_24
//{
//    internal class ExtensionMethod
//    {
//        static void Main()
//        {
//            try
//            {
//                string str = null;
//                int count = str.WordCount();
//                Console.WriteLine(count);

//            }
//            catch (Exception ex)
//            {

//                Console.WriteLine(ex.Message);

//            }

//            Console.ReadLine();
            
        
//        }


//    }

//    static class StringExtension
//    {
//        public static int WordCount(this string str)
//        {
//            if (str is not null)
//            {
//                return str.Split(" ").Length;
//            }

//            throw new NullReferenceException();
           
            
//        }


//    }
//}
