using GasthausWebApp3Bhwii.Models;
using GasthausWebApp3Bhwii.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

namespace GasthausWebApp3Bhwii.Controllers;

public class TischController : Controller
{
    // GET
    public IActionResult Index()
    {
        TischRepository repo_tisch = new TischRepository();
        List<Tisch> mytische = repo_tisch.GetAllTisches();
        
        
        return View(mytische);
        
    }

    public IActionResult New()
    {
        return View();

    }

    [HttpPost]
    public IActionResult SaveTisch(Tisch tisch)
    {
        TischRepository repo_tisch = new TischRepository();
        
        repo_tisch.CreateTisch(tisch);

        return Redirect("/Tisch");
    }
    
}