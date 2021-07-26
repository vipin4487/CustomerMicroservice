using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMicroservice.DAL.Entities
{
    public class CustomerInfo
    {
        public int Id { get; private set; }
        public string CustomerName { get; private set; }
        public string Phone { get; private set; }
        public CustomerInfo(string customerName, string phone)
        {
            CustomerName = customerName;
            Phone = phone;
        }
    }
}
