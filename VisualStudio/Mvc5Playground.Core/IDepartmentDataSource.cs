using System.Linq;

namespace Mvc5Playground.Core
{
    public interface IDepartmentDataSource
    {
        IQueryable<Employee> Employees { get; }
        IQueryable<Department> Departments { get; }
        void Save();
    }
}