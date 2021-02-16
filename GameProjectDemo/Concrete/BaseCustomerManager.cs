using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + "added");
        }

        public virtual void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + "deleted");
        }

        public virtual void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + "updated");
        }
    }
}
