namespace Tabish_Radical_Sept_24
{

    //\n--new line 
    internal class Program
    {
        //csc.exe--compiler 
        //entry point method
        static void Main()
        {
            //    //char --2 byte
            //    string message = "Hello";//derived datatypes----reference datatype---heap---runtime 
            //    char ch = 'a';//2-bytes
            //    int x = 1;//4-bytes
            //    float f = 2.5F;//4 bytes//primitive datatype
            //    double d = 1.00005D;//8 bytes
            //    long l = 16L;//8-bytes

            //char, float,int,long,double they are known as value type --stack--compile time



            //memory location---you can store any value depending datatype

            // Console.WriteLine("Enter your name and salary");//hello, world!
            // //input 
            // string name = Console.ReadLine();
            // int sal = Convert.ToInt32(Console.ReadLine());
            // //Console.WriteLine("name="+name);
            // //Console.WriteLine($"name={name}");
            //// Console.WriteLine("Tell me your salary");

            //  Console.WriteLine($"name= {name} salary ={sal}");
            //Console.Write("hello tabish\n");// hello tabish
            //

            //enter-bs,hra-10%,ta-20%--gross salary
            //Console.WriteLine("Enter basic salary");
            //int bs = Convert.ToInt32(Console.ReadLine());

            //double hra = 0.1 * bs;
            //double ta = 0.2 * bs;
            //double gs = bs + hra + ta;
            //Console.WriteLine($"Your basic salary= {bs} and gross salary= {gs}");

            //a=1,b=2;
            //b=1,a=2;
            //temp---a,,a--b,b--temp
            int a = 1, b = 2;
            Console.WriteLine($"Before swapping a={a} and b={b}");
            //int temp;
            //temp = a;
            //a= b;
            //b= temp;
            a = a + b;//3
            b = a - b;//3-2==1
            a = a - b;//3-1=2

            Console.WriteLine($"After swapping a={a} and b={b}");
            Console.ReadLine();
        }

        
    }


    

   

}
