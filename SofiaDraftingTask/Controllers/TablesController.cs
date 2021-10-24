using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SofiaDraftingTask.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult People()
        {
            return View();
        }
    }
}
