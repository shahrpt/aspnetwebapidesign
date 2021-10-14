using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbg.Market.Service.Product.Communication
{
    public class ProductResponse : BaseResponse<Fbg.Market.Model.Product>
    {
        public ProductResponse(Fbg.Market.Model.Product product) : base(product) { }

        public ProductResponse(string message) : base(message) { }
    }
}
