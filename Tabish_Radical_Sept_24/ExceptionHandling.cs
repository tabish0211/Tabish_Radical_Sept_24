
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;
////using System.Xml.Linq;
//using Tabish_Radical_Sept_24.OOP;

//namespace Tabish_Radical_Sept_24
//{
//    internal class ExceptionHandling
//    {
//        static void Main()
//        {
//            try
//            {
//                int x = 10;
//                string name = null;
//                Console.WriteLine("Enter the number");
//                System.Console.WriteLine(x);
//                int y = Convert.ToInt32(Console.ReadLine());

//                summation(x, y);
//            }
//            catch (Exception ex)
//            {

//                Console.WriteLine($"Error details:{ex.StackTrace}");
//            }
//            finally
//            {

//                Console.WriteLine("resource clean up activity should be inside this finally , it will always execute");
//            }

//            Console.ReadLine();
//        }


//        static void Div(int x, int y, string name)
//        {
//            try
//            {
//                if (y < 0) {

//                    throw new MyException("Value can not be less than 0");
//                }
//                int div = x / y;
//                Console.WriteLine($"Div={div}");
//                Console.WriteLine($"user ={name.ToString()}");
//            }
//            catch (MyException ex)
//            {

//                Console.WriteLine( ex.Message);

//            }

//            //catch (NullReferenceException ex)
//            //{
//            //    throw;
//            //    //Console.WriteLine($"Error messag={ex.Message}");
//            //}
//            catch (DivideByZeroException ex)
//            {
//                throw;
//                // Console.WriteLine($"Error messag={ex.Message}");
//            }

//            //catch (Exception ex)
//            //{
//            //    throw;
//            //    //Console.WriteLine($"Error messag={ex.Message}");

//            //}


//        }

//        static void summation(int x, int y)
//        {
//            try
//            {
//                int sum = x + y;
//                try
//                {
//                    Div(x, y, "");
//                }
//                catch (DivideByZeroException exception)
//                {

//                    Console.WriteLine( exception.Message);
//                }
                
//                Console.WriteLine($"Sum={sum}");
//            }
//            catch (Exception ex)
//            {

//                throw; //throw ex//lost stack trace
//            }

//        }
//    }

//    class MyException : Exception
//    {

//        public MyException(string message):base(message)
//        {
                
//        }
//    }
//}
