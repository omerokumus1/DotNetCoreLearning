using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreLearning.Models;

namespace DotNetCoreLearning.Controllers;

public class HomeController : Controller
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger,
        IHttpContextAccessor httpContextAccessor)
    {
        _logger = logger;
        _httpContextAccessor = httpContextAccessor;
    }

    public IActionResult Index()
    {
        CookieOptions options = new();
        options.Expires = DateTime.Now.AddMinutes(5);
        _httpContextAccessor.HttpContext
            .Response
            .Cookies
            .Append("username", "omerokumus", options);

        _httpContextAccessor.HttpContext
            .Response
            .Cookies
            .Delete("username");



        //if (TempData["Country"] != null)
        //{
        //    TempData["Country"] = "Turkey";
        //}

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

