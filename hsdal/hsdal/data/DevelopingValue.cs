namespace hsdal.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DevelopingValue
    {
        public int DevelopingValueId { get; set; }

        public int? DevelopingValueRatings { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }

        public int? DevelopingRecordId { get; set; }

        public int? CurriculumDetailId { get; set; }

        public virtual CurriculumDetail CurriculumDetail { get; set; }

        public virtual DevelopingRecord DevelopingRecord { get; set; }
    }
}
