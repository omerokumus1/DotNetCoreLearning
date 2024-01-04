using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreLearning.Models;

namespace DotNetCoreLearning.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    static List<Product> products = new()
    {
            new Product {
                ProductID = 1,
                ProductName = "AMD Ryzen 3990",
                Quantity=100,
                UnitsInStock=50,
                Discontinued = false,
                Cost=3000,
                LaunchDate=new DateTime(2019,10,1)
            },
            new Product {
                ProductID = 2,
                ProductName = "AMD Ryzen 3970",
                Quantity=100,
                UnitsInStock=70,
                Discontinued = false,
                Cost=2500,
                LaunchDate=new DateTime(2019,10,5)
            },
               new Product {
                ProductID = 3,
                ProductName = "AMD Ryzen 3960",
                Quantity=100,
                UnitsInStock=80,
                Discontinued = false,
                Cost=2000,
                LaunchDate=new DateTime(2019,10,15)
            },
                  new Product {
                ProductID = 4,
                ProductName = "AMD Ryzen 3950",
                Quantity=100,
                UnitsInStock=40,
                Discontinued = false,
                Cost=1500,
                LaunchDate=new DateTime(2019,10,25)
            }

        };

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(products);
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

