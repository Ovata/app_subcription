using AppSubscription.Data.Service.CoreRepository;
using Asom.Database.Context;
using Asom.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppSubscription.Data.Service.Repository
{
    public class SubscriptionRepo : CoreRepo<Subscription, ApplicationDbContext>
    {
        public SubscriptionRepo(DbContext context) : base(context)
        {
        }

        public Task AddSubscription(Subscription model)
        {
            return Task.CompletedTask;
        }

        public Task GetSubscription(Subscription model)
        {
            return Task.CompletedTask;
        }

        public Task RemoveSubscription(Subscription model)
        {
            return Task.CompletedTask;
        }

        public Task UpdateSubscription(Subscription model)
        {
            return Task.CompletedTask;
        }
    }
}
