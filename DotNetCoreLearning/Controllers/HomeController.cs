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

    public ViewResult WishUser()
    {
        ViewBag.Message = "Hello";
        return View("Index");
    }

    public RedirectResult GotoURL(string url)
    {
        if (url == null)
            return Redirect("https://www.google.com");
        return Redirect(url);
    }


    public RedirectResult GotoURLPermanently()
    {
        return RedirectPermanent("https://www.google.com");
    }

    public RedirectToActionResult GotoContactsAction()
    {
        // Say for some reason, you want to redirect to WishUser
        return RedirectToAction("WishUser",
            new { url = "https://www.wikipedia.com" }
            );
    }

    // RedirectToRoute

    // FileResult
    public FileResult DownloadFile()
    {
        return File("/css/site.css", "text/plain", "newsite.css");
    }

    public FileResult DownloadLogo()
    {
        return File("./Images/logo.png", "images/png");
    }


    public FileContentResult ShowFile()
    {
        var file = System.IO.File.ReadAllBytes("./wwwroot/css/site.css");
        return new FileContentResult(file, "text/plain");
    }

}

