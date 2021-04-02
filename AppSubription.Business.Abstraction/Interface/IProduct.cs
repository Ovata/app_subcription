using AppSubription.Business.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppSubription.Business.Abstraction.Interface
{
    public interface IProduct
    {
        Task<int> AddProduct(ProductModel model);
        Task<ProductModel> GetProduct(int id);
        Task<List<ProductModel>> GetAllProducts();
        Task UpdateProduct(ProductModel model, int id);
        Task RemoveProduct(int id);
    }
}
