using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Rotativa.AspNetCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoReportes.Controllers
{
    public class DescargaPDFController : Controller
    {
        // GET: /<controller>/
        public IActionResult DescargaPDF()
        {
            return View();
            //return new ViewAsPdf();
        }
    }
}

