namespace hsdal.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CurriculumDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CurriculumDetail()
        {
            StudentReportInformations = new HashSet<StudentReportInformation>();
            DevelopingValues = new HashSet<DevelopingValue>();
            StudentAttendances = new HashSet<StudentAttendance>();
            SubjectRatings = new HashSet<SubjectRating>();
        }

        public int CurriculumDetailId { get; set; }

        public int? StudentId { get; set; }

        public int? CurriculumId { get; set; }

        public int? YearLevelId { get; set; }

        public int? SchoolYearId { get; set; }

        public int? SectionId { get; set; }

        public int? SchoolId { get; set; }

        public bool? CurriculumDetailIsCharRated { get; set; }

        public bool? CurriculumDetailIsBlank { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentReportInformation> StudentReportInformations { get; set; }

        public virtual Curriculum Curriculum { get; set; }

        public virtual School School { get; set; }

        public virtual SchoolYear SchoolYear { get; set; }

        public virtual Section Section { get; set; }

        public virtual YearLevel YearLevel { get; set; }

        public virtual Student Student { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevelopingValue> DevelopingValues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentAttendance> StudentAttendances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubjectRating> SubjectRatings { get; set; }
    }
}
