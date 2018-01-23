using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AngularTest.Models;
using AngularTest.Services;

namespace AngularTest.Api
{
    public class LabOrderDetailController : ApiController
    {
        AngularDB db = new AngularDB();
        LabOrderService service = new LabOrderService();

        // GET: api/LabOrderDetail
        public async Task<LabOrderDetailViewModel> Get(int lo)
        {
            //TODO:Complete service implementation
            var result = await service.GetLabOrderDetail(lo);
            return result;
        }

        // POST: api/LabOrderDetail
        public async Task<string> Post(LabOrderDetailViewModel detail)
        {
            //TODO:Complete service implementation
            bool result = await service.UpdateAmountCollected(detail);
            if (result)
                return "successful";
            else
                return "unsuccessful";
        }

    }
}
