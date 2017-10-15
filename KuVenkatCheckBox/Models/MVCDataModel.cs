namespace KuVenkatCheckBox.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MVCDataModel : DbContext
    {
        public MVCDataModel()
            : base("name=MVCDBContext")
        {
        }

        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
