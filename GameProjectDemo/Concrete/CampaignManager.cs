using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "updated");
        }
    }
}
