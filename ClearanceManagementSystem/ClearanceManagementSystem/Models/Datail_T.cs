namespace ClearanceManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Datail_T
    {
        [Key]
        public int ID_Datail { get; set; }

        public int ID_Order { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_Send { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_Answer { get; set; }
    }
}
