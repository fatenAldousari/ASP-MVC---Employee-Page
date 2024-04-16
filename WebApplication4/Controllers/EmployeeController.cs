using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee {Employeeid = 1123, FirstName = "faten", LastName ="aldousari", Department = "IT", Email = "faten@gmail.com"}
            };
            return View(employees);
        }
    }
}
