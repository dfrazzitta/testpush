using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using testpush.Models;

namespace testpush.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    // test me
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
