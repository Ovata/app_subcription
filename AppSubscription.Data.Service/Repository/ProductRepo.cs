using AppSubscription.Data.Service.CoreRepository;
using Asom.Database.Context;
using Asom.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSubscription.Data.Service.Repository
{
    public class ProductRepo : CoreRepo<Product, ApplicationDbContext>
    {
        public ProductRepo(DbContext context) : base(context)
        {
        }
    }
}
