using HRM.ViewModels;
using HRM.Web.Data;
using HRM.Web.Mapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HRM.Web.Controllers;
public class EmployeeController : Controller
{
    private readonly HRMDbContext db;
    public EmployeeController(HRMDbContext _db)
    {
        db = _db;
    }

    public async Task<IActionResult> Index()
    {
        if (db.Employees == null)
            return Problem("Employees dbset don't exist");

        var employees = await db.Employees.
            Include(e => e.Department).
            Include(e => e.Designation).
            ToListAsync();

        var employeesViewModels = employees.ToViewModel();

        return View(employeesViewModels);
    }

    public async Task<IActionResult> Add()
    {
        var departments = await db.Departments.ToListAsync();
        var selectListItems = departments.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
        ViewData["DepartmentList"] = selectListItems;

        var designations = await db.Designations
            .Select(d => new SelectListItem { Text = d.Title, Value = d.Id.ToString() }).ToListAsync();
        ViewData["DesignationList"] = designations;

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(EmployeeViewModel employeeViewModel)
    {
        var profileRelativePath = SaveProfileImage(employeeViewModel.profileImage);
        employeeViewModel.ProfileImageName = profileRelativePath;
        var employee = employeeViewModel.ToModel();

        await db.Employees.AddAsync(employee);

        await db.SaveChangesAsync();

        return RedirectToAction("Index");

    }

    public IActionResult Edit(int? id)
    {
        if (id == null)
            return NotFound();

        var employee = db.Employees
           .Include(e => e.Department)
          .Include(e => e.Designation)
          .FirstOrDefault(e => e.Id == id);

        if (employee is null)
            return NotFound();

        var employeeViewModel = employee.ToViewModel();
       
        var departments = db.Departments.ToList();
        var selectListItems = departments.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
        ViewData["DepartmentList"] = selectListItems;

        var designations = db.Designations
            .Select(d => new SelectListItem { Text = d.Title, Value = d.Id.ToString() }).ToList();
        ViewData["DesignationList"] = designations;


        return View(employeeViewModel);
    }

    [HttpPost]

    public IActionResult Edit(EmployeeViewModel employeeViewModel)
    {
        var employeevm = employeeViewModel.ToModel();
        db.Update(employeevm);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var employee = db.Employees.Find(id);
        var employeemodel = employee.ToViewModel();

        return View(employeemodel);
    }

    [HttpPost]
    public async Task<IActionResult> Delete(EmployeeViewModel employeeViewModel)
    {

        var employee = employeeViewModel.ToModel();

        if (employee == null)
        {
            return NotFound();
        }

        db.Employees.Remove(employee);
        await db.SaveChangesAsync();

        return RedirectToAction("Index");
    }


    private string SaveProfileImage(IFormFile file)
    {
        var fileName = file.FileName; 
        var indexOfDot = fileName.LastIndexOf(".");
        var fileExtenstion = fileName.Substring(indexOfDot);
        var profileRelativePath = $"images/profiles/{Guid.NewGuid()}{fileExtenstion}";
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", profileRelativePath);

        using var stream = System.IO.File.Create(filePath);
        file.CopyTo(stream);

        return profileRelativePath;
    }
}
