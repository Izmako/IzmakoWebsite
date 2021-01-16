using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IzmakoProjesi.Controllers
{
    public class GrafikController : Controller
    {
        public IActionResult GraphicPage()
        {
            return View();
        }
    }
}
