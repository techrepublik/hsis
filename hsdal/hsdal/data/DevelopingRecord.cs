namespace hsdal.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DevelopingRecord
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DevelopingRecord()
        {
            DevelopingValues = new HashSet<DevelopingValue>();
        }

        public int DevelopingRecordId { get; set; }

        [StringLength(500)]
        public string DevelopingRecordName { get; set; }

        [StringLength(500)]
        public string DevelopingRecordComment { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevelopingValue> DevelopingValues { get; set; }
    }
}
