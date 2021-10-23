using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbg.Market.Models.Product
{
    public class ProductsQuery
    {
        public int? CategoryId { get; set; }

        public ProductsQuery(int? categoryId, int page, int itemsPerPage) 
        {
            CategoryId = categoryId;
        }

        public ProductsQuery()
        {
        }
    }
}
