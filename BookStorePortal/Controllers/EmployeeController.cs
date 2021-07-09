using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStorePortal.Controllers
{
    public class EmployeeController : Controller
    {
        public string EmployeePage()
        {
            return "This is Employee Page";
        }
    }
}
