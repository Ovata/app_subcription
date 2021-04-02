using System;
using System.Collections.Generic;
using System.Text;

namespace AppSubription.Business.Abstraction.Models
{
    public class SubscriptionModel
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        //public Money Price { get; set; }

        public virtual List<AppFeaturesModel> Features { get; set; }
    }
}
