using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{

    public class CustomerManager : BaseCustomerManager
    {
        //Field
        private ICustomerCheckService _customerCheckService;

        //Dependecy injection method 
        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Add(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            


        }

      
    } 
}
