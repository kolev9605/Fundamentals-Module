using System;
using System.Collections.Generic;

namespace _03_CompanyHierarchy.Employees
{
    interface IDeveloper
    {
        List<Project> Projects { get; set; }
    }
}
