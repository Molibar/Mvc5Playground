using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mvc5Playground.Core
{
    public class Department
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}