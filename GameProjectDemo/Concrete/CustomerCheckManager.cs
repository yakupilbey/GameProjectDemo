using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
