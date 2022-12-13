using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public IActionResult Employeelist()
    {
        List<string> names = new List<string>();
        names.Add("rajkumar");
        names.Add("sitaram");

        names.Sort();
        return View(names);


    }

    


}










