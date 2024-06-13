using GasthausWebApp3Bhwii.Models;
using GasthausWebApp3Bhwii.Repositories;
using Microsoft.AspNetCore.Mvc;

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
}