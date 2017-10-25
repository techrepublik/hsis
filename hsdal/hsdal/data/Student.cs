namespace hsdal.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            CurriculumDetails = new HashSet<CurriculumDetail>();
            StudentBrothers = new HashSet<StudentBrother>();
            StudentBrothers1 = new HashSet<StudentBrother>();
            SummaryOfCredits = new HashSet<SummaryOfCredit>();
        }

        public int StudentId { get; set; }

        [Column(TypeName = "image")]
        public byte[] StudentPhoto { get; set; }

        [StringLength(50)]
        public string StudentIdNo { get; set; }

        [StringLength(50)]
        public string StudentLRN { get; set; }

        [StringLength(25)]
        public string StudentLastName { get; set; }

        [StringLength(25)]
        public string StudentFirstName { get; set; }

        [StringLength(25)]
        public string StudentMiddleName { get; set; }

        [StringLength(25)]
        public string StudentGender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StudentBirthDate { get; set; }

        [StringLength(250)]
        public string StudentBirthPlace { get; set; }

        [StringLength(150)]
        public string StudentBarangay { get; set; }

        [StringLength(150)]
        public string StudentTown { get; set; }

        [StringLength(150)]
        public string StudentProvince { get; set; }

        [StringLength(150)]
        public string StudentLastSchoolAttended { get; set; }

        [StringLength(10)]
        public string StudentLastSchoolAttendedSchoolYear { get; set; }

        [StringLength(150)]
        public string StudentFathersFullName { get; set; }

        [StringLength(50)]
        public string StudentFathersAddress { get; set; }

        [StringLength(50)]
        public string StudentFathersOccupation { get; set; }

        [StringLength(50)]
        public string StudentFathersTribe { get; set; }

        [StringLength(150)]
        public string StudentMothersFullName { get; set; }

        [StringLength(50)]
        public string StudentMothersAddress { get; set; }

        [StringLength(50)]
        public string StudentMothersOccupation { get; set; }

        [StringLength(50)]
        public string StudentMothersTribe { get; set; }

        [StringLength(100)]
        public string StudentNumberOfYears { get; set; }

        [StringLength(100)]
        public string StudentCourseCompleted { get; set; }

        [StringLength(10)]
        public string StudentSchoolYearCompleted { get; set; }

        public double? StudentGeneralAverageCompleted { get; set; }

        [StringLength(50)]
        public string StudentEligibleTransferTo { get; set; }

        [StringLength(50)]
        public string StudentRemarks { get; set; }

        [StringLength(25)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurriculumDetail> CurriculumDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentBrother> StudentBrothers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentBrother> StudentBrothers1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SummaryOfCredit> SummaryOfCredits { get; set; }
    }
}
