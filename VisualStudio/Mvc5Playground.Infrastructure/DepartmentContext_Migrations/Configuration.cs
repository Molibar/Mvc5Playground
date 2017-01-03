using Mvc5Playground.Core;

namespace Mvc5Playground.Infrastructure.DepartmentContext_Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Departments.DepartmentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DepartmentContext_Migrations";
            ContextKey = "DepartmentContext";
        }

        protected override void Seed(Mvc5Playground.Infrastructure.Departments.DepartmentContext context)
        {
            context.Departments.AddOrUpdate(d => d.Name,
                new Department { Name = "Engineering" },
                new Department { Name = "Sales" },
                new Department { Name = "Shipping" },
                new Department { Name = "Human Resources" });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
