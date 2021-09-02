using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace ZooBookApi.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> employees { get; set; }
    }
}