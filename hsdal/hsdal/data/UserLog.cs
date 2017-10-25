namespace hsdal.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserLog
    {
        public int UserLogId { get; set; }

        public DateTime? UserLogIn { get; set; }

        public DateTime? UserLogOut { get; set; }

        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
