namespace hsdal.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YearLevel")]
    public partial class YearLevel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public YearLevel()
        {
            CurriculumDetails = new HashSet<CurriculumDetail>();
        }

        public int YearLevelId { get; set; }

        [StringLength(50)]
        public string YearLevelName { get; set; }

        [StringLength(500)]
        public string YearLevelDescription { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurriculumDetail> CurriculumDetails { get; set; }
    }
}
