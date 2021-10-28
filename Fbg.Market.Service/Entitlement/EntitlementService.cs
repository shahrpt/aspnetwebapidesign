using Fbg.Market.Application;
using Fbg.Market.DbModel;
using Fbg.Market.DbModel.Model;
using Fbg.Market.Models.Entitlement;
using Fbg.Market.Models.Product;
using Fbg.Market.Repository.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbg.Market.Service.Product
{
    public class EntitlementService : IEntitlementService
    {
        private readonly IEntitlementRepository _EntitlementRepository;

       
        public EntitlementService(IEntitlementRepository EntitlementService)
        {
            _EntitlementRepository = EntitlementService;
        }

        public async Task<AspNetUser> CreateAsync(AspNetUser model)
        {
            return await _EntitlementRepository.AddAsync(model);
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AspNetUser>> Get()
        {
            UserQuery query = new UserQuery();
            return await _EntitlementRepository.ListAsync(query);
        }
        public Task<AspNetUser> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<AspNetUser> Update(int id, AspNetUser model)
        {
            return await _EntitlementRepository.UpdateAsync(id, model);
        }
    }

}
