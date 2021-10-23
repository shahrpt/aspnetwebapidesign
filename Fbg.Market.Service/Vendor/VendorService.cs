using Fbg.Market.Application;
using Fbg.Market.Infrastructure.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbg.Market.Service.Vendor
{
    public class VendorService : IVendorService
    {
        IVendorRepository _vendorRepository;
        public VendorService()
        {
            _vendorRepository = new VendorRepository();
        }
        public VendorService(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
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
