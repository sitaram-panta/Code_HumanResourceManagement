using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        List<string> names = new List<string>();
        names.Add("Rajkumar");
        names.Add("Sitaram");

        names.Sort();
        return View(names);


    }
    public IActionResult employeeinfo()
    {
        Dictionary<long, string> employeedetails = new()
        {
            [98433650775] = "sitaram",
            [98433650745] = "rajaram",
            [98433674745] = "shyam",
            [98433850775] = "hari",

        };
       
        
        return View(employeedetails);
    
    }        


}










