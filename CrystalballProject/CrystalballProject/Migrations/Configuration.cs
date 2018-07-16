namespace CrystalballProject.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CrystalballProject.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CrystalballProject.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Roles.AddOrUpdate(
                s => s.Name,
                    new IdentityRole { Name = "Admin" },
                    new IdentityRole { Name = "Employee" }
                 );
            context.SaveChanges();

            context.Weeks.AddOrUpdate(
                w => w.Day,
                    new Models.Week { Day = "Monday" },
                    new Models.Week { Day = "Tuesday" },
                    new Models.Week { Day = "Wednesday" },
                    new Models.Week { Day = "Thursday" },
                    new Models.Week { Day = "Friday" },
                    new Models.Week { Day = "Saturday" },
                    new Models.Week { Day = "Sunday" }
                );
            context.SaveChanges();
        }
    }
}
