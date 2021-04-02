using AppSubription.Business.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppSubription.Business.Abstraction.Interface
{
    public interface IAppFeatures
    {
        Task<int> AddAppFeature(AppFeaturesModel model);
        Task<AppFeaturesModel> GetAppFeature(int id);
        Task<List<AppFeaturesModel>> GetAllAppFeatures();
        Task UpdateAppFeature(AppFeaturesModel model, int id);
        Task RemoveAppFeature(int id);
    }
}
