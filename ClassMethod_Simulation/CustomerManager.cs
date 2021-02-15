using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethod_Simulation
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added!" + "Name : " + customer.Name + ", " + "Surname : " + customer.Surname);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted!" + "Name : " + customer.Name + ", " + "Surname : " + customer.Surname);
        }
        public void List(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Id : " + customer.Id + "\n" + "Name : " + customer.Name + "\n" + "Surname : " + customer.Surname +
                  "\n" + "EMail : " + customer.EMail);
            }
        }
    }
}
