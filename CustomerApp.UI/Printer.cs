using System;
using System.Collections.Generic;
using CustomerApp.Core.ApplicationServices;
using CustomerApp.Core.Entity;

namespace CustomerApp.UI
{
    public class Printer
    {
        private ICustomerService _customerService;
        public Printer(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        internal void ListAllCustomers()
        {
            List<Customer> customers = _customerService.ReadAllCustomers();
            Console.WriteLine("Show List of Customers\n");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Id: {customer.Id} Name: {customer.FirstName} {customer.LastName}");
            }
        }

        internal void CreateCustomer()
        {
            Console.WriteLine("Type Customer FirstName");
            var firstName = Console.ReadLine();
            Console.WriteLine("Type Customer LastName");
            var lastName = Console.ReadLine();
            Console.WriteLine("Type Customer BirthDate");
            var birthDate = Console.ReadLine();
            var customer = _customerService.CreateCustomer(firstName, lastName, DateTime.Parse(birthDate));
            Console.WriteLine($"Customer with Id: {customer.Id} is created");
        }
    }
}
