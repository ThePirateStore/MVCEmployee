using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCEmployee.Models
{
    public class MVCEmployeeContext : DbContext
    {
        public MVCEmployeeContext (DbContextOptions<MVCEmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<MVCEmployee.Models.Employee> Employee { get; set; }
    }
}
