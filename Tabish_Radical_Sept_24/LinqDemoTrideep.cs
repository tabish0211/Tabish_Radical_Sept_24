using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tabish_Radical_Sept_24
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int StandardID { get; set; }
    }

    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }
    internal class LinqDemoTrideep
    {
        static void Main()
        {
            //IList<Student> studentList = new List<Student>() {
            //new Student() { StudentID = 1, StudentName = "John", LastName="Kumar", Age = 20 } ,
            //new Student() { StudentID = 2, StudentName = "James",LastName="Kumar",  Age = 20 } ,
            //new Student() { StudentID = 3, StudentName = "Bill",LastName="Kumar",  Age = 18 } ,
            //new Student() { StudentID = 4, StudentName = "Mahesh" ,LastName="Kumar", Age = 25 } ,
            //new Student() { StudentID = 5, StudentName = "Abram" ,LastName="Kumar", Age = 20 }

            //    };
            //count
            // var count=studentList.Count();
            // var lstFilteredByAge = studentList.Where(s => s.Age > 18).ToList();
            // foreach (var item in lstFilteredByAge)
            // {
            //     Console.WriteLine($"Id={item.StudentID}");
            // }

            // var singleStu = studentList.First(s => s.StudentName == "John");
            // var anotherStu = studentList.FirstOrDefault(s => s.StudentName == "John Vick");
            // if (anotherStu is null)
            // {
            //     Console.WriteLine("Hey no record exists");
            // }

            //// var singleOccurenceBill = studentList.Single(s => s.StudentName == "Bill");
            // var singleOccurenceBillWithDefault = studentList.SingleOrDefault(s => s.StudentName == "Bill");
            // if (singleOccurenceBillWithDefault is null)
            // {
            //     Console.WriteLine("Hey no record exists");
            // }



            //var stuatIndex = studentList.ElementAt(2);
            //var stuatIndexWithNull = studentList.ElementAtOrDefault(10);
            //var lastOccurence = studentList.Last(s => s.StudentName == "John");

            //var lastOccurenceWithNull = studentList.LastOrDefault(s => s.StudentName == "Ratnesh");

            //var topNList = studentList.Take(3).ToList();
            //var topNList = studentList.TakeWhile(s=>s.Age>18).ToList();

            //var skipNList = studentList.Skip(2).ToList();
            //var skipNListWithWHile = studentList.SkipWhile(s=>s.Age>18).ToList();

            //if (studentList.Count>1)
            //{
            //    Console.WriteLine("dp some stuff");
            //}

            //if (studentList.Any())
            //{
            //    Console.WriteLine("dp some stuff");
            //}

            //if (studentList.Any(x=>x.Age>18))
            //{
            //    Console.WriteLine("dp some stuff");
            //}

            //// All should match
            //if (studentList.All(s => s.Age > 20))
            //{
            //    foreach (Student student in studentList)
            //    {


            //    }
            //}

            //List<string> strings = new List<string>() { "hello", "world" };
            //var flag = strings.Contains("hello");

            //var projectedCollection = studentList.Where(s => s.Age > 18).
            //     Select(s => new { Name = s.StudentName+" "+s.LastName, newAge = s.Age })
            //     .ToList();

            //foreach (var item in projectedCollection)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.newAge);
            //}
            //var sortedAscList = studentList.OrderBy(s => s.Age).ThenBy(s => s.StudentID).ToList();
            //var sortedDescList = studentList.OrderByDescending(s => s.Age).ThenByDescending(s => s.StudentID).ToList();

            //var avgData = studentList.Average(s => s.Age);
            //var maxdata = studentList.Max(s => s.Age);
            //var mindata = studentList.Min(s => s.Age);
            //var sum = studentList.Sum(s => s.Age);
            //var uniqueCollection = studentList.Distinct().ToList();
            //var grouped = studentList.GroupBy(x => x.Age);
            //foreach (var group in grouped)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var student in group)
            //    {
            //        Console.WriteLine(student.StudentID + " " + student.StudentName);
            //    }
            //}

            //List<string> list = new List<string> { "a", "b", "c", "d" };
            //List<string> list1 = new List<string> { "a", "b", "e" };



            //var exceptdata = list.Except(list1).ToList();
            //var commondata = list.Intersect(list1).ToList();
            //var union = list.Union(list1).ToList();


            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
                new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
                new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
                new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
                new Student() { StudentID = 5, StudentName = "Ron" ,StandardID =3 }
            };

            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

            var joinedData = studentList.Join(
                standardList,
                student => student.StandardID,
                standard => standard.StandardID,
                (student, standard) => new { Class = standard.StandardName, Name = student.StudentName, RollNumber = student.StudentID }
                ).ToList();


            Console.ReadLine();

        }
    }
}
