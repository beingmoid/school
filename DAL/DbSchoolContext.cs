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
        public DbSet<Page> Pages { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<UserSelectedType> UserSelectedType { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<StaffType> StaffType { get; set; }
        public DbSet<Staff> Staff { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sessions>/*Child*/().HasRequired<User>/*Parent*/(s => s.User)/*Parentobj in Child table*/
                .WithMany(s => s.Sessions).HasForeignKey<int>/*Datatype of foreign key*/
                (f => f.UserId)/*Foreignkey*/;

            modelBuilder.Entity<UserRoles>().HasRequired<User>(s => s.User).WithMany(s => s.UserRoles).HasForeignKey<int>(f => f.UserId);
            modelBuilder.Entity<UserRoles>().HasRequired<Page>(p => p.Page).WithMany(p => p.UserRoles).HasForeignKey<int>(f => f.PageID);
            modelBuilder.Entity<UserSelectedType>().HasRequired<User>(s=>s.User).WithMany(s=>s.UserSelectedType).HasForeignKey<int>(f => f.UserID);
            modelBuilder.Entity<UserSelectedType>().HasRequired<UserType>(u => u.UserType).WithMany(u => u.UserSelectedType).HasForeignKey<int>(f => f.UserTypeID);
            modelBuilder.Entity<Staff>().HasRequired<StaffType>(st => st.StaffType).WithMany(st => st.Staff).HasForeignKey<int>(f => f.StaffTypeId);
        }
    }
}
