using FBG.Market.API.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBG.Market.API.Repository.Product
{
    public class ProductRepository : IProductRepository
    {
        public Task<Model.Product> AddAsync(Model.Product product)
        {
            return null;
        }

        public Task<Model.Product> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Model.Product>> ListAsync(ProductsQuery query)
        {
            throw new NotImplementedException();
        }

        public void Remove(Model.Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Model.Product product)
        {
            throw new NotImplementedException();
        }
    }
}
