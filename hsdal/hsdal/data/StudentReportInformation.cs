namespace hsdal.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StudentReportInformation
    {
        [Key]
        public int StudentReportInformationsId { get; set; }

        [StringLength(50)]
        public string StudentReportInformationReportsName { get; set; }

        [StringLength(250)]
        public string StudentReportInformationDescription { get; set; }

        public int? StudentReportInformationCode { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public int? CurriculumDetailId { get; set; }

        public virtual CurriculumDetail CurriculumDetail { get; set; }
    }
}
