using AppSubscription.Data.Service.Interface;
using Asom.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppSubscription.Data.Service.CoreRepository
{
    public class CoreRepo<TEntity, TContext> : IRepository<TEntity>
                                where TEntity : class, IEntity
                                where TContext : DbContext
    {
        private readonly DbContext _context;

        public CoreRepo(DbContext context)
        {
            _context = context;
        }
        public async Task<TEntity> Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(int id)
        {
            var data = await _context.Set<TEntity>().FindAsync(id);
            if (data == null)
            {
                return data;
            }

            _context.Set<TEntity>().Remove(data);
            await _context.SaveChangesAsync();
            return data;
        }

        public async Task<TEntity> Get(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
