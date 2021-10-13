using FBG.Market.API.Models.Product;
using FBG.Market.API.Repository.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBG.Market.API.Service.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        
        public ProductService(IProductRepository productService)
        {
            _productRepository = productService;
        }
        public Task<Model.Product> Create(CreateProductModel model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Product> Get()
        {
            throw new NotImplementedException();
        }

        public Model.Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Model.Product> Update(int id, UpdateProductModel model)
        {
            throw new NotImplementedException();
        }

        
    }

}
