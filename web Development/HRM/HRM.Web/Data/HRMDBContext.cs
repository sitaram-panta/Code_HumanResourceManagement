using HRM.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.Web.Data
{
    public class HRMDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=HRM;Integrated Security=true");

        }
       
    }
}
