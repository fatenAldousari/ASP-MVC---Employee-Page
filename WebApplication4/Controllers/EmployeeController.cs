using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employees = [
            new Employee {Employeeid = "123", FirstName = "faten", LastName ="aldousari", Department = "IT", Email = "faten@gmail.com"},
            new Employee {Employeeid = "321", FirstName = "noura", LastName ="aldehani", Department = "IT", Email = "nouran@gmail.com"}
            ];
        public IActionResult Index()
        {
            

            return View(employees);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(AddEmployeeForm form)
        {
            if (ModelState.IsValid)
            {
                var Employeeid = form.Employeeid;
                var FirstName = form.FirstName;
                var LastName = form.LastName;
                var Email = form.Email;
                var Department = form.Department;
                employees.Add(new Employee { Employeeid = Employeeid, FirstName = FirstName, LastName = LastName, Department = Department, Email = Email });

                return RedirectToAction("Index");
            }
            return View(form);

        }

    }
}
