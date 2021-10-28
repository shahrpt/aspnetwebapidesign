using Fbg.Market.Models.Entitlement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbg.Market.Application
{
    public interface IEntitlementRepository
    {
        Task<IEnumerable<DbModel.Model.AspNetUser>> ListAsync(UserQuery query);
        Task<DbModel.Model.AspNetUser> AddAsync(DbModel.Model.AspNetUser user);
        Task<DbModel.Model.AspNetUser> FindByIdAsync(int id);
        Task<DbModel.Model.AspNetUser> UpdateAsync(int id, DbModel.Model.AspNetUser entity);
        Task<int> DeleteAsync(int id);
    }
}
