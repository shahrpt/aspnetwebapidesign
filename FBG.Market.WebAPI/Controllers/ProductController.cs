using AutoMapper;
using FBG.Market.API.Model;
using FBG.Market.API.Models.Product;
using FBG.Market.API.Service.Product;
using FBG.Market.WebAPI.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FBG.Market.WebAPI.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        //git
        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        /// <summary>
        /// Saves a new product.
        /// </summary>
        /// <param name="resource">Product data.</param>
        /// <returns>Response for the request.</returns>
        [System.Web.Http.HttpPost]
        public async Task<IHttpActionResult> PostAsync([FromBody] CreateProductModel resource)
        {
            var product = _mapper.Map<CreateProductModel, Product>(resource);
            var result = await _productService.CreateAsync(product);
            var productResource = _mapper.Map<Product, CreateProductModel>(result);
            return Ok(productResource);
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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
