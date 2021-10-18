using Fbg.Market.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fbg.Market.DbModel;
namespace Fbg.Market.Repository.Product
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product_>> ListAsync(ProductsQuery query);
        Task<Product_> AddAsync(Product_ product);
        Task<Product_> FindByIdAsync(int id);
        Task<int> UpdateAsync(int id, Product_ entity);
        Task<int> DeleteAsync(int id);
    }
}
