using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SignUp_main.Models;

namespace SignUp_main.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Prenota(){
        return View();
    }

    [HttpPost]
    public IActionResult Prenota(Prenotazione p)
    {
        return View(p);
    }

    [HttpGet]
    public IActionResult Purchase(){
        return View();
    }

    [HttpPost]
    public IActionResult Purchase(Purchasing v)
    {
        return View(v);
    }

    [HttpPost]
    public IActionResult comprare(Prenotazione p)
    {
        return View(p);
    }

     [HttpPost]
    public IActionResult cart(Purchasing v)
    {
        return View(v);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}