//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tabish_Radical_Sept_24
//{
//    internal class LoopingExercises
//    {
//        static void Main()
//        {
//            // SumOfNnaturalNumbers();
//            // Tables();
//            //PrintOddNumbersFromRange();

//            //BreakTheLoop();
//            Factorial();


//            Console.ReadLine();
//        }

//        //static methods only call static method
//        static void SumOfNnaturalNumbers()
//        {

//            //WAP to display sum of  n natural numbers          

//            Console.WriteLine("Tell me number of digits");

//            int digitsCount = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter number");
//            int num = Convert.ToInt32(Console.ReadLine());
//            int sum = 0;
//            for (int i = 1; i <= digitsCount; i++)
//            {
//                sum = sum + num % 10;//sum=0,3---sum=3--1st----sum=3,2--sum=5---2nd---sum=5,1=sum=6
//                num = num / 10;//num=12---1st---num=1--2nd---num=0;
//            }

//            Console.WriteLine($"Sum={sum}");
//        }

//        static void Tables()
//        {

//            //Table of 2
//            //2*1=2 2*2=4----------2*10=20
//            //

//            //Table of 5



//            //WAP to print table 
//            //user will input the start value and end value of the table 
//            //e.g 3---6---3,4,5,6

//            //3*1=3
//            //3*2=6
//            //......

//            //4*1=4
//            //4*2=8...10

//            //5*1=

//            //6*1=6

//            //---Range---3---6
//            //---strat*i--1---10
//            Console.WriteLine("Enter the starting value");
//            int initial = Convert.ToInt32(Console.ReadLine());//2


//            Console.WriteLine("Enter the final value");
//            int final = Convert.ToInt32(Console.ReadLine());//5

//            for (int i = 1; i < 11; i++)//1---10--i---2
//            {
//                for (int start = initial; start <= final; start++)//start-2--2<=5---start-3---start=5---start--6
//                    //2*1=2  ----5*1=5
//                    //-
//                {

//                    Console.Write($"{start}*{i}={start * i} \t");
//                }
//                Console.WriteLine();
                
//            }
            
//            //for (int start = initial; start <=final; start++)
//            //{
//            //    Console.WriteLine($"*********Table of {start}");
//            //    for (int i = 1; i < 11; i++)
//            //    {
//            //        Console.WriteLine($"{start}*{i}={start * i}");
//            //    }


                

//            //    //2*1=2   3*1 4*1=4   5*1=5
//            //    //2*2=4
//            //    //
//            //    //
//            //    //
//            //}
            
        
            
        
//        }

//        static void PrintOddNumbersFromRange()
//        {
//            Console.WriteLine("Enter the starting value");
//            int initial = Convert.ToInt32(Console.ReadLine());


//            Console.WriteLine("Enter the final value");
//            int final = Convert.ToInt32(Console.ReadLine());

//            //11----20---11,13,15,17....

//            for (int i = initial; i <= final; i++)
//            {
//                if (i%2==0)
//                {
//                    continue;
//                }

//                Console.WriteLine(i);//1,2,3,4,5,6,7,8,9,10
//                //Even number series comma separated -==10--20====10,12,14,16,18,20

             
//            }



//        }

//        static void BreakTheLoop()
//        {

//            for (int i = 1; i < 11; i++)
//            {
//                if (i==6)
//                {
//                    break;
//                }
//                Console.WriteLine(i);//in a geiven series if you find i--6 --come out of the loop

//            }

//            Console.WriteLine("Loop is break force fully");
//        }

//        static void Factorial()
//        {

//            Console.WriteLine( "Enetr the factorial value");
//            int factVal = Convert.ToInt32(Console.ReadLine());
//            int factOutput = 1;
//            for (int i = factVal; i >0; i--)
//            {
//                factOutput=factOutput*i;
//            }
//            Console.WriteLine($"factorial of {factVal} is {factOutput}");
//        }

//        //Take the range value from user ---2---8 print factorial of 2 till 8

        
//    }
//}
