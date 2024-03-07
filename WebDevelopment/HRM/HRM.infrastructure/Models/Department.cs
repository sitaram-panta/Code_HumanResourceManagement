﻿using HRM.Models;
namespace HRM.Web.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Established { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
