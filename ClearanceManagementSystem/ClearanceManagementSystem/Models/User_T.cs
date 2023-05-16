namespace ClearanceManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_T
    {
        [Key]
        public int ID_User { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        public int Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Name_Office { get; set; }
    }
}
