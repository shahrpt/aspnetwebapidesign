using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBG.Market.API.Service.Product.Communication
{
    public class ProductResponse : BaseResponse<FBG.Market.API.Model.Product>
    {
        public ProductResponse(FBG.Market.API.Model.Product product) : base(product) { }

        public ProductResponse(string message) : base(message) { }
    }
}
