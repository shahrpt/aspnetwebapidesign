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
        IQueryable<Model.Product> Get();
        Model.Product Get(int id);
        Task<Model.Product> Create(CreateProductModel model);
        Task<Model.Product> Update(int id, UpdateProductModel model);
        Task Delete(int id);
    }
}
