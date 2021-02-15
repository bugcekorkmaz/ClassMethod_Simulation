using System;

namespace ClassMethod_Simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Bugce",
                Surname = "Korkmaz",
                EMail = "bugce@gmail.com"
            };
            Customer customer2 = new Customer()
            {
                Id = 1,
                Name = "Sevda",
                Surname = "Korkmaz",
                EMail = "sevda@gmail.com"
            };
            Customer[] customers = new Customer[] { customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            Console.WriteLine("**************Customer List***************");
            customerManager.List(customers);
            customerManager.Delete(customer2);
        }
    }
}
