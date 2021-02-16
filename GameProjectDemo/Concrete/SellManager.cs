using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class SellManager : ISellService
    {
        public void Sell(Customer customer, Product product, Campaign campaign)
        {
            Console.WriteLine("Gamer name: " + customer.FirstName + "\n" + "Campaign used: " + campaign.CampaignName + "\n" + "Name of the purchased product: " + product.ProductName);
        }
    }
  
}
