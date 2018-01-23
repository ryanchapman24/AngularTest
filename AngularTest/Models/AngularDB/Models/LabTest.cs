namespace AngularTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LabTest")]
    public partial class LabTest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LabTest()
        {
            LabOrders = new HashSet<LabOrder>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string LabTestName { get; set; }

        [Required]
        [StringLength(10)]
        public string LabTestCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LabOrder> LabOrders { get; set; }
    }
}
