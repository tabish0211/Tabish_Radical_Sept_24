using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tabish_Radical_Sept_24
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }


    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("Server=localhost;Database=myRadicalDb;Trusted_Connection=True;TrustServerCertificate=True") // Connection string name from Web.config
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }


    public class CustomerRepository
    {
        //static void Main()
        //{
        //    CustomerRepository repository = new CustomerRepository();
        //    //repository.AddCustomer(new Customer { Name = "Mahesh", Email = "mahesh@gmail.com" });
        //    //Customer customer=repository.GetCustomerById(1);
        //   // List<Customer> customers=repository.GetAllCustomers();
        //   // repository.UpdateCustomer(customer);
        //    repository.DeleteCustomer(1);

        //    Console.ReadLine();


        //}
        private readonly AppDbContext _context;

        public CustomerRepository()
        {
            _context = new AppDbContext();
        }

        // Create (Insert)
        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        // Read (Get by ID)
        public Customer GetCustomerById(int id)
        {
            return _context.Customers.Find(id);
        }

        // Read (Get All)
        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        // Update
        public void UpdateCustomer(Customer customer)
        {
            //customer.Name = "Sunil";
            //customer.Email = "Sunil@gmail.com";

            var existingCustomer = _context.Customers.Find(customer.Id);
            if (existingCustomer != null)
            {
                existingCustomer.Name = "Sunil";
                existingCustomer.Email = "Sunil@gmail.com";
                _context.SaveChanges();
            }
        }

        // Delete
        public void DeleteCustomer(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }
    }

}
