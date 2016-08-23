using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace treesap.Controllers
{
    public class JalopyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}