using HRM.Web.Data;
using HRM.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRM.Web.Controllers;
public class EmployeeController : Controller
{
    HRMDBContext db = new();
    public IActionResult Index()
    {
        var employees = db.Employees.ToList();

        return View(employees);
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Employee employee)
    {
        db.Employees.Add(employee);
        db.SaveChanges();

        return RedirectToAction("Index");
    }
}