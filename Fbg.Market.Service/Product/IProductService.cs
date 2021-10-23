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
        Task<IEnumerable<DbModel.Model.Product>> Get();
        Task<DbModel.Model.Product> Get(int id);
        Task<DbModel.Model.Product> CreateAsync(DbModel.Model.Product model);
        Task<DbModel.Model.Product> Update(int id, UpdateProductModel model);
        Task<bool> Delete(int id);
    }
}
