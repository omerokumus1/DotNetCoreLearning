using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreLearning.Models;

namespace DotNetCoreLearning.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly IWebHostEnvironment _environment;

    public HomeController(ILogger<HomeController> logger, IWebHostEnvironment environment)
    {
        _logger = logger;
        _environment = environment;
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


    public ContentResult GreetUser()
    {
        //return Content("Hello!");
        //return Content("<div><b>Hello</b></div>", "text/html");
        //return Content("<div><b>Hello</b></div>", "text/xml");
        //return Content(_environment.ContentRootPath);
        return Content(_environment.WebRootPath);
    }

}

