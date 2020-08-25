using System;
using CustomerApp.Core.ApplicationServices;
using CustomerApp.Core.ApplicationServices.Services;
using CustomerApp.Core.DomainServices;
using CustomerApp.Infrastructure.Data;

namespace CustomerApp.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository customerRepository = new CustomerRepository();
            ICustomerService service = new CustomerService(customerRepository);
            var printer = new Printer(service);
            printer.ListAllCustomers();

            printer.CreateCustomer();

            Console.WriteLine("After add");
            printer.ListAllCustomers();
        }
    }
}
