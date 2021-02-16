using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }
}
