using System;
using System.Collections.Generic;
using CustomerApp.Core.DomainServices;
using CustomerApp.Core.Entity;

namespace CustomerApp.Infrastructure.Data
{
    public class CustomerRepository: ICustomerRepository
    {
        private int _id = 1;
        private List<Customer> _customers = new List<Customer>();
        public CustomerRepository()
        {
            InitData();
        }

        public void InitData()
        {
            _customers = new List<Customer> {
                new Customer
                {
                    Id = _id++,
                    FirstName = "Bill",
                    LastName = "Bingo",
                    BirthDate = DateTime.Now.AddYears(-50)
                },
                new Customer
                {
                    Id = _id++,
                    FirstName = "Bongo",
                    LastName = "Joe",
                    BirthDate = DateTime.Now.AddYears(-40)
                }
            };
        }

        public List<Customer> GetCustomers()
        {
            return _customers;
        }

        public Customer AddCustomer(Customer customer)
        {
            customer.Id = _id++;
            _customers.Add(customer);
            return customer;
        }
    }
}
