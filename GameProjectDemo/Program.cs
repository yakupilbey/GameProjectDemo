using GameProjectDemo.Abstract;
using GameProjectDemo.Adapters;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entity;
using System;

namespace GameProjectDemo
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            //Customer Registration Operations

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.NationalityId = "12345678900";
            customer1.FirstName = "Ahmet";
            customer1.LastName = "YILDIRIM";
            customer1.DateOfBirth = new DateTime(1985, 06, 10);

            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.NationalityId = "92345678900";
            customer2.FirstName = "Mehmet";
            customer2.LastName = "YILDIRIM";
            customer2.DateOfBirth = new DateTime(1999, 08, 12);



            //Adding a new campaign 

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "Welcome Campaign";
            campaign1.Type = "Disposable Campaign";

            Campaign campaign2 = new Campaign();
            campaign2.Id = 2;
            campaign2.CampaignName = "Winter Campaign";
            campaign2.Type = "Disposable Campaign";



            //Selling a game

            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Tom Clancy's Rainbow Six Siege";
            product1.Price = 100;

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "Grand Theft Auto V";
            product2.Price = 200;



            //ISellService sellManager = new SellManager();
            //sellManager.Sell(customer1, product1, campaign1);


            

            //MernisServiceTest();
            //CustomerCheckServiceTest(customer1);
            //CampaignServiceTest(campaign1);
            Console.ReadLine();
        }


        private static void CampaignServiceTest(Campaign campaign)
        {
            ICampaignService campaignManager = new CampaignManager();

            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);


        }

        private static void CustomerCheckServiceTest(Customer customer)
        {
            //Customer Operations using CustomerCheckService
            ICustomerService customerManager = new CustomerManager(new CustomerCheckManager());

            customerManager.Add(customer);
            customerManager.Delete(customer);
            customerManager.Update(customer);

        }


        private static void MernisServiceTest()
        {
            //Customer Operations using MernisServiceAdapter
            BaseCustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            
            customerManager.Add(new Customer { DateOfBirth = new DateTime(2000, 4, 10), FirstName = "Yakup", LastName = "İLBEY", NationalityId = "12345678900" });
            customerManager.Delete(new Customer { DateOfBirth = new DateTime(2000, 4, 10), FirstName = "Yakup", LastName = "İLBEY", NationalityId = "12345678900" });
            customerManager.Update(new Customer { DateOfBirth = new DateTime(2000, 4, 10), FirstName = "Yakup", LastName = "İLBEY", NationalityId = "12345678900" });
        }


    }
}
