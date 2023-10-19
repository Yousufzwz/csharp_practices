using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_Practice_;

public class Company
{
    public string CompanyName { get; set; }
    public List<Department> Departments { get; set; }
    public CEO CompanyCEO { get; set; }
    public Department HRDepartment { get; set; }
    public Department ITDepartment { get; set; }
    public List<Employee> Employees { get; set; }
}
