using Fbg.Market.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbg.Market.Service.Product.Communication
{
    public class ProductResponse : BaseResponse<Product_>
    {
        public ProductResponse(Product_ product) : base(product) { }

        public ProductResponse(string message) : base(message) { }
    }
}
