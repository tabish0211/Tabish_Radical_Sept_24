using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Radical_Sept_24
{
    internal class LinqDemo
    {
        static void Main()
        {
            var employees = LoadData();
            //Any() --situation count of the collection is more thatn 0
            //id=101
            //if (employees.Any()) {

            //    Console.WriteLine("collection is having at least one item");

            //}

            //if (employees.Any(e=>e.ID==101))
            //{
            //    Console.WriteLine("at least one the object is having id as 101");
            //}

            ////use case: count()---only when you areclear on on some figure which is more than 1
            //if (employees.Count()>2)
            //{
            //    Console.WriteLine("the count of collection is more thna 2");
            //}

            ////use case-where()---when the possiblity filtered record can be more than 
            //var ageGreatrThan30= employees.Where(e=>e.Age>30).ToList();
            //foreach (var employee in ageGreatrThan30)
            //{
            //    Console.WriteLine($"Id: {employee.ID} Name: {employee.FirstName} {employee.LastName} Age:{employee.Age} Saalry:{employee.Salary}");
            //}

            //use case --First()---collection when the condition meets at the first time it will just come out of the searching
            //var empAge30 = employees.First(e => e.Age == 30);
            //var empAge30WithNull = employees.FirstOrDefault(e => e.Age == 50);

            //use case : Last()--search from the bottom


            //use case : SIngle() when you would like to put restriction on the collection like it has only single matched value niether less than nor more than 1
            //var empAge30 = employees.Single(e => e.Age == 31);
            //var empAge30LessthanOne = employees.SingleOrDefault(e => e.Age == 31);
            //Console.WriteLine($"Id: {empAge30.ID} Name: {empAge30.FirstName} {empAge30.LastName} Age:{empAge30.Age} Saalry:{empAge30.Salary}");
            //use case--contains()---it is used for pattern matching
            //var employeedbasedonPatterns = employees.Where(x => x.FirstName.Contains("Ra")).ToList();
            //foreach (var employee in employeedbasedonPatterns)
            //{
            //    Console.WriteLine($"Id: {employee.ID} Name: {employee.FirstName} {employee.LastName} Age:{employee.Age} Saalry:{employee.Salary}");
            //}


            //use case--sum()---you have to aggregate a single property balue from objects 
            //calculate the total salary employer pays monthly
            //var totalSal = employees.Sum(e => e.Salary);
            //Console.WriteLine($"total sal {employees.Sum(e => e.Salary)}");
            //Console.WriteLine($"Average sal {employees.Average(e => e.Salary)}");
            //Console.WriteLine($"Max sal {employees.Max(e => e.Salary)}");
            //Console.WriteLine($"Min sal {employees.Min(e => e.Salary)}");

            //var maxSalEmployees=employees.Where(e => e.Salary == employees.Max(e => e.Salary)).ToList();

            //foreach (var employee in maxSalEmployees)
            //{
            //    Console.WriteLine($"Id: {employee.ID} Name: {employee.FirstName} {employee.LastName} Age:{employee.Age} Saalry:{employee.Salary}");
            //}

            //use case--select ---projection operator---you can filter the column as per your requirement

            var maxSalEmployeesWithProjection = employees.Where(e => e.Salary == employees.Max(e => e.Salary))
                .Select(e=> new { Id=e.ID,MySal=e.Salary+10})
                .ToList();
            foreach (var employee in maxSalEmployeesWithProjection)
            {
                Console.WriteLine($"Id: {employee.Id} Saalry:{employee.MySal}");
            }
            Console.ReadLine();


           
        }

        static List<Employee> LoadData()
        {

            //List<Employee> employees = new List<Employee>();
            //Employee employee = new Employee()
            //{

            //    ID = 101,
            //    FirstName = "Ramesh",
            //    LastName = "Kumar",
            //    Age = 30,
            //    Salary = 25000


            //};



            //  employees.Add(employee);
            return new List<Employee>() {


            new Employee()
            {

                ID = 101,
                FirstName = "Ramesh",
                LastName = "Kumar",
                Age = 31,
                Salary = 25000
            },

            new Employee()
            {

                ID = 102,
                FirstName = "Suresh",
                LastName = "Kumar",
                Age = 31,
                Salary = 35000
            },

            new Employee()
            {

                ID = 103,
                FirstName = "Mahesh",
                LastName = "Kumar",
                Age = 28,
                Salary = 28000
            },

            new Employee()
            {

                ID = 104,
                FirstName = "Ratnesh",
                LastName = "Kumar",
                Age = 32,
                Salary = 32000

            },
            new Employee()
            {

                ID = 105,
                FirstName = "Kamlesh",
                LastName = "Kumar",
                Age = 33,
                Salary = 26000
            }

        };

        }

    }

    class Employee
    {

        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public int Age { get; set; }

        public int Salary { get; set; }




    }

}
