using apicore.Models;
using Microsoft.EntityFrameworkCore;

namespace apicore.Context
{
    public class ApplicationDbContext:DbContext 
    {

        public  ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

       
        public DbSet<Employee> Employees { get; set; }

    }
}
