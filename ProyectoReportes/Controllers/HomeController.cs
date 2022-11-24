using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProyectoReportes.Models;
using ProyectoReportes.Controllers;

using Rotativa.AspNetCore;

namespace ProyectoReportes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //return View();
        //return new Rotativa.AspNetCore.ViewAsPdf("Index");
        return new ViewAsPdf("Index");

    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

