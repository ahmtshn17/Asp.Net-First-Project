using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using YeniProj.Models;

namespace YeniProj.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View("Index",Repository.Courses);
    }

    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
