using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoReportes.Controllers
{
    public class SandboxController : Controller
    {


        // GET: /<controller>/
        public IActionResult Sandbox()
        {
            return View();
        }

         public FileResult DownloadMessage()
        {
            String text = "Hola mundo" + Environment.NewLine + "Hoy es Martes";
            byte[] result = Encoding.ASCII.GetBytes(text);
            //return File(result, "application/pdf", "mensaje.pdf");
            return new FileContentResult(result, "application/pdf");
        }

        public FileResult DownloadStream()
        {
            String text = "Hola mundo" + Environment.NewLine + "Hoy es Martes";
            byte[] result = Encoding.ASCII.GetBytes(text);
            var stream = new MemoryStream(result);
            return File(stream, "text/plain", "stream.txt");
        }

        [HttpPost]
        public FileResult DownloadPersonalizado(String mensaje)
        {
            String text = mensaje;
            byte[] result = Encoding.ASCII.GetBytes(text);
            return File(result, "text/html", "personalizado.html");
            //return File(result, "text/html");
        }

    }
}


