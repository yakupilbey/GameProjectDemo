using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ISellService
    {
        void Sell(Customer customer, Product product, Campaign campaign);
    }
}
