using HRM.Web.Enums;
using HRM.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace HRM.Models;

public class Employee
{
    public int Id { get; set; }

    [Display(Name = "First Name")]
    [MinLength(2)]
    [Required]
    public string FirstName { get; set; } = string.Empty;

    [Display(Name = "Last Name")]
    [Required]
    public string LastName { get; set; } = string.Empty;
    [Required]
    public Gender Gender { get; set; } = Gender.Male;
    public string? Address { get; set; }

    [Display(Name = "Date Of Birth")]
    public DateTime? Dob { get; set; }
    public string? Bio { get; set; } = string.Empty;

    public string? ProfileImageName { get; set; }

    public int DepartmentId { get; set; }
    public virtual Department Department { get; set; }

    public int DesignationId { get; set; }
    public virtual Designation Designation { get; set; }

}
