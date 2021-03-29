using AppSubscription.Data.Service.CoreRepository;
using Asom.Database.Context;
using Asom.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSubscription.Data.Service.Repository
{
    public class SubscriptionRepo : CoreRepo<Subscription, ApplicationDbContext>
    {
        public SubscriptionRepo(DbContext context) : base(context)
        {
        }
    }
}
