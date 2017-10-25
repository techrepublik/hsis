namespace hsdal.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Section
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Section()
        {
            CurriculumDetails = new HashSet<CurriculumDetail>();
        }

        public int SectionId { get; set; }

        [StringLength(50)]
        public string SectionName { get; set; }

        [StringLength(250)]
        public string SectionDescription { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurriculumDetail> CurriculumDetails { get; set; }
    }
}
