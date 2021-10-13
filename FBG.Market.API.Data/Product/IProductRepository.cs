using FBG.Market.API.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBG.Market.API.Repository.Product
{
    public interface IProductRepository
    {
        Task<IEnumerable<Model.Product>> ListAsync(ProductsQuery query);
        Task<Model.Product> AddAsync(Model.Product product);
        Task<Model.Product> FindByIdAsync(int id);
        Task<int> UpdateAsync(int id, Model.Product entity);
        Task<int> DeleteAsync(int id);
    }
}
