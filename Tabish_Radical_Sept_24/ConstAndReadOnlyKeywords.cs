using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Radical_Sept_24
{
    internal class ConstAndReadOnlyKeywords
    {
        //static void Main()
        //{

        //    StudentCapacityManager studentCapacityManager = new StudentCapacityManager(20);
        //    var capcity=studentCapacityManager.GetCapacity();
        //    Console.WriteLine(studentCapacityManager.size);
        //    // Console.WriteLine(StudentCapacityManager.size);

        //    Console.WriteLine(capcity);
        //    Console.ReadLine();
        //}


    }


    class StudentCapacityManager
    {
        public readonly int size;
        public StudentCapacityManager(int count)
        {
            size = count;
        }

        public int GetCapacity()
        {
           // size= 10;//I am able to change the value
            return size;
        
        }


    
    
    }
}
