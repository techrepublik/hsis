namespace hsdal.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StudentBrother
    {
        [Key]
        public int BrotherId { get; set; }

        public int? StudentSelectedBroId { get; set; }

        public int? StudentId { get; set; }

        public virtual Student Student { get; set; }

        public virtual Student Student1 { get; set; }
    }
}
