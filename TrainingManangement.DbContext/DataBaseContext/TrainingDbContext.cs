using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.Models;



namespace TrainingManangement.DbContext.DataBaseContext
{
    public class TrainingDbContext:Microsoft.EntityFrameworkCore.DbContext
    {

        public TrainingDbContext()
        {
            
        }

        public TrainingDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer("Server=DESKTOP-9H8CSSN\\SQLEXPRESS; Database=TrainingManagement;Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property(c => c.Name).IsRequired();
            modelBuilder.Entity<Student>().Property(c => c.Email).IsRequired();
            modelBuilder.Entity<Student>().Property(c => c.RegNo).IsRequired();


            modelBuilder.Entity<CourseStudent>().HasKey(c => new {c.CourseId, c.StudentId});
            base.OnModelCreating(modelBuilder);
        }
    }
}
