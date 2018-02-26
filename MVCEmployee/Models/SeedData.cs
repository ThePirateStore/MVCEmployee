using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MVCEmployee.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCEmployeeContext(
                serviceProvider.GetRequiredService<DbContextOptions<MVCEmployeeContext>>()))
            {
                // Look for any movies.
                if (context.Employee.Any())
                {
                    return;   // DB has been seeded
                }

                context.Employee.AddRange(
                     new Employee
                     {
                         Name = "Henry Winkler",
                         Address = "180 N 4300 E, Logan UT",
                         Email = "henry.winkler@emplyeemg.org",
                         Phone = "(800) 444-5555",
                         Position = "CEO",
                         StartDate = DateTime.Parse("1989-1-11"),
                         EndDate = "2001/1/11",
                         EmploymentStatus = "Full-Time",
                         Department = "Staff",
                         Shift = "",
                         Manager = "",
                         Image = "/img/emplyees/hwinkler.jpg",
                         FavoriteColor = "Blue"
                     },

                     new Employee
                     {
                         Name = "Larry Anderson",
                         Address = "170 N 120 W, Providence UT",
                         Email = "larry.anderson@emplyeemg.org",
                         Phone = "(800) 333-5555",
                         Position = "Programmer 1",
                         StartDate = DateTime.Parse("2015-1-20"),
                         EndDate = "2017/1/11",
                         EmploymentStatus = "Full-Time",
                         Department = "IT Department",
                         Shift = "",
                         Manager = "Marcy Grave",
                         Image = "/img/emplyees/landerson.jpg",
                         FavoriteColor = "Orange"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
