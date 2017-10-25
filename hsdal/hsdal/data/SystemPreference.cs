namespace hsdal.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SystemPreference
    {
        public int SystemPreferenceId { get; set; }

        [StringLength(150)]
        public string SchoolName { get; set; }

        [StringLength(250)]
        public string SchoolAddress { get; set; }

        [StringLength(100)]
        public string SchoolPrincipal { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(25)]
        public string ModifiedBy { get; set; }
    }
}
