using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Mvc5Playground.Core;

namespace Mvc5Playground.Infrastructure.Departments
{
    public class DepartmentContext : DbContext, IDepartmentDataSource
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        void IDepartmentDataSource.Save()
        {
            SaveChanges();
        }

        IQueryable<Employee> IDepartmentDataSource.Employees => Employees;

        IQueryable<Department> IDepartmentDataSource.Departments => Departments;

        public DepartmentContext() : this("DefaultConnection") { }

        public DepartmentContext(string connectionStringName) : base(string.Concat("name=", connectionStringName))
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 180;
            // Ensures EntityFramework.SqlServer.dll is copied on deploy.
            var ensureDLLIsCopied =
                    System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
