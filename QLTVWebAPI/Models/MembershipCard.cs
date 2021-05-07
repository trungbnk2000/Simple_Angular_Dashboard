namespace QLTVWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MembershipCard")]
    public partial class MembershipCard
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Job { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpiredDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public int? RentedCount { get; set; }

        public int? PendingCount { get; set; }

        public bool? Status { get; set; }
    }
}
