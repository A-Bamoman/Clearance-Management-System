namespace ClearanceManagementSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CMS : DbContext
    {
        public CMS()
            : base("name=CMS4")
        {
        }

        public virtual DbSet<Datail_T> Datail_T { get; set; }
        public virtual DbSet<Orderss_T> Orderss_T { get; set; }
        public virtual DbSet<Student_T> Student_T { get; set; }
        public virtual DbSet<User_T> User_T { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
