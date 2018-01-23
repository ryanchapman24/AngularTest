using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AngularTest.Models
{
    public class LabOrderListViewModel
    {
        public int Id { get; set; }
        public string LabTestName { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderDateDisplay { get; set; }
        [DisplayName("Billed")]
        public decimal AmountBilled { get; set; }
        [DisplayName("Collected")]
        public decimal AmountCollected { get; set; }
    }
}