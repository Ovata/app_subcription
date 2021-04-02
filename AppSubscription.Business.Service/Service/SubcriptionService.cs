using AppSubription.Business.Abstraction.Interface;
using AppSubription.Business.Abstraction.Models;
using AppSubscription.Data.Service.Repository;
using Asom.Database.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppSubscription.Business.Service.Service
{
    public class SubcriptionService : ISubscription
    {
        private readonly IMapper _mapper;
        private readonly SubscriptionRepo _subscription;

        public SubcriptionService(IMapper mapper, SubscriptionRepo subscription)
        {
            _mapper = mapper;
            _subscription = subscription;
        }

        public async Task AddSubscription(SubscriptionModel model)
        {
            var data = _mapper.Map<Subscription>(model);
            data.CreatedAt = DateTime.Now;
            data.UpdatedAt = DateTime.Now;
            data.CreatedBy = "SYSTEM";
            data.UpdatedBy = "SYSTEM";
            await _subscription.AddSubscription(data);
        }

        public Task<List<SubscriptionModel>> GetAllSubscriptions()
        {
            throw new NotImplementedException();
        }

        public Task<SubscriptionModel> GetSubscription(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveSubscription(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSubscription(SubscriptionModel model, int id)
        {
            throw new NotImplementedException();
        }
    }
}
