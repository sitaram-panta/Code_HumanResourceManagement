using HRM.Web.Enums;

namespace HRM.Models;
public class Designation
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public Role Role { get; set; }

    public virtual ICollection<Employee> Employees { get; set; }
}
