using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HRBuddy.Data;
using System.Linq;



namespace HRBuddy.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MvcEmployeeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcEmployeeContext>>());
            // Look for any Employees.
            if (context.Employee.Any())
            {
                return;   // DB has been seeded
            }

            context.Employee.AddRange(
                new Employee
                {
                    Name = "Jim Harper",
                    Address = "123 NOwhere st. CA 92562",
                    PhoneNumber = "(951) 710-0655",
                    Email = "jimHarper@theoffice.com",
                    FavColor = "Purple",
                    Position = "Sales Rep",
                    Department = Departments.Sales,
                    Shift = Shifts.Day,
                    Manager = "Michael Scott",
                    Employed = StillEmployed.FullTime,

                    StartDate = DateTime.Parse("1989-2-12"),
                    EndDate = DateTime.Parse("1989-2-12"),
                },
                new Employee
                {
                    Name = "Jim Harper",
                    Address = "123 NOwhere st. CA 92562",
                    PhoneNumber = "(951) 710-0655",
                    Email = "jimHarper@theoffice.com",
                    FavColor = "Purple",
                    Position = "Sales Rep",
                    Department = Departments.Sales,
                    Shift = Shifts.Day,
                    Manager = "Michael Scott",
                    Employed = StillEmployed.Terminated,

                    StartDate = DateTime.Parse("1989-2-12"),
                    EndDate = DateTime.Parse("1989-2-12"),
                }


            );
            context.SaveChanges();
        }
    }
}
