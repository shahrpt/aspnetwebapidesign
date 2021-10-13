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
        Task<IQueryable<Model.Product>> ListAsync(ProductsQuery query);
        Task<Model.Product> AddAsync(Model.Product product);
        Task<Model.Product> FindByIdAsync(int id);
        void Update(Model.Product product);
        void Remove(Model.Product product);
    }
}
