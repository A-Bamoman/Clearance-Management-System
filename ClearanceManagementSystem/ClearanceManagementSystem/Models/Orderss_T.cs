namespace ClearanceManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orderss_T
    {
        [Key]
        public int ID_Order { get; set; }

        public int ID_Student { get; set; }

        public int? ID_User { get; set; }

        [StringLength(1000)]
        public string Notes { get; set; }

        public bool? Status { get; set; }
    }
}
