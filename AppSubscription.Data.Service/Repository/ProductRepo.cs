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
    public class ProductRepo : CoreRepo<Product, ApplicationDbContext>
    {
        public ProductRepo(DbContext context) : base(context)
        {
        }

        public Task AddProduct(Product model)
        {
            return Task.CompletedTask;
        }

        public Task GetProduct(Product model)
        {
            return Task.CompletedTask;
        }

        public Task RemoveProduct(Product model)
        {
            return Task.CompletedTask;
        }

        public Task UpdateProduct(Product model)
        {
            return Task.CompletedTask;
        }
    }
}
