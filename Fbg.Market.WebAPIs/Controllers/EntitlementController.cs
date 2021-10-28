using System.Collections.Generic;
using System.Web.Http;
using Fbg.Market.Application;
using Fbg.Market.WebAPIs.AutoMap;
using Fbg.Market.DbModel.Model;
using Fbg.Market.Models.Entitlement;
using System.Threading.Tasks;

namespace FBG.Market.WebAPIs.Controllers
{
    public class EntitlementController : ApiController
    {
        private readonly IEntitlementService _EntitlementService;
        //git
        public EntitlementController(IEntitlementService EntitlementService)
        {
            _EntitlementService = EntitlementService;
        }
        /// <summary>
        /// Saves a new Entitlement.
        /// </summary>
        /// <param name="resource">Entitlement data.</param>
        /// <returns>Response for the request.</returns>
        [System.Web.Http.HttpPost]
        public async Task<IHttpActionResult> PostAsync([FromBody] CreateEntitlementModel resource)
        {
            var prod = AutoMap.Mapper.Map<AspNetUser>(resource);
            var result = await _EntitlementService.CreateAsync(prod);
            var EntitlementResource = AutoMap.Mapper.Map<AspNetUser, CreateEntitlementModel>(result);
            return Ok(EntitlementResource);
        }
        // GET api/values
        public async Task<IHttpActionResult> Get()
        {

            var result = await _EntitlementService.Get();
            return Json(result);
        }

        // GET api/values/5
        public async Task<IHttpActionResult> Get(int id)
        {
            var result = await _EntitlementService.Get(id);
            return Json(result);
        }
        // PUT api/values/5
        public async Task<IHttpActionResult> Put(int id, [FromBody] UpdateEntitlementModel updateEntitlement)
        {
            var Entitlement = AutoMap.Mapper.Map<AspNetUser>(updateEntitlement);
            var result = await _EntitlementService.Update(id, Entitlement);
            return Ok(result);
        }

        // DELETE api/values/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            var result = await _EntitlementService.Delete(id);
            return Ok(result);
        }
    }
}
