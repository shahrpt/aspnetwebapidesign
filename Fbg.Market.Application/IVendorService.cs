using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbg.Market.Application
{
    public interface IVendorService
    {
        Task<int> Get();
        Task<bool> Delete(int id);
    }
}
