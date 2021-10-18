using Fbg.Market.DbModel;
using Fbg.Market.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbg.Market.Service.Product
{
    public interface IProductService
    {
        Task<IQueryable<Product_>> Get();
        Task<Product_> Get(int id);
        Task<Product_> CreateAsync(Product_ model);
        Task<Product_> Update(int id, UpdateProductModel model);
        Task<bool> Delete(int id);
    }
}
