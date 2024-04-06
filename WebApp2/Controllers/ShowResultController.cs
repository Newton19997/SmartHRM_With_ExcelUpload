using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2.Controllers
{
    public class ShowResultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
