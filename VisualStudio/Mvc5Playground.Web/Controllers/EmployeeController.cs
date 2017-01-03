using System.Linq;
using System.Web.Mvc;
using Mvc5Playground.Core;
using Mvc5Playground.Web.Models.Employee;

namespace Mvc5Playground.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmployeeController : Controller
    {
        private readonly IDepartmentDataSource _db;
        public EmployeeController(IDepartmentDataSource db)
        {
            _db = db;
        }
        
        [HttpGet]
        public ActionResult Create(int departmentId)
        {
            var model = new CreateEmployeeViewModel {DepartmentId = departmentId};
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateEmployeeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var department = _db.Departments.Single(x => x.Id == viewModel.DepartmentId);
                var employee = new Employee
                {
                    Name = viewModel.Name,
                    HireDate = viewModel.HireDate
                };
                department.Employees.Add(employee);
                _db.Save();

                return RedirectToAction("Detail", "Department", new {Id = viewModel.DepartmentId});
            }
            return View(viewModel);
        }
    }
}