namespace AngularTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LabOrder")]
    public partial class LabOrder
    {
        public int Id { get; set; }

        public int LabTestId { get; set; }

        public int PatientId { get; set; }

        public int FacilityId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "money")]
        public decimal AmountBilled { get; set; }

        [Column(TypeName = "money")]
        public decimal AmountCollected { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual LabTest LabTest { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
