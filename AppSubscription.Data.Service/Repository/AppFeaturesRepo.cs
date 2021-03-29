using AppSubscription.Data.Service.CoreRepository;
using Asom.Database.Context;
using Asom.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSubscription.Data.Service.Repository
{
    public class AppFeaturesRepo : CoreRepo<AppFeatures, ApplicationDbContext>
    {
        public AppFeaturesRepo(DbContext context) : base(context)
        {
        }
    }
}
