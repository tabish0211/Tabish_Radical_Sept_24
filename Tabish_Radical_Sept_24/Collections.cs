//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tabish_Radical_Sept_24
//{
//    internal class Collections
//    {
//        static void Main()
//        {
//            ////    string wish = "y";
//            ////   // string[] strCity = new string[3];//size
//            ////    List<string> list = new List<string>();//Dhiraj
//            ////    while (wish.ToLower().Equals("y"))//i dont know the size of my datastructure
//            ////    {
//            ////        Console.WriteLine("Enter the City");
//            ////        string city = Console.ReadLine();///Pune---Patna
//            ////        //strCity[0] = wish;
//            ////        list.Add(city);


//            ////        Console.WriteLine("Do you want to add more city");
//            ////        wish = Console.ReadLine();//yes Yes YES YeS
//            ////    }
//            ////Generic |Non generic
//            ////Generic--Where we have to define what dadtype should be store in my collection
//            ////List<string>

//            ////print all the city


//            ////Console.WriteLine("City Details:");
//            ////foreach (string s in list)
//            ////{
//            ////    Console.WriteLine(s);

//            ////}
//            //List<string> Dhiraj_list = new List<string> { "Bombay", "Kolkata" };
//            //List<string> tabish_list = new List<string>{ "Allahabad", "New Delhi", "Bombay" };
//            //List<string> aggreagtedList = new List<string>{ "Chennai", "Nashik" };
//            //aggreagtedList.AddRange(Dhiraj_list);
//            //aggreagtedList.AddRange(tabish_list);




//            //////list.Remove("Pune");

//            ////Console.WriteLine("\n\nCity Details after some operations:");
//            ////foreach (string s in aggreagtedList)
//            ////{
//            ////    Console.WriteLine(s);

//            ////}
//            //////Remove duplicacy
//            ////List<string> nonDuplicate = aggreagtedList.Distinct().ToList();
//            ////Console.WriteLine("\n\nCity Details after some operations:");
//            ////foreach (string s in nonDuplicate)
//            ////{
//            ////    Console.WriteLine(s);

//            ////}




//            ////aggreagtedList.RemoveRange(4, 2);
//            ////Console.WriteLine("\n\nCity Details after some operations:");
//            ////foreach (string s in aggreagtedList)
//            ////{
//            ////    Console.WriteLine(s);

//            ////}
//            ////aggreagtedList.ForEach(s => Console.WriteLine(s));//PLINQ---Core of CPU--Dual core
//            ////if (aggreagtedList.Contains("P"))
//            ////{

//            ////}



//            ////string city_name = list.ElementAt(0);
//            ////list.Remove(city_name);
//            ////int noOFItem = list.Count();
//            ////if (list.Count()>3)
//            ////{
//            ////    //below block
//            ////}

//            ////if (list.Any())
//            ////{
//            ////    //below block
//            ////}

//            ////Non generic collection
//            //ArrayList arrayList=new ArrayList();
//            //arrayList.Add("Ramesh");
//            //arrayList.Add(10000);
//            //arrayList.Add('E');
//            //arrayList.Add(aggreagtedList);

//            //foreach (var item in arrayList)
//            //{
//            //    Console.WriteLine( item);
//            //}

//            //var Dhiraj_list1 = new List<string> { "Bombay", "Kolkata" };

//            ////var x = 1;
//            ////x = "Rakesh";

//            //dynamic y = 1;
//            //y = "Tabish";
//            //Console.WriteLine( y);

//            int x = 1, y = 2;
//            int s;
//            ModifyValue(ref x,ref y);
//            //Console.WriteLine($"x={x} and y={y}");
//            Sum(x, y,out s);
//            Console.WriteLine($"sum={s}");
//            Console.ReadLine();
//        }

//        static void ModifyValue(ref int x,ref int y)//formal argument
//        {
//            x = x + 2;
//            y= y + 2;
//            Console.WriteLine($"x={x} and y={y}");

//        }

//        static void Sum( int x,  int y,out int sum)//formal argument
//        {
//             sum = x + y;
          

//        }

       
//    }
//}
