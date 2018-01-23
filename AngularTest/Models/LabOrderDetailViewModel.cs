using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AngularTest.Models
{
    public class LabOrderDetailViewModel
    {
        public int Id { get; set; }
        [DisplayName("Lab Test")]
        public string LabTestName { get; set; }
        [DisplayName("Patient Name")]
        public string PatientName { get; set; }
        [DisplayName("Facility Name")]
        public string FacilityName { get; set; }
        public string OrderDateDisplay { get; set; }
        public decimal AmountCollected { get; set; }
    }
}