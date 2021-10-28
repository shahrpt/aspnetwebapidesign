using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbg.Market.Application
{
    public interface IEntitlementService
    {
        Task<IEnumerable<DbModel.Model.AspNetUser>> Get();
        Task<DbModel.Model.AspNetUser> Get(int id);
        Task<DbModel.Model.AspNetUser> CreateAsync(DbModel.Model.AspNetUser model);
        Task<DbModel.Model.AspNetUser> Update(int id, DbModel.Model.AspNetUser model);
        Task<bool> Delete(int id);
    }
}
