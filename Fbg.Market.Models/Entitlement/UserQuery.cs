using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbg.Market.Models.Entitlement
{
    public class UserQuery
    {
        public int? CategoryId { get; set; }

        public UserQuery(int? categoryId, int page, int itemsPerPage) 
        {
            CategoryId = categoryId;
        }

        public UserQuery()
        {
        }
    }
}
