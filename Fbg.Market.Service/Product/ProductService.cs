﻿using Fbg.Market.Application;
using Fbg.Market.DbModel;
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

        public async Task<DbModel.Model.Product> CreateAsync(DbModel.Model.Product model)
        {
            return await _productRepository.AddAsync(model);
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DbModel.Model.Product>> Get()
        {
            ProductsQuery query = new ProductsQuery();
            
            return await _productRepository.ListAsync(query);
        }

        public async Task<DbModel.Model.Product> Get(int id)
        {
            return await _productRepository.FindByIdAsync(id);
        }

        public async Task<DbModel.Model.Product> Update(int id, DbModel.Model.Product model)
        {
            return await _productRepository.UpdateAsync(id, model);
        }
    }

}
