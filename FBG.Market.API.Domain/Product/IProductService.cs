using FBG.Market.API.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBG.Market.API.Service.Product
{
    public interface IProductService
    {
        Task<IQueryable<Model.Product>> Get();
        Task<Model.Product> Get(int id);
        Task<Model.Product> CreateAsync(Model.Product model);
        Task<Model.Product> Update(int id, UpdateProductModel model);
        Task<bool> Delete(int id);
    }
}
