using Employee.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Employee.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EmployeeList> Employee { get; set; }


        public DbSet<Department> Department { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Manager> Manager { get; set; }

        public DbSet<Tasks> Tasks { get; set; }
    }
}