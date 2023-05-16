namespace ClearanceManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_T
    {
        [Key]
        public int ID_Student { get; set; }

        public int Student_Number { get; set; }

        [Required]
        [StringLength(50)]
        public string Student_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Student_Level { get; set; }

        [Required]
        [StringLength(50)]
        public string College { get; set; }
    }
}
