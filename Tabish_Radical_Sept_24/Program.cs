//using System.Threading.Channels;

//namespace Tabish_Radical_Sept_24
//{

//    //\n--new line 
//    internal class Program
//    {
//        //csc.exe--compiler 
//        //entry point method
//        static void Main()
//        {
//            //    //char --2 byte
//            //    string message = "Hello";//derived datatypes----reference datatype---heap---runtime 
//            //    char ch = 'a';//2-bytes
//            //    int x = 1;//4-bytes
//            //    float f = 2.5F;//4 bytes//primitive datatype
//            //    double d = 1.00005D;//8 bytes
//            //    long l = 16L;//8-bytes

//            //char, float,int,long,double they are known as value type --stack--compile time



//            //memory location---you can store any value depending datatype

//            // Console.WriteLine("Enter your name and salary");//hello, world!
//            // //input 
//            // string name = Console.ReadLine();
//            // int sal = Convert.ToInt32(Console.ReadLine());
//            // //Console.WriteLine("name="+name);
//            // //Console.WriteLine($"name={name}");
//            //// Console.WriteLine("Tell me your salary");

//            //  Console.WriteLine($"name= {name} salary ={sal}");
//            //Console.Write("hello tabish\n");// hello tabish
//            //

//            //enter-bs,hra-10%,ta-20%--gross salary
//            //Console.WriteLine("Enter basic salary");
//            //int bs = Convert.ToInt32(Console.ReadLine());

//            //double hra = 0.1 * bs;
//            //double ta = 0.2 * bs;
//            //double gs = bs + hra + ta;
//            //Console.WriteLine($"Your basic salary= {bs} and gross salary= {gs}");

//            //a=1,b=2;
//            //b=1,a=2;
//            //temp---a,,a--b,b--temp
//            //int a = 1, b = 2;
//            //Console.WriteLine($"Before swapping a={a} and b={b}");
//            ////int temp;
//            ////temp = a;
//            ////a= b;
//            ////b= temp;
//            //a = a + b;//3
//            //b = a - b;//3-2==1
//            //a = a - b;//3-1=2

//            //Console.WriteLine($"After swapping a={a} and b={b}");

//            //Decision making controls
//            //int x = 1, y = 2;
//            ////bool flag = true;
//            ////flag = false;
//            ////flag=x > y;
//            ////flag = x > y && y < 1;
//            ////Console.WriteLine( flag);

//            //if (x>y)
//            //{
//            //    Console.WriteLine("Yes y is greatert than x and it is a true statement");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("No x is smaller than yand it is a false statement");
//            //}

//            ////nested if-else
//            //if (true)
//            //{
//            //    if (true)
//            //    {

//            //    }
//            //    else
//            //    {

//            //    }


//            //}

//            //else { 

//            //    if (true) { }
//            //    else { }

//            //}


//            ////ladder if -else
//            //if (true)
//            //{

//            //}
//            //else if (true)
//            //{
//            //}
//            //else { 

//            //}

//            //int choice = 1;
//            //switch (choice)
//            //{
//            //    case 1:
//            //        //work
//            //        break;
//            //    case 2:
//            //        //work
//            //        break;
//            //    case 3:
//            //        //work
//            //        break;
//            //    default:
//            //        break;
//            //}

//            //string str=x > y ?"Hello world" :"xyz";
//            //Console.WriteLine(  str);


//            //sum of 3 digit number---234=2+3+4=9
//            //Console.WriteLine( "enter three digit number");
//            //int num=Convert.ToInt32( Console.ReadLine() );
//            //int oldValue = num;
//            ////234---4,3,2---4+3+2----print summation
//            //int a = num % 10;//4
//            //num = num / 10;//23
//            //int b = num % 10;//3
//            //num = num / 10;//2

//            //int sum = a + b + num;
//            //Console.WriteLine(  sum);
//            //reverse the three digit---234----432---x*100+y*10+z*1
//            //int rev = a * 100 + b * 10 + num;
//            //Console.WriteLine(  rev);

//            //if (oldValue==rev)
//            //{
//            //    Console.WriteLine($"old num={oldValue} and Reverse {rev} are same");
//            //}
//            //else
//            //{
//            //    Console.WriteLine($"old num={oldValue} and Reverse {rev} are not  same");
//            //}

//            //string message = oldValue == rev ? $"old num={oldValue} and Reverse {rev} are same" : $"old num={oldValue} and Reverse {rev} are not  same";
//            //Console.WriteLine( message);

//            //Who is the youngest one amongst three brothers

//            Console.WriteLine("Enter the age of Ramesh");
//            int rameshAge=Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the age of Suresh");
//            int sureshAge = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the age of kamesh");
//            int kameshAge = Convert.ToInt32(Console.ReadLine());

//            if (rameshAge < sureshAge)
//            {
//                if (rameshAge < kameshAge)
//                {
//                    Console.WriteLine($"Ramesh is youngest one and his age is {rameshAge}");
//                }
//                else
//                {
//                    Console.WriteLine($"Kamesh is youngest one and his age is {kameshAge}");
//                }
//            }
//            else {

//                if (sureshAge < kameshAge)
//                {
//                    Console.WriteLine($"Suresh is youngest one and his age is {sureshAge}");
//                }
//                else
//                {
//                    Console.WriteLine($"Kamesh is youngest one and his age is {kameshAge}");
//                }

//            }

//            //Loop--repetative task
            
//            for (int i = 1; i < 11; i++)
//            {
//                Console.WriteLine(2*i);
//            }

            
//            int j = 1;
//            while (j < 11)
//            {
//                Console.WriteLine(2 * j);
//                j++;
//            }

//            int k = 1;
//            do
//            {
//                Console.WriteLine(2 * k);
//                k++;

//            } while (k<11);

//            char ch = 'Y';
//            do
//            {
//                Console.WriteLine("please enter number for which you wish to print the tables");
//                int num = Convert.ToInt32(Console.ReadLine());
//                for (int i = 1; i < 11; i++)
//                {
//                    Console.WriteLine(num * i);
//                }

//                Console.WriteLine("Do you want to print another number table ");
//                ch= Convert.ToChar(Console.ReadLine());
//            } while (ch=='y' || ch=='Y');
           

            

//            //foreach (var item in collection)
//            //{

//            //}

//            Console.ReadLine();
//        }

        
//    }


    

   

//}
