using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkTutorial.Entities;

namespace UnitOfWorkTutorial.Data
{
    public class UoWContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-2QF0S4K;Initial Catalog=UoWDb;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//One-to-many ilişkisini kurduk.
        {
            //modelBuilder.Entity<Department>()
            //    .HasMany(x => x.Employees)
            //    .WithOne(x => x.Department)
            //    .HasForeignKey(z => z.DepartmentId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
