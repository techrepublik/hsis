namespace hsdal.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SubjectRating
    {
        public int SubjectRatingId { get; set; }

        public double? SubjectRatingOne { get; set; }

        public double? SubjectRatingTwo { get; set; }

        public double? SubjectRatingThree { get; set; }

        public double? SubjectRatingFour { get; set; }

        public double? SubjectRatingFinalRating { get; set; }

        public int? SubjectRatingUnit { get; set; }

        public bool? SubjectRatingActionTaken { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public int? SubjectId { get; set; }

        public int? CurriculumDetailId { get; set; }

        public virtual CurriculumDetail CurriculumDetail { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
