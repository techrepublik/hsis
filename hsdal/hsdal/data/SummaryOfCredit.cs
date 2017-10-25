namespace hsdal.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SummaryOfCredit
    {
        public int SummaryOfCreditId { get; set; }

        [StringLength(150)]
        public string FirstCurriculumSubject { get; set; }

        [StringLength(50)]
        public string FirstCurriculumYearCompleted { get; set; }

        public int? FirstCurriculumCreditsEarned { get; set; }

        [StringLength(150)]
        public string SecondCurriculumSubject { get; set; }

        [StringLength(50)]
        public string SecondCurriculumYearCompleted { get; set; }

        public int? SecondCurriculumCreditsEarned { get; set; }

        [StringLength(150)]
        public string ThirdCurriculumSubject { get; set; }

        [StringLength(50)]
        public string ThirdCurriculumYearCompleted { get; set; }

        public int? ThirdCurriculumCreditsEarned { get; set; }

        [StringLength(150)]
        public string FourthCurriculumSubject { get; set; }

        [StringLength(50)]
        public string FourthCurriculumYearCompleted { get; set; }

        public int? FourthCurriculumCreditsEarned { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public int? StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
