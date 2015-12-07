using System;
using System.Collections.Generic;

namespace _03_CompanyHierarchy.Interfaces
{
    interface ISaleEmployee
    {
        List<Sale> Sales { get; set; }
    }
}
