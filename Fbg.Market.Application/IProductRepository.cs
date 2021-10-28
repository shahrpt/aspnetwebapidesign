using Fbg.Market.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fbg.Market.DbModel;
namespace Fbg.Market.Application
{
    public interface IProductRepository
    {
        Task<IEnumerable<DbModel.Model.Product>> ListAsync(ProductsQuery query);
        Task<DbModel.Model.Product> AddAsync(DbModel.Model.Product product);
        Task<DbModel.Model.Product> FindByIdAsync(int id);
        Task<DbModel.Model.Product> UpdateAsync(int id, DbModel.Model.Product entity);
        Task<int> DeleteAsync(int id);
    }
}
