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
            : base("Data Source=DESKTOP-MJ87MHR;Initial Catalog=SchoolDb;Integrated Security=True")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Sessions> Sessions { get; set; }   
        public DbSet<Page> Pages { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<StaffType> StaffType { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<UserType> UserType { get; set; }
        public DbSet<UserSelectedType> UserSelectedType { get; set; }
        public DbSet<TeacherCourses> TeacherCourses { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<Fees> fees { get; set; }
        public DbSet<Homework> Homework { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<StudentInSection> StudentInSection { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sessions>/*Child*/().HasRequired<User>/*Parent*/(s => s.User)/*Parentobj in Child table*/
                .WithMany(s => s.Sessions).HasForeignKey<int>/*Datatype of foreign key*/
                (f => f.UserId)/*Foreignkey*/;

            modelBuilder.Entity<UserRoles>().HasRequired<User>(s => s.User).WithMany(s => s.UserRoles).HasForeignKey<int>(f => f.UserId);
            modelBuilder.Entity<UserRoles>().HasRequired<Page>(p => p.Page).WithMany(p => p.UserRoles).HasForeignKey<int>(f => f.PageID);
            modelBuilder.Entity<Staff>().HasRequired<StaffType>(st => st.StaffType).WithMany(st => st.Staff).HasForeignKey<int>(f => f.StaffTypeId);
            modelBuilder.Entity<UserSelectedType>().HasRequired<User>(u => u.User).WithMany(us => us.UserSelectedType).HasForeignKey<int>(f=>f.UserId);
            modelBuilder.Entity<UserSelectedType>().HasRequired<UserType>(ut => ut.UserType).WithMany(us => us.UserSelectedType).HasForeignKey<int>(f => f.UserTypeId);
            modelBuilder.Entity<TeacherCourses>().HasRequired<Course>(c => c.Course).WithMany(tc => tc.TeacherCourses).HasForeignKey<int>(f => f.CourseId);
            modelBuilder.Entity<TeacherCourses>().HasRequired<Staff>(s => s.Staff).WithMany(tc => tc.TeacherCourses).HasForeignKey<int>(f => f.StaffId);
            modelBuilder.Entity<Test>().HasRequired<Course>(c => c.Course).WithMany(t => t.Test).HasForeignKey<int>(f => f.CourseId);
            modelBuilder.Entity<Test>().HasRequired<Student>(s => s.Student).WithMany(t => t.Test).HasForeignKey<int>(f => f.StudentId);
            modelBuilder.Entity<Fees>().HasRequired<Student>(s => s.Student).WithMany(f => f.fees).HasForeignKey<int>(f => f.StudentId);
            modelBuilder.Entity<Fees>().HasRequired<Grade>(g => g.Grade).WithMany(f => f.fees).HasForeignKey<int>(f => f.GradeId);
            modelBuilder.Entity<Homework>().HasRequired<Student>(s => s.Student).WithMany(h => h.Homework).HasForeignKey<int>(f => f.StudentID);
            modelBuilder.Entity<Homework>().HasRequired<Course>(s => s.Course).WithMany(h => h.Homework).HasForeignKey<int>(f => f.CourseID);
            modelBuilder.Entity<Section>().HasRequired<Grade>(s => s.Grade).WithMany(h =>h.Section).HasForeignKey<int>(f => f.Gradeid);
            
        }
    }
}
