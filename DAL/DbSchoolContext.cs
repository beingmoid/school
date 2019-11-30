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
            : base("Data Source=DESKTOP-RGPONEB;Initial Catalog=DbSchool;Integrated Security=True")
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
        public DbSet<TeacherCourse> TeacherCourse{ get; set; }
        public DbSet<Test> Test{ get; set; }
        public DbSet<Homework> Homework { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<StudentsInSection> StudentsInSection { get; set; }
        public DbSet<ClassRooms> ClassRooms { get; set; }
        public DbSet<StudentLeaves> StudentLeaves { get; set; }
        public DbSet<StaffLeaves> StaffLeaves { get; set; }
        public DbSet<Salary> Salary{ get; set; }
        public DbSet<StaffSalary> StaffSalary { get; set; }
        public DbSet<ExamType> ExamType { get; set; }
        public DbSet<CourseExam> CourseExam { get; set; }


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
            modelBuilder.Entity<TeacherCourse>().HasRequired<Course>(c => c.Course).WithMany(c => c.TeacherCourse).HasForeignKey<int>(f => f.CourseID);
            modelBuilder.Entity<TeacherCourse>().HasRequired<Staff>(s => s.Staff).WithMany(s => s.TeacherCourse).HasForeignKey<int>(f => f.StaffID);
            modelBuilder.Entity<Test>().HasRequired<Student>(s => s.Student).WithMany(s => s.Test).HasForeignKey<int>(f => f.StudentID);
            modelBuilder.Entity<Test>().HasRequired<Course>(s => s.Course).WithMany(s => s.Test).HasForeignKey<int>(f => f.CourseID);
            modelBuilder.Entity<Homework>().HasRequired<Course>(s => s.Course).WithMany(s => s.Homework).HasForeignKey<int>(f => f.CourseID);
            modelBuilder.Entity<Homework>().HasRequired<Student>(s => s.Student).WithMany(s => s.Homework).HasForeignKey<int>(f => f.StudentID);
            modelBuilder.Entity<Section>().HasRequired<Grade>(s => s.Grade).WithMany(s => s.Section).HasForeignKey<int>(f => f.GradeID);
            modelBuilder.Entity<StudentsInSection>().HasRequired<Student>(s => s.Student).WithMany(s => s.StudentsInSection).HasForeignKey<int>(f => f.StudentID);
            modelBuilder.Entity<StudentsInSection>().HasRequired<Section>(s => s.Section).WithMany(s => s.StudentsInSection).HasForeignKey<int>(f => f.SectionID);
            modelBuilder.Entity<StudentLeaves>().HasRequired<Student>(s => s.Student).WithMany(s => s.StudentLeaves).HasForeignKey<int>(f => f.StudentID);
            modelBuilder.Entity<StaffLeaves>().HasRequired<Staff>(s => s.Staff).WithMany(s => s.StaffLeaves).HasForeignKey<int>(f => f.StaffID);
            modelBuilder.Entity<Salary>().HasRequired<Staff>(s => s.Staff).WithMany(s => s.Salary).HasForeignKey<int>(f => f.StaffID);
            modelBuilder.Entity<StaffSalary>().HasRequired<Staff>(s => s.Staff).WithMany(s => s.StaffSalary).HasForeignKey<int>(f => f.StaffID);

        }
    }
}
