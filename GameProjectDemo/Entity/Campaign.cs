using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Entity
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string Type { get; set; }
    }
}
