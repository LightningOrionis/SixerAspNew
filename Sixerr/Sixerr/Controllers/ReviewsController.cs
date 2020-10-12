using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sixerr.Controllers
{
    public class ReviewsController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
