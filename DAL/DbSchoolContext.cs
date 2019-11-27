namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Entities;

    public partial class DbSchoolContext : DbContext
    {
        public DbSchoolContext()
            : base("Data Source=DESKTOP-M5C4BD6;Initial Catalog=SchoolDb;Integrated Security=True")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Sessions> Sessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sessions>/*Child*/().HasRequired<User>/*Parent*/(s => s.User)/*Parentobj in Child table*/
                .WithMany(s => s.Sessions).HasForeignKey<int>/*Datatype of foreign key*/
                (f => f.UserId)/*Foreignkey*/;
        }
    }
}
