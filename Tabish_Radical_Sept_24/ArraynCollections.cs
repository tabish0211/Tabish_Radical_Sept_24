using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Radical_Sept_24
{
    internal class ArraynCollections
    {
        static void Main()
        {

            //DemoArray();
            // GetInputArrayAndDisplay();
            //  SortingExample();
            // TwoDArray();
            //JaggedArray();
            string[] InputArr=InputArray();
            DisplayArray(InputArr);

            Console.ReadLine();
        }

        static void DemoArray()
        {
            //Array is storage --Daat structure--In memory ---similar datatypes ---conetegious memory 
            //you have only one datatype array , you cant mix it like an array with int and char in a same place this not possible
            //1,2,3,4,5
            //16 8 4 2 1
            //0  0 0 0 1

            //1 0 0 0 0
            //1 0 1 0 0
            //5---1001---10004->value=1--base16---10005---1008----conetigious
            //array is always fixed size-----5------0 0 0 0 0

            int[] arrStatic = { 1, 2, 3, 4, 5 };
            int[] arr = new int[5];//
            //all the array ----for
            //array_varblename[4]
            //0----size-1=4

            for (int i = 0; i < arrStatic.Length; i++)
            {
                Console.WriteLine(arrStatic[i]);
            }

           // Console.WriteLine(arr[2]);
        }

        static void GetInputArrayAndDisplay()
        {
            //to store the values in array
            Console.WriteLine("Tell me number of users that you wish to add in data store");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the User name");
                arr[i]= Console.ReadLine();
            }

            Console.WriteLine("\n\n Display an Array");
            ////Display Array
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }



        }

        static void SortingExample()
        {

            int[] arr = { 2, 1, 3, 5, 7, 8, 0, 10 };
           // 10,8,7,5,3,1,1,0
            //  Console.WriteLine("****Before Sorting**");
            Console.WriteLine("****Before Reversing**");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");


            }
            Console.WriteLine();
            //Console.WriteLine("****After Sorting**");

            //assignment --without using Sort method
            //   Array.Sort(arr);
            Console.WriteLine("****After Reversing**");
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write($"{item} ");


            }

            //Print an array in descening without using sort //using method



        }

        static void TwoDArray()
        {

            // 1 2 
            // 3 4

            //Ramesh Suresh Kamlesh
            //Rupesh Mahesh Kamesh

            //[,]-- left side of comma is row and right is col
            Console.WriteLine("Enter the row of the matrix");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column of the matrix");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] arr2D = new int[row, col];
            // int[,] arr2D = new int[2, 5];
            //for (int i = 0; i <2; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine(arr2D[i,j]);
            //    }
            //}

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        Console.WriteLine(arr2D[i, j]);
            //    }
            //}


            //store the value

            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter value for {i}{j} position:");
                    arr2D[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
                        
            Console.WriteLine( "\n***********Display*************");
            //Display
            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    Console.WriteLine(arr2D[i,j]);
                }
            }

            // 1 2
            //3 4

            //add 2 in each value of an aaray
            //3 4
            //5 6

            //3)
            //a b
            //c d

            //65 66
            //67 68


           //Input 2d array of integr  // 2 3 4 5
                                        //6  7 8  9

            //SUm of an array =2+3+4+5+6+7+8+9
            
        }

        static void JaggedArray()
        {
            //oracle---ramesh suresh Mahesh
            //SqlServer ---Kamlesh Rupesh 
            //Jagged array is ---array of an aaray
            string[][] arrJagged = new string[2][];
            arrJagged[0] = new string[3];

            arrJagged[1] = new string[2];

            string dataSource = "Oracle";
            for (int i = 0; i < arrJagged.Length; i++)
            {
                for (int j = 0; j < arrJagged[i].Length; j++)
                {
                    Console.WriteLine($"Enter user from {dataSource}");
                    arrJagged[i][j] = Console.ReadLine();

                }
                dataSource = "SqlServer";
            }


            Console.WriteLine("\n display");
            for (int i = 0; i < arrJagged.Length; i++)
            {
                for (int j = 0; j < arrJagged[i].Length; j++)
                {
                    
                    Console.WriteLine(arrJagged[i][j]);

                }
                
            }


            //make the above array as dynamic
        }

        //Method--Its set of instruction to do specific task
        //It is used for modular and clean code
        //it is used for reusability
        //return type---void or any datatype
        //void--this method wil; not retrun anything to the caller
        //return is having some datatype ---the method should return something of same datatype what you have put in return space
        //method can also get input from caller and pass it to method
        //method can pass by value or pass by reference , value means the value of the variable in a given isntant of time
        //reference the memory location of the variable 
        //return_type Method_Name(optional input){
        // optional return value}

        static string[] InputArray()
        {
            Console.WriteLine("Tell me number of users that you wish to add in data store");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the User name");
                arr[i] = Console.ReadLine();
            }

            return arr;
        }
        static void DisplayArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }

}
