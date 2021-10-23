using Fbg.Market.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbg.Market.Infrastructure.Vendor
{
    public class VendorRepository : IVendorRepository
    {
        public VendorRepository()
        {

        }
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Get()
        {
            throw new NotImplementedException();
        }
    }
}
