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
                    PhoneNumber = 123,
                    Email = "jimHarper@theoffice.com",
                    FavColor = "Purple",
                    Position = "Sales Rep",
                    Department = "Sales",
                    Shift = "Day",
                    Manager = "Michael Scott",
                    Employed = 1,

                    StartDate = DateTime.Parse("1989-2-12"),
                    EndDate = DateTime.Parse("1989-2-12"),
                },
                new Employee
                {
                    Name = "Jim Harper",
                    Address = "123 NOwhere st. CA 92562",
                    PhoneNumber = 123,
                    Email = "jimHarper@theoffice.com",
                    FavColor = "Purple",
                    Position = "Sales Rep",
                    Department = "Sales",
                    Shift = "Day",
                    Manager = "Michael Scott",
                    Employed = 1,

                    StartDate = DateTime.Parse("1989-2-12"),
                    EndDate = DateTime.Parse("1989-2-12"),
                }


            );
            context.SaveChanges();
        }
    }
}
