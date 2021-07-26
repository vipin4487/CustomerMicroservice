//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace CustomerMicroservice.DTO
//{
//    public class Customer
//    {
//        public int CustomerId { get; private set; }
//        public string CustomerName { get; private set; }

//        public string Phone { get; private set; }
//        private Customer()
//        {

//        }

//        public Customer(string customerName, string phone)
//        {

//        }

//        public List<Customer> GetAll()
//        {
//            //customer fetched from db
//            return new List<Customer>() { new Customer() { CustomerId = 1, CustomerName = "Vipin", Phone = "9999999999" } };
//        }

//        public void AddCustomer(Customer customer)
//        {
//            //customer will be added to database
//        }
//    }
//}
