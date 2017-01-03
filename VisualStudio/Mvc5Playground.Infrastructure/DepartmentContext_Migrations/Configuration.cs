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
        }
    }
}
