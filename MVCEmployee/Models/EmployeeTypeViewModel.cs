using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MVCEmployee.Models
{
    public class EmployeeTypeViewModel
    {
        public List<Employee> employees;
        public SelectList Department;
        public string employeeType { get; set; }
    }
}
