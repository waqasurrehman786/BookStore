using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStorePortal.Controllers
{
    public class HomeController : Controller
    {
        public string getName()
        {
            return "My Name is Waqas";
        }
        public string ContactUs()
        {
            return "Contact Us 03126668399";
        }
    }
}
