using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

using ProyectoReportes.Models;
using System.Net;
using System.Web;
using ProyectoReportes;

using Rotativa;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoReportes.Controllers
{
    public class ReportesController : Controller
    {
//        private readonly IConfiguration _config;
        
//        public ReportesController(IConfiguration configuration)
//        {
//            _config = configuration;
//        }

//        public ContentResult OnPost()
//        {
//            var nombre = _config["Archivo:Nombre"];
//
//            return Content($"Nombre: {nombre}");
//        }

        [HttpGet]
        public IActionResult Reportes()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Reportes(objetos  objeto)
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error encontrado: " + ex.Message);
                ViewBag.Mensaje = "No se encontró el reporte o no es extención pdf";
                return View(ex.Message);
            }
        }
    }

    public class objetos
    {
        public string nreporte { get; set; } = String.Empty;
    }
}

