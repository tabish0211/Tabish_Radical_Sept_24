//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tabish_Radical_Sept_24
//{
//    public class Customer
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Email { get; set; }
//    }

//    public class CustomerRepository
//    {

//        private readonly string _connectionString = "Server=localhost;Database=myRadicalDb;Trusted_Connection=True;TrustServerCertificate=True";
//        static void Main()
//        {
//            CustomerRepository repository = new CustomerRepository();
//            // repository.AddCustomer("Mahesh", "Mahesh@gmail.com");
//            //  Customer cust=repository.GetCustomerById(1);
//            // List<Customer> customers= repository.GetAllCustomers();
//            //repository.UpdateCustomer(1, "Mukesh", "Mukesh@gmail.com");
//            repository.DeleteCustomer(1);
//            Console.ReadLine();

//        }
//        // Create (Insert)
//        public void AddCustomer(string name, string email)
//        {
//            using SqlConnection conn = new SqlConnection(_connectionString);
//            SqlCommand cmd = new SqlCommand("sp_InsertCustomer", conn);
//            cmd.CommandType = CommandType.StoredProcedure;
//            cmd.Parameters.AddWithValue("@Name", name);
//            cmd.Parameters.AddWithValue("@Email", email);

//            conn.Open();
//            int id=cmd.ExecuteNonQuery();
//          //  conn.Close();
//        }

//        // Read (Get by ID)
//        public Customer GetCustomerById(int id)
//        {
//            Customer customer = null;
//            using (SqlConnection conn = new SqlConnection(_connectionString))
//            {
//                SqlCommand cmd = new SqlCommand("sp_GetCustomerById", conn);
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Parameters.AddWithValue("@Id", id);

//                conn.Open();
//                using (SqlDataReader reader = cmd.ExecuteReader())
//                {
//                    if (reader.HasRows)
//                    {
//                        while (reader.Read())
//                        {
//                            customer = new Customer
//                            {
//                                Id = Convert.ToInt32(reader["Id"]),
//                                Name = reader["Name"].ToString(),
//                                Email = reader["Email"].ToString()
//                            };
//                        }
                        
//                    }

//                   // reader.Close();
//                }
//            }
//            return customer;
//        }

//        // Read (Get All)
//        public List<Customer> GetAllCustomers()
//        {
//            List<Customer> customers = new List<Customer>();
//            using (SqlConnection conn = new SqlConnection(_connectionString))
//            {
//                SqlCommand cmd = new SqlCommand("sp_GetAllCustomers", conn);
//                cmd.CommandType = CommandType.StoredProcedure;

//                conn.Open();
//                using (SqlDataReader reader = cmd.ExecuteReader())
//                {
//                    if (reader.HasRows)
//                    {
//                        while (reader.Read())
//                        {
//                            customers.Add(new Customer
//                            {
//                                Id = Convert.ToInt32(reader["Id"]),
//                                Name = reader["Name"].ToString(),
//                                Email = reader["Email"].ToString()
//                            });
//                        }

//                    }
                    
//                }
//            }
//            return customers;
//        }

//        // Update
//        public void UpdateCustomer(int id, string name, string email)
//        {
//            using (SqlConnection conn = new SqlConnection(_connectionString))
//            {
//                SqlCommand cmd = new SqlCommand("sp_UpdateCustomer", conn);
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Parameters.AddWithValue("@Id", id);
//                cmd.Parameters.AddWithValue("@Name", name);
//                cmd.Parameters.AddWithValue("@Email", email);

//                conn.Open();
//                cmd.ExecuteNonQuery();
//            }
//        }

//        // Delete
//        public void DeleteCustomer(int id)
//        {
//            using (SqlConnection conn = new SqlConnection(_connectionString))
//            {
//                SqlCommand cmd = new SqlCommand("sp_DeleteCustomer", conn);
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Parameters.AddWithValue("@Id", id);

//                conn.Open();
//                cmd.ExecuteNonQuery();
//            }
//        }
//    }
//}
