﻿using Fbg.Market.DbModel;
using Fbg.Market.Models.Product;
using Fbg.Market.Repository.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbg.Market.Service.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        
        public ProductService(IProductRepository productService)
        {
            _productRepository = productService;
        }

        public async Task<Product_> CreateAsync(Product_ model)
        {
            return await _productRepository.AddAsync(model);
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Product_>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Product_> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product_> Update(int id, UpdateProductModel model)
        {
            throw new NotImplementedException();
        }
    }

}
