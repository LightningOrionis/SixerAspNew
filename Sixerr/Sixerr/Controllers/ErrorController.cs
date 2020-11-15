﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Sixerr.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/Error/{code}")]
        public IActionResult Error(int code)
        {
            ViewBag.Code = code;
            return View();
        }

        [AllowAnonymous]
        [Route("/Exception")]
        public IActionResult Exception()
        {
            var exeptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            ViewBag.ExceptionPath = exeptionDetails.Path;
            ViewBag.ExceptionMessage = exeptionDetails.Error.Message;
            ViewBag.Stacktrace = exeptionDetails.Error.StackTrace;

            return View();
        }
    }
}
