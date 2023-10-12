namespace Lab14.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelEF : DbContext
    {
        public ModelEF()
            : base("name=ModelEF")
        {
        }

        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
