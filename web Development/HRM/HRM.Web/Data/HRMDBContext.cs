
using HRM.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.Web.Data
{
    public class HRMDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=HRM;Integrated Security=true");

        }

        internal object Remove<T>(int id)
        {
            throw new NotImplementedException();
        }
    }
}
