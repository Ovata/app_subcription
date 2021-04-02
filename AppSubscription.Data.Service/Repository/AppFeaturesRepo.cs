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
    public class AppFeaturesRepo : CoreRepo<AppFeatures, ApplicationDbContext>
    {
        public AppFeaturesRepo(DbContext context) : base(context)
        {
        }

        public Task AddFeature(AppFeatures model)
        {
            return Task.CompletedTask;
        }

        public Task UpdateFeature(AppFeatures model)
        {
            return Task.CompletedTask;
        }

        public Task GetFeature(AppFeatures model)
        {
            return Task.CompletedTask;
        }

        public Task RemoveFeature(AppFeatures model)
        {
            return Task.CompletedTask;
        }
    }
}
