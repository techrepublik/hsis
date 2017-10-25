namespace hsdal.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class School
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public School()
        {
            CurriculumDetails = new HashSet<CurriculumDetail>();
        }

        public int SchoolId { get; set; }

        [StringLength(50)]
        public string SchoolName { get; set; }

        [StringLength(250)]
        public string SchoolAddress { get; set; }

        [StringLength(250)]
        public string SchoolDescription { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurriculumDetail> CurriculumDetails { get; set; }
    }
}
