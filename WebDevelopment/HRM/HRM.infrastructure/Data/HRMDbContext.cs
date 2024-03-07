using HRM.Models;
using HRM.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.Web.Data
{
    public class HRMDbContext : DbContext
    {


        public HRMDbContext(DbContextOptions<HRMDbContext> Options) : base(Options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
