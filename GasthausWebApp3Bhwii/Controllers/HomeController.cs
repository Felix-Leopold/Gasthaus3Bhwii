using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GasthausWebApp3Bhwii.Models;
using GasthausWebApp3Bhwii.Repositories;

namespace GasthausWebApp3Bhwii.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        TischRepository repo_tisch = new TischRepository();
        List<Tisch> mytische = repo_tisch.GetAllTisches();

        // GastRepository repo_gast = new GastRepository();
        // List<Gast> mygasts = repo_gast.GetAllGaeste();
        
        
        return View(mytische);
        // return View();
        
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