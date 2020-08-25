using System;
using System.Collections.Generic;
using CustomerApp.Core.Entity;

namespace CustomerApp.Core.ApplicationServices
{
    public interface ICustomerService
    {
        public List<Customer> ReadAllCustomers();
        public Customer CreateCustomer(string firstName, string lastName, DateTime birthDate);
    }
}
