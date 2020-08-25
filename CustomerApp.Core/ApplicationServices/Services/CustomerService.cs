using System;
using System.Collections.Generic;
using CustomerApp.Core.DomainServices;
using CustomerApp.Core.Entity;

namespace CustomerApp.Core.ApplicationServices.Services
{
    public class CustomerService: ICustomerService
    {
        private ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer CreateCustomer(string firstName, string lastName, DateTime birthDate)
        {
            var customer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate
            };
            return _customerRepository.AddCustomer(customer);
        }

        public List<Customer> ReadAllCustomers()
        {
            return  _customerRepository.GetCustomers();
        }
    }
}
