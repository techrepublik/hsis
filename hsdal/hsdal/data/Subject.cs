namespace hsdal.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subject()
        {
            SubjectRatings = new HashSet<SubjectRating>();
        }

        public int SubjectId { get; set; }

        [StringLength(50)]
        public string SubjectName { get; set; }

        [StringLength(250)]
        public string SubjectDescription { get; set; }

        public int? SubjectUnit { get; set; }

        public int? CurriculumId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public virtual Curriculum Curriculum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubjectRating> SubjectRatings { get; set; }
    }
}
