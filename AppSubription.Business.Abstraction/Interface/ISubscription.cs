using AppSubription.Business.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppSubription.Business.Abstraction.Interface
{
    public interface ISubscription
    {
        Task AddSubscription(SubscriptionModel model);
        Task<SubscriptionModel> GetSubscription(int id);
        Task<List<SubscriptionModel>> GetAllSubscriptions();
        Task UpdateSubscription(SubscriptionModel model, int id);
        Task RemoveSubscription(int id);
    }
}
