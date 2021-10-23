using AutoMapper;
using Fbg.Market.Application;
using Fbg.Market.DbModel;
using Fbg.Market.DbModel.Model;
using Fbg.Market.Models.Product;
using Fbg.Market.Service.Product;
using Fbg.Market.WebAPIs.App_Start;
using Fbg.Market.WebAPIs.AutoMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FBG.Market.WebAPIs.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;
        //git
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        /// <summary>
        /// Saves a new product.
        /// </summary>
        /// <param name="resource">Product data.</param>
        /// <returns>Response for the request.</returns>
        [System.Web.Http.HttpPost]
        public async Task<IHttpActionResult> PostAsync([FromBody] CreateProductModel resource)
        {
            var prod = AutoMap.Mapper.Map<Product>(resource);
            var result = await _productService.CreateAsync(prod);
            var productResource = AutoMap.Mapper.Map<Product, CreateProductModel>(result);
            return Ok(productResource);
        }
        // GET api/values
        public async Task<IHttpActionResult> Get()
        {
            var userDTO = AutoMap.Mapper.Map<CreateProductModel>(new CreateProductModel() { CategoryId = 1 });
            var result = await _productService.Get();
            return Json(result);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
