using System;
using System.ComponentModel.DataAnnotations;

namespace Mvc5Playground.Core
{
    public class Employee
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime? HireDate { get; set; }
    }
}
