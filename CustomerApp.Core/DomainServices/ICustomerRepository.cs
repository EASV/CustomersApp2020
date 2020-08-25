using System;
using System.Collections.Generic;
using CustomerApp.Core.Entity;

namespace CustomerApp.Core.DomainServices
{
    public interface ICustomerRepository
    {
        public List<Customer> GetCustomers();
        public Customer AddCustomer(Customer customer);
    }
}
