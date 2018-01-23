using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AngularTest.Models;

namespace AngularTest.Services
{
    public class LabOrderService
    {
        AngularDB db = new AngularDB();

        public async Task<List<LabOrderListViewModel>> GetLabOrderList()
        {
            var result = new List<LabOrderListViewModel>();

            //Load List from Context
            var labOrders = db.LabOrders.OrderByDescending(l => l.OrderDate).ToList();
            foreach (var labOrder in labOrders)
            {
                var lo = new LabOrderListViewModel();
                lo.Id = labOrder.Id;
                lo.OrderDate = labOrder.OrderDate;
                lo.OrderDateDisplay = labOrder.OrderDate.ToString("M/d/yy");
                lo.LabTestName = labOrder.LabTest.LabTestName;
                lo.AmountBilled = labOrder.AmountBilled;
                lo.AmountCollected = labOrder.AmountCollected;
                result.Add(lo);
            }

            return await Task.FromResult(result);
        }

        public async Task<LabOrderDetailViewModel> GetLabOrderDetail(int lo)
        {
            var result = new LabOrderDetailViewModel();
            var labOrder = db.LabOrders.Find(lo);

            //Build detail object from selected lab order
            result.Id = labOrder.Id;
            result.LabTestName = labOrder.LabTest.LabTestName;
            result.PatientName = labOrder.Patient.LastName + ", " + labOrder.Patient.FirstName;
            result.FacilityName = labOrder.Facility.FacilityName;
            result.OrderDateDisplay = labOrder.OrderDate.ToString("m/d/yy");
            result.AmountCollected = labOrder.AmountCollected;

            return await Task.FromResult(result);
        }

        public async Task<bool> UpdateAmountCollected(LabOrderDetailViewModel detail)
        {
            var labOrder = db.LabOrders.Find(detail.Id);
            labOrder.AmountCollected = detail.AmountCollected;
            try
            {
                await db.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                await Task.FromResult(ex.Message);
                return false;
            }
        }
    }
}