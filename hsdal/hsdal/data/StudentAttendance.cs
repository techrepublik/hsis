namespace hsdal.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentAttendance")]
    public partial class StudentAttendance
    {
        [Key]
        public int AttendanceId { get; set; }

        public int? AttendanceJune { get; set; }

        public int? AttendanceJuly { get; set; }

        public int? AttendanceAugust { get; set; }

        public int? AttendanceSeptember { get; set; }

        public int? AttendanceOctober { get; set; }

        public int? AttendanceNovember { get; set; }

        public int? AttendanceDecember { get; set; }

        public int? AttendanceJanuary { get; set; }

        public int? AttendanceFebruary { get; set; }

        public int? AttendanceMarch { get; set; }

        public int? AttendanceApril { get; set; }

        public int? AttendanceMay { get; set; }

        public int? AttendanceTotal { get; set; }

        [StringLength(50)]
        public string AttendanceParticular { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public int? CurriculumDetailId { get; set; }

        public virtual CurriculumDetail CurriculumDetail { get; set; }
    }
}
